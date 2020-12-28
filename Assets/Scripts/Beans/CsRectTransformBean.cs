using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// RectTransformのBeanクラス
/// </summary>
public class CsRectTransformBean
{
    public float posX { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float posY { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float posZ { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float width { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
    public float height { get; set; } = CsNormalLevelDesignOfCommon.OFFSET_NUMBER;
}
