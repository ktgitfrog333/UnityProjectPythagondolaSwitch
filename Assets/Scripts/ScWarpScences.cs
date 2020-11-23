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
    private float fadeSpeed;
    public Image fadeImage;
    private float red, green, blue, alfa;
    //シーン遷移のための型
    private string currentScene;

    IEnumerator fadeInCoroutine;
    IEnumerator fadeOutCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        this.fadeInCoroutine = FadeIn();
        this.fadeOutCoroutine = FadeOut();

        // TODO:20201123 ManageObjectがいくつも作られないように、個数を数える処理を作る
        DontDestroyOnLoad(this);

        this.fadeSpeed = 0.75f;

        SetRGBA(0, 0, 0, 1);
        StartCoroutine(fadeInCoroutine);
        SceneManager.sceneLoaded += FadeInStart;
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
    /// シーン遷移が完了した際にフェードインを開始するように設定
    /// </summary>
    /// <param name="scene"></param>
    /// <param name="mode"></param>
    private void FadeInStart(Scene scene, LoadSceneMode mode)
    {
        this.fadeInCoroutine = FadeIn();
        StartCoroutine(fadeInCoroutine);
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
