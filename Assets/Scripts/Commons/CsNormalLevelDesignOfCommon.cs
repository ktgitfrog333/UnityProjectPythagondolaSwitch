using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 全体のパラメータを管理
/// </summary>
public static class CsNormalLevelDesignOfCommon
{
    /// <summary>
    /// ゲーム画面のシーン名
    /// </summary>
    public static readonly string SCENES_STAGE = "ScStage";
    /// <summary>
    /// ゲーム結果画面のシーン名
    /// </summary>
    public static readonly string SCENES_RESULT = "ScResult";
    /// <summary>
    /// ゲームオーバー画面のシーン名
    /// </summary>
    public static readonly string SCENES_GAMEOVER = "ScGameOver";
    /// <summary>
    /// フェード処理管理のゲームオブジェクト名
    /// </summary>
    public static readonly string GAMEOBJECTS_MANAGE_OBJECT = "ManageObject";
    ///// <summary>
    ///// タイマーのゲームオブジェクト名
    ///// </summary>
    //public static readonly string GAMEOBJECTS_TIMER = "CvTimer";
    /// <summary>
    /// 時間計測結果のゲームオブジェクト名
    /// </summary>
    public static readonly string GAMEOBJECTS_RESULT_SETTER = "TxResultSetter";
    /// <summary>
    /// 最小カラーレベル
    /// </summary>
    public static readonly float IMAGE_COLOR_LEVEL_MIN = 0f;
    /// <summary>
    /// 最大の透明度
    /// </summary>
    public static readonly float IMAGE_ALPHA_LEVEL_MIN = 1f;
    /// <summary>
    /// 最小の透明度
    /// </summary>
    public static readonly float IMAGE_ALPHA_LEVEL_MAX = 0f;
    /// <summary>
    /// 最小の自然数 -1.0f
    /// </summary>
    public static readonly float NATURAL_NUMBER = -1.0f;
    /// <summary>
    /// 数字の初期値 0f
    /// </summary>
    public static readonly float OFFSET_NUMBER = 0f;
}
