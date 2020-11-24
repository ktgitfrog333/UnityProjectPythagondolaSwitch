using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScOprationPlayer : MonoBehaviour
{
    private Rigidbody rb;
    private ScBallPlayer bp;

    private float speed;
    private Vector3 direction;

    // TODO:20201123 プレイヤー操作フラグを別オブジェクトで管理する？
    /// <summary>
    /// プレイヤーの操作禁止フラグ
    /// </summary>
    private bool oparationDisabledFlag;
    
    void Awake()
    {
        this.oparationDisabledFlag = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
        this.bp = new ScBallPlayer();
        this.speed = (float)bp.GetSpeedBySystem(ScLevelDesignOfBall.BALL_SPEED);
    }

    // Update is called once per frame
    void Update()
    {
        if (!oparationDisabledFlag)
        {
            this.direction = (Vector3)bp.GetDirectionByOparation();
            rb.AddForce(direction * speed);
        }
    }

    /// <summary>
    /// プレイヤー操作を無効
    /// </summary>
    public void OparationDisableChange()
    {
        this.oparationDisabledFlag = true;
    }

    /// <summary>
    /// プレイヤー操作を有効
    /// </summary>
    public void OparationEnableChange()
    {
        this.oparationDisabledFlag = false;
    }
}
