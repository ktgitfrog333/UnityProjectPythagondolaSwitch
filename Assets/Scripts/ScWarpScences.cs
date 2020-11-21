using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// シーン間の移動を制御
/// </summary>
public class ScWarpScences
{
    /// <summary>
    /// 渡されたシーン名に紐づくシーンに移動
    /// </summary>
    /// <param name="sceneName"></param>
    public void WarpScencesResultClear(string sceneName)
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
}
