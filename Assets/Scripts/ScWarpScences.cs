using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// シーン間の移動を制御
/// </summary>
public class ScWarpScences : MonoBehaviour
{
    /// <summary>
    /// フェード処理に必要なImage情報
    /// コンポーネントで登録する為にパブリック化
    /// </summary>
    public Image fadeImage;
    /// <summary>不透明度変化の速度</summary>
    private float fadeSpeed;
    /// <summary>
    /// Imageのカラー値を管理
    /// RGB、不透明度
    /// </summary>
    private float red, green, blue, alfa;
    /// <summary>シーン遷移のための型</summary>
    private string currentScene;

    /// <summary>フェードイン処理管理用のコルーチン</summary>
    private IEnumerator fadeInCoroutine;
    /// <summary>フェードアウト処理管理用のコルーチン</summary>
    private IEnumerator fadeOutCoroutine;

    /// <summary>プレイヤースクリプト</summary>
    private ScOperationPlayer scOprPlyer;
    /// <summary>タイマースクリプト</summary>
    private ScTimer scTimer;
    /// <summary>共通ロジック</summary>
    private CsNormalLogicDesignOfCommon lgc;
    /// <summary>Imageのカラー情報</summary>
    private CsNormalLogicDesignOfSceneStaging logicScene;

    /// <summary>現在存在しているオブジェクト実体の記憶領域</summary>
    static ScWarpScences _instanceScWarpScences = null;

    /// <summary>オブジェクト実体の参照（初期参照時、実体の登録も行う）</summary>
    static ScWarpScences instanceScWarpScences
    {
        get { return _instanceScWarpScences ?? (_instanceScWarpScences = FindObjectOfType<ScWarpScences>()); }
    }

    private void Awake()
    {
        if (this != instanceScWarpScences)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }

        this.lgc = new CsNormalLogicDesignOfCommon();
        this.logicScene = new CsNormalLogicDesignOfSceneStaging();
    }

    // Start is called before the first frame update
    void Start()
    {
        this.scTimer = lgc.GetComponentScriptInGameObject<ScTimer>(CsNormalLevelDesignOfCommon.GAMEOBJECTS_TIMER);

        this.fadeInCoroutine = FadeIn();
        this.fadeOutCoroutine = FadeOut();
        this.fadeSpeed = 0.75f;

        StartCoroutine(fadeInCoroutine);
        SceneManager.sceneLoaded += FadeInStart;

        this.scOprPlyer = lgc.GetComponentScriptInGameObject<ScOperationPlayer>(CsNormalLevelDesignOfBall.GAMEOBJECTS_SP_BALL);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDestroy()
    {
        // ※破棄時に、登録した実体の解除を行なっている
        // 自身がインスタンスなら登録を解除
        if (this == instanceScWarpScences) _instanceScWarpScences = null;
    }

    /// <summary>
    /// フェードインを実行するコルーチンを取得
    /// </summary>
    /// <returns></returns>
    private IEnumerator FadeIn()
    {
        for (int i = 0; i < 360 || logicScene.alpha > 0.0f; i++)
        {
            this.logicScene.alpha = Mathf.MoveTowards(logicScene.alpha, 0f, fadeSpeed * Time.deltaTime);
            this.fadeImage.color = this.logicScene.fadeImageColor;
            yield return null;
            if (logicScene.alpha < 0.1f)
            {
                StopCoroutine(fadeInCoroutine);
                if (scOprPlyer == null)
                {
                    this.scOprPlyer = lgc.GetComponentScriptInGameObject<ScOperationPlayer>(CsNormalLevelDesignOfBall.GAMEOBJECTS_SP_BALL);
                }
                if (!ReferenceEquals(scOprPlyer, null) && scOprPlyer != null)
                {
                    scOprPlyer.OparationEnableSwitch();
                }
                if (scTimer == null)
                {
                    this.scTimer = lgc.GetComponentScriptInGameObject<ScTimer>(CsNormalLevelDesignOfCommon.GAMEOBJECTS_TIMER);
                }
                if (!ReferenceEquals(scTimer, null) && scTimer != null)
                {
                    scTimer.TimerEnableSwitch();
                }
            }
        }
    }

    /// <summary>
    /// フェードアウトを実行するコルーチンを取得
    /// </summary>
    /// <returns></returns>
    private IEnumerator FadeOut()
    {
        for (int i = 0; i < 360 || logicScene.alpha < 1.1f; i++)
        {
            this.logicScene.alpha = Mathf.MoveTowards(logicScene.alpha, 1f, fadeSpeed * Time.deltaTime);
            this.fadeImage.color = this.logicScene.fadeImageColor;
            yield return null;
            if (logicScene.alpha > 0.9f)
            {
                WarpScencesResultClear(currentScene);
                StopCoroutine(fadeOutCoroutine);
            }
        }
    }

    /// <summary>
    /// 渡されたシーン名に紐づくシーンに移動
    /// </summary>
    /// <param name="sceneName"></param>
    private void WarpScencesResultClear(string sceneName)
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.Log("不正な値です");
        }
    }

    /// <summary>
    /// 時間計測結果用のスクリプトに計測時間を渡す
    /// </summary>
    private void GameSceneLoaded()
    {
        ScResultSet sc = lgc.GetComponentScriptInGameObject<ScResultSet>(CsNormalLevelDesignOfCommon.GAMEOBJECTS_RESULT_SETTER);
        if (sc != null)
        {
            sc.resultTime = scTimer.countTime;
        }
    }

    /// <summary>
    /// シーン遷移が完了した際にフェードインを開始するように設定
    /// </summary>
    /// <param name="scene"></param>
    /// <param name="mode"></param>
    private void FadeInStart(Scene scene, LoadSceneMode mode)
    {
        // フェードImageを表示する為のCanvasへカメラ情報をセット
        Camera targetCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        GameObject.Find("Canvas").GetComponent<Canvas>().worldCamera = targetCamera;
        this.fadeInCoroutine = FadeIn();
        StartCoroutine(fadeInCoroutine);
        GameSceneLoaded();
    }

    /// <summary>
    /// フェードアウト開始時の画像のRGBA値と次のシーン名を指定
    /// </summary>
    /// <param name="red">画像の赤成分</param>
    /// <param name="green">画像の緑成分</param>
    /// <param name="blue">画像の青成分</param>
    /// <param name="alpha">画像の透明度</param>
    /// <param name="nextScene">遷移先のシーン名</param>
    public void FadeOutStart(float red, float green, float blue, float alpha, string nextScene)
    {
        this.logicScene.red = red;
        this.logicScene.green = green;
        this.logicScene.blue = blue;
        this.logicScene.alpha = alpha;
        this.fadeImage.color = this.logicScene.fadeImageColor;
        this.currentScene = nextScene;
        this.fadeOutCoroutine = FadeOut();
        StartCoroutine(fadeOutCoroutine);
    }
}
