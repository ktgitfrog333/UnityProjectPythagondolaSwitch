using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 各ステージのサムネイル情報を管理
/// </summary>
public class CsNormalLevelDesignOfStageSelect
{
    /// <summary>
    /// ステージ１のサムネイルオブジェクト
    /// </summary>
    public static readonly string THUMBNAIL_SCENES_STAGE_01 = "GoStage01";
    /// <summary>
    /// ステージ２のサムネイルオブジェクト
    /// </summary>
    public static readonly string THUMBNAIL_SCENES_STAGE_02 = "GoStage02";
    /// <summary>
    /// ステージ３のサムネイルオブジェクト
    /// </summary>
    public static readonly string THUMBNAIL_SCENES_STAGE_03 = "GoStage03";
    /// <summary>
    /// 次へボタンのオブジェクト
    /// </summary>
    public static readonly string PUSHED_BUTTON_NAME_NEXT = "Next";
    /// <summary>
    /// 前へボタンのオブジェクト
    /// </summary>
    public static readonly string PUSHED_BUTTON_NAME_BACK = "Back";
    /// <summary>
    /// PosX
    /// </summary>
    public static readonly string PosX = "PosX";
    /// <summary>
    /// PosY
    /// </summary>
    public static readonly string PosY = "PosY";
    /// <summary>
    /// Scale_X
    /// </summary>
    public static readonly string Scale_X = "Scale_X";
    /// <summary>
    /// Scale_Y
    /// </summary>
    public static readonly string Scale_Y = "Scale_Y";
    /// <summary>
    /// サムネイル左側表示
    /// </summary>
    public static readonly Dictionary<string, float> THUMBNAIL_POSITION_LEFT = new Dictionary<string, float>()
        {
            {PosX, -350f},
            {PosY, -125f},
            {Scale_X, 0.5f},
            {Scale_Y, 0.5f},
        };
    /// <summary>
    /// サムネイル中央表示
    /// </summary>
    public static readonly Dictionary<string, float> THUMBNAIL_POSITION_CENTER = new Dictionary<string, float>()
        {
            {PosY, -125f}
        };
    /// <summary>
    /// サムネイル右側表示
    /// </summary>
    public static readonly Dictionary<string, float> THUMBNAIL_POSITION_RIGHT = new Dictionary<string, float>()
        {
            {PosX, 350f},
            {PosY, -125f},
            {Scale_X, 0.5f},
            {Scale_Y, 0.5f}
        };
}
