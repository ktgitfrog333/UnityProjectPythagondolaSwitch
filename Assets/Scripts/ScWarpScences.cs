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
    private bool isFadeOut;
    private bool isFadeIn;
    private float fadeSpeed;
    public Image fadeImage;
    private float red, green, blue, alfa;
    //シーン遷移のための型
    private string currentScene;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);

        this.isFadeOut = false;
        this.isFadeIn = true;
        this.fadeSpeed = 0.75f;

        SetRGBA(0, 0, 0, 1);
        SceneManager.sceneLoaded += FadeInStart;
    }
    // Update is called once per frame
    void Update()
    {
        if (isFadeIn)
        {
            this.alfa -= fadeSpeed * Time.deltaTime;
            SetColor();
            if (alfa <= 0) this.isFadeIn = false;
        }
        if (isFadeOut)
        {
            this.alfa += fadeSpeed * Time.deltaTime;
            SetColor();
            if (alfa >= 1)
            {
                this.isFadeOut = false;
                WarpScencesResultClear(currentScene);
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
        this.isFadeOut = true;
        this.currentScene = nextScene;
    }

    /// <summary>
    /// シーン遷移が完了した際にフェードインを開始するように設定
    /// </summary>
    /// <param name="scene"></param>
    /// <param name="mode"></param>
    private void FadeInStart(Scene scene, LoadSceneMode mode)
    {
        this.isFadeIn = true;
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
