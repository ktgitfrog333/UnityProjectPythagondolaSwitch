using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// リトライ制御オブジェクト用のスクリプト
/// </summary>
public class ScRetry : MonoBehaviour
{
    /// <summary>フェード処理管理スクリプト</summary>
    private ScWarpScences scWrpScn;
    /// <summary>リトライ実行入力キーの制御フラグ</summary>
    private bool keyPushFlag;
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
        this.keyPushFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return) && !keyPushFlag)
        {
            scWrpScn.FadeOutStart(0, 0, 0, 0, ScLevelDesignCommon.SCENES_STAGE);
            this.keyPushFlag = true;
        }
    }
}
