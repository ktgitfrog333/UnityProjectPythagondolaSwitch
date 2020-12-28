using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゴールオブジェクト用のスクリプト
/// </summary>
public class ScWarpGoal : MonoBehaviour
{
    /// <summary>フェード処理管理スクリプト</summary>
    private ScWarpScences scWrpScn;
    /// <summary>プレイヤースクリプト</summary>
    private ScOperationPlayer scOprPlyer;
    /// <summary>タイマースクリプト</summary>
    private ScTimer scTimer;
    /// <summary>共通ロジック</summary>
    private CsNormalLogicDesignOfCommon lgc;

    private void Awake()
    {
        this.lgc = new CsNormalLogicDesignOfCommon();
    }

    // Start is called before the first frame update
    void Start()
    {
        this.scWrpScn = lgc.GetComponentScriptInGameObject<ScWarpScences>(CsNormalLevelDesignOfCommon.GAMEOBJECTS_MANAGE_OBJECT);
        this.scOprPlyer = lgc.GetComponentScriptInGameObject<ScOperationPlayer>(CsNormalLevelDesignOfBall.GAMEOBJECTS_SP_BALL);
        this.scTimer = lgc.GetComponentScriptInGameObject<ScTimer>(CsNormalLevelDesignOfTimer.GAMEOBJECTS_TIMER);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        scOprPlyer.OparationDisableSwitch();
        scTimer.TimerDisableSwitch();
        scWrpScn.FadeOutStart(CsNormalLevelDesignOfCommon.IMAGE_COLOR_LEVEL_MIN, CsNormalLevelDesignOfCommon.IMAGE_COLOR_LEVEL_MIN, CsNormalLevelDesignOfCommon.IMAGE_COLOR_LEVEL_MIN, CsNormalLevelDesignOfCommon.IMAGE_ALPHA_LEVEL_MAX, CsNormalLevelDesignOfCommon.SCENES_RESULT);
    }
}
