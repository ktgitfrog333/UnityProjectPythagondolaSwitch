using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScSceneMove : MonoBehaviour
{
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
        SceneManager.LoadScene(scenesStage);
    }
}
