using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// RectMask2DのBeanクラス
/// </summary>
public class CsRectMask2DBean : CsRectTransformBean
{
    public float paddingLeft { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float paddingRight { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float paddingTop { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float paddingBottom { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float softnessX { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float softnessY { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
}
