using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScStageSelect : MonoBehaviour
{
    /// <summary>
    /// シーン遷移有効フラグ
    /// </summary>
    public bool loadSceneActiveFlag = CsNormalLevelDesignOfCommon.FALSE;
    /// <summary>
    /// 遷移するシーン名
    /// </summary>
    public string scenesStage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// クリックボタンが押された時に実行されるイベント
    /// </summary>
    public void OnClick()
    {
        if (loadSceneActiveFlag)
        {
            SceneManager.LoadScene(scenesStage);
        }
    }

    /// <summary>
    /// シーン遷移を有効にする
    /// </summary>
    public void LoadSceneActiveFlagEnableSwitch()
    {
        this.loadSceneActiveFlag = CsNormalLevelDesignOfCommon.TRUE;
    }

    /// <summary>
    /// シーン遷移を有効にする
    /// </summary>
    public void LoadSceneActiveFlagDisableSwitch()
    {
        this.loadSceneActiveFlag = CsNormalLevelDesignOfCommon.FALSE;
    }
}
