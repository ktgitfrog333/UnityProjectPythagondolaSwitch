using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// タイマー表示画像のインデックスを暗黙的に指定
/// </summary>
public class CsNormalLevelDesignOfTimer
{
    /// <summary>タイマー表示位置（PosX）の初期値</summary>
    public static readonly float TIMER_POS_X_OFF_SET = 160f;
    /// <summary>タイマー表示位置（PosY）の初期値</summary>
    public static readonly float TIMER_POS_Y_OFF_SET = -96f;
    /// <summary>カンマの位置情報</summary>
    public static readonly int NUMBER_INDEX_COMMA = 10;
    /// <summary>文字列のカンマ</summary>
    public static readonly string STRING_COMMA = ".";
    /// <summary>プレハブタイマーのタグ名</summary>
    public static readonly string STRING_PREFAB_TAG_TIMER = "TimerClone";
    /// <summary>タイマーのゲームオブジェクト名</summary>
    public static readonly string GAMEOBJECTS_TIMER = "CvTimer";
}
