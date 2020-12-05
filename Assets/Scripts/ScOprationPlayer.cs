using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤー制御オブジェクト用のスクリプト
/// </summary>
public class ScOprationPlayer : MonoBehaviour
{
    /// <summary>プレイヤーのゲームオブジェクトの物理情報</summary>
    private Rigidbody rbdy;
    /// <summary>プレイヤー制御関数</summary>
    private ScBallPlayer bplyr;
    /// <summary>移動速度</summary>
    private float speed;
    /// <summary>移動角度</summary>
    private Vector3 direction;

    // TODO:20201123 プレイヤー操作フラグを別オブジェクトで管理する？
    /// <summary>プレイヤーの操作禁止フラグ</summary>
    private bool oparationDisabledFlag;
    
    void Awake()
    {
        this.oparationDisabledFlag = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.rbdy = GetComponent<Rigidbody>();
        this.bplyr = new ScBallPlayer();
        this.speed = (float)bplyr.GetSpeedBySystem(ScLevelDesignOfBall.BALL_SPEED);
    }

    // Update is called once per frame
    void Update()
    {
        if (!oparationDisabledFlag)
        {
            this.direction = (Vector3)bplyr.GetDirectionByOparation();
            rbdy.AddForce(direction * speed);
        }
    }

    /// <summary>
    /// プレイヤー操作を無効
    /// </summary>
    public void OparationDisableSwitch()
    {
        this.oparationDisabledFlag = true;
    }

    /// <summary>
    /// プレイヤー操作を有効
    /// </summary>
    public void OparationEnableSwitch()
    {
        this.oparationDisabledFlag = false;
    }
}
