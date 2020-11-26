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

    // Start is called before the first frame update
    void Start()
    {
        this.scWrpScn = (GameObject.Find(ScLevelDesignCommon.GAMEOBJECTS_MANAGE_OBJECT)).GetComponent<ScWarpScences>();
        this.scOprPlyer = (GameObject.Find(ScLevelDesignOfBall.GAMEOBJECTS_SP_BALL)).GetComponent<ScOprationPlayer>();
        this.scTimer = (GameObject.Find(ScLevelDesignCommon.GAMEOBJECTS_TIMER).GetComponent<ScTimer>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        scOprPlyer.OparationDisableChange();
        scTimer.TimerDisableSwitch();
        scWrpScn.FadeOutStart(0, 0, 0, 0, ScLevelDesignCommon.SCENES_RESULT);
    }
}
