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
    private ScOprationPlayer scOprPlyer;
    /// <summary>タイマースクリプト</summary>
    private ScTimer scTimer;

    // Start is called before the first frame update
    void Start()
    {
        this.scTimer = GetComponentScriptInGameObject<ScTimer>(ScLevelDesignCommon.GAMEOBJECTS_TIMER);

        this.fadeInCoroutine = FadeIn();
        this.fadeOutCoroutine = FadeOut();

        // TODO:20201123 ManageObjectがいくつも作られないように、個数を数える処理を作る
        DontDestroyOnLoad(this);

        this.fadeSpeed = 0.75f;

        SetRGBA(0, 0, 0, 1);
        StartCoroutine(fadeInCoroutine);
        SceneManager.sceneLoaded += FadeInStart;

        this.scOprPlyer = GetComponentScriptInGameObject<ScOprationPlayer>(ScLevelDesignOfBall.GAMEOBJECTS_SP_BALL);
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// フェードインを実行するコルーチンを取得
    /// </summary>
    /// <returns></returns>
    private IEnumerator FadeIn()
    {
        for (int i = 0; i < 360 || alfa > 0.0f; i++)
        {
            this.alfa = Mathf.MoveTowards(alfa, 0f, fadeSpeed * Time.deltaTime);
            SetColor();
            yield return null;
            if (alfa < 0.1f)
            {
                StopCoroutine(fadeInCoroutine);
                scOprPlyer.OparationEnableChange();
                if (!ReferenceEquals(scTimer, null) && scTimer != null) scTimer.TimerEnableSwitch();
            }
        }
    }

    /// <summary>
    /// フェードアウトを実行するコルーチンを取得
    /// </summary>
    /// <returns></returns>
    private IEnumerator FadeOut()
    {
        for (int i = 0; i < 360 || alfa < 1.1f; i++)
        {
            this.alfa = Mathf.MoveTowards(alfa, 1f, fadeSpeed * Time.deltaTime);
            SetColor();
            yield return null;
            if (alfa > 0.9f)
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
        ScResultSet sc = GetComponentScriptInGameObject<ScResultSet>(ScLevelDesignCommon.GAMEOBJECTS_RESULT_SETTER);
        if (sc != null) sc.resultTime = scTimer.countTime;
    }

    /// <summary>
    /// ゲームオブジェクトにコンポーネントされているスクリプトを取得
    /// </summary>
    /// <typeparam name="Type">スクリプトクラスの型</typeparam>
    /// <param name="key">ゲームオブジェクト名</param>
    /// <returns>スクリプト</returns>
    private Type GetComponentScriptInGameObject<Type>(string key)
    {
        GameObject g = GameObject.Find(key);
        object o = null;
        
        if (!ReferenceEquals(g, null) && g != null)
        {
            var sc = g.GetComponent<Type>();
            if (!ReferenceEquals(sc, null) && sc != null)
            {
                o = sc;
            }
        }
        return (Type) o;
    }

    /// <summary>
    /// シーン遷移が完了した際にフェードインを開始するように設定
    /// </summary>
    /// <param name="scene"></param>
    /// <param name="mode"></param>
    private void FadeInStart(Scene scene, LoadSceneMode mode)
    {
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
    /// <param name="alfa">画像の透明度</param>
    /// <param name="nextScene">遷移先のシーン名</param>
    public void FadeOutStart(int red, int green, int blue, int alfa, string nextScene)
    {
        SetRGBA(red, green, blue, alfa);
        SetColor();
        this.currentScene = nextScene;
        this.fadeOutCoroutine = FadeOut();
        StartCoroutine(fadeOutCoroutine);
    }

    /// <summary>
    /// 画像に色を代入する関数
    /// </summary>
    private void SetColor()
    {
        this.fadeImage.color = new Color(red, green, blue, alfa);
    }

    /// <summary>
    /// 色の値を設定するための関数
    /// </summary>
    /// <param name="r"></param>
    /// <param name="g"></param>
    /// <param name="b"></param>
    /// <param name="a"></param>
    private void SetRGBA(int r, int g, int b, int a)
    {
        this.red = r;
        this.green = g;
        this.blue = b;
        this.alfa = a;
    }
}
