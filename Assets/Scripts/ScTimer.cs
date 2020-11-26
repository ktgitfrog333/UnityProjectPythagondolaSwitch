using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// タイマーを計測する
/// </summary>
public class ScTimer : MonoBehaviour
{
    /// <summary>計測時間</summary>
    public float countTime;
    /// <summary>タイマーコルーチン</summary>
    private IEnumerator timerCoroutine;
    
    // Start is called before the first frame update
    void Start()
    {
        this.countTime = 0f;
        GetComponent<Text>().text = countTime.ToString("F2");
        this.timerCoroutine = CountTimer();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// 時間を計測する
    /// </summary>
    /// <returns>時間管理コルーチン</returns>
    private IEnumerator CountTimer()
    {
        while(true)
        {
            this.countTime += Time.deltaTime;
            GetComponent<Text>().text = countTime.ToString("F2");
            yield return null;
        }
    }

    /// <summary>
    /// タイマーを有効にする
    /// </summary>
    public void TimerEnableSwitch()
    {
        StartCoroutine(timerCoroutine);
    }

    /// <summary>
    /// タイマーを無効にする
    /// </summary>
    public void TimerDisableSwitch()
    {
        StopCoroutine(timerCoroutine);
    }
}
