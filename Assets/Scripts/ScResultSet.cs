using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 計測時間結果オブジェクト用のスクリプト
/// </summary>
public class ScResultSet : MonoBehaviour
{
    /// <summary>計測時間</summary>
    public float resultTime;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "計測時間結果：" + resultTime.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
