using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ボタンイベント専用クラス
/// </summary>
public class ScScroll : MonoBehaviour
{
    /// <summary>
    /// 次への場合はNext、前への場合はBackを渡す
    /// </summary>
    [SerializeField]
    private string mode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// ボタンイベント専用<para/>
    /// クリックの挙動
    /// </summary>
    public void OnClick()
    {
        transform.parent.gameObject.GetComponent<ScStageSelectMotion>().PushedScrollButton(mode);
    }
}
