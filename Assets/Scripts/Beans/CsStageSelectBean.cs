using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ステージのBeanクラス
/// </summary>
public class CsStageSelectBean : CsRectTransformBean
{
    /// <summary>シーン遷移有効フラグ</summary>
    public bool loadSceneActiveFlag { get; set; } = CsNormalLevelDesignOfCommon.FALSE;
}
