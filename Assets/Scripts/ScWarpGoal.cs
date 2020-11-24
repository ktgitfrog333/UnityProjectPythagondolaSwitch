using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScWarpGoal : MonoBehaviour
{
    /// <summary>
    /// フェード処理管理オブジェクト
    /// </summary>
    private GameObject goManObj;
    /// <summary>
    /// フェード処理管理スクリプト
    /// </summary>
    private ScWarpScences scWrpScn;

    /// <summary>
    /// プレイヤーオブジェクト
    /// </summary>
    private GameObject goSpBall;
    /// <summary>
    /// プレイヤースクリプト
    /// </summary>
    private ScOprationPlayer scOprPlyer;

    // Start is called before the first frame update
    void Start()
    {
        this.goManObj = GameObject.Find("ManageObject");
        this.scWrpScn = goManObj.GetComponent<ScWarpScences>();

        this.goSpBall = GameObject.Find("SpBall");
        this.scOprPlyer = goSpBall.GetComponent<ScOprationPlayer>();
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
