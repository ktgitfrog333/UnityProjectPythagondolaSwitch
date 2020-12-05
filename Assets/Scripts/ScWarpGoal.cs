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
    private ScOprationPlayer scOprPlyer;
    /// <summary>タイマースクリプト</summary>
    private ScTimer scTimer;
    /// <summary>共通ロジック</summary>
    private ScLogicDesignCommon lgc;

    private void Awake()
    {
        this.lgc = new ScLogicDesignCommon();
    }

    // Start is called before the first frame update
    void Start()
    {
        this.scWrpScn = lgc.GetComponentScriptInGameObject<ScWarpScences>(ScLevelDesignCommon.GAMEOBJECTS_MANAGE_OBJECT);
        this.scOprPlyer = lgc.GetComponentScriptInGameObject<ScOprationPlayer>(ScLevelDesignOfBall.GAMEOBJECTS_SP_BALL);
        this.scTimer = lgc.GetComponentScriptInGameObject<ScTimer>(ScLevelDesignCommon.GAMEOBJECTS_TIMER);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        scOprPlyer.OparationDisableSwitch();
        scTimer.TimerDisableSwitch();
        scWrpScn.FadeOutStart(ScLevelDesignCommon.IMAGE_COLOR_LEVEL_MIN, ScLevelDesignCommon.IMAGE_COLOR_LEVEL_MIN, ScLevelDesignCommon.IMAGE_COLOR_LEVEL_MIN, ScLevelDesignCommon.IMAGE_ALPHA_LEVEL_MAX, ScLevelDesignCommon.SCENES_RESULT);
    }
}
