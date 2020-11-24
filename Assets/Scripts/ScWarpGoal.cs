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

    // Start is called before the first frame update
    void Start()
    {
        this.scWrpScn = (GameObject.Find(ScLevelDesignCommon.GAMEOBJECTS_MANAGE_OBJECT)).GetComponent<ScWarpScences>();
        this.scOprPlyer = (GameObject.Find(ScLevelDesignOfBall.GAMEOBJECTS_SP_BALL)).GetComponent<ScOprationPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        scOprPlyer.OparationDisableChange();
        scWrpScn.FadeOutStart(0, 0, 0, 0, ScLevelDesignCommon.SCENES_RESULT);
    }
}
