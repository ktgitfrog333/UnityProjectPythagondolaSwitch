using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 各ステージのBeanクラス
/// </summary>
public class CsStageSelectMotionBean
{
    /// <summary>ステージ名</summary>
    public string stageName { get; set; }
    /// <summary>次へもしくは前へボタンが押された情報</summary>
    public string actionEvent { get; set; }
    /// <summary>一つ目のステージ情報</summary>
    public CsStageSelectBean stage01 { get; set; }
    /// <summary>二つ目のステージ情報</summary>
    public CsStageSelectBean stage02 { get; set; }
    /// <summary>三つ目のステージ情報</summary>
    public CsStageSelectBean stage03 { get; set; }
}
