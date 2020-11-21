using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScOprationPlayer : MonoBehaviour
{
    private Rigidbody rb;
    private BallPlayer bp;

    private float speed;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
        this.bp = new BallPlayer();
        this.speed = (float)bp.GetSpeedBySystem();
    }

    // Update is called once per frame
    void Update()
    {
        this.direction = (Vector3)bp.GetDirectionByOparation();
        rb.AddForce(direction * speed);
    }
}

/// <summary>
/// 全体のパラメータを管理
/// </summary>
public class LevelDesignCommon
{
    
}

/// <summary>
/// ボール制御のパラメータを管理
/// </summary>
public class LevelDesignOfBall : LevelDesignCommon
{
    public const float BallSpeed = 20f;
}

/// <summary>
/// プレイヤーの下記情報をゲーム上のキー入力によって制御
/// ・角度（Direction）
/// ・速度（Speed）
/// </summary>
public abstract class PlayerRoll : LevelDesignOfBall
{
    public abstract object GetDirectionByOparation();
    public abstract object GetSpeedByOparation();
}

/// <summary>
/// プレイヤーの下記情報をシステム上の入力によって制御
/// ・角度（Direction）
/// ・速度（Speed）
/// </summary>
public interface PlayerRollBySystem
{
    object GetDirectionBySystem();
    object GetSpeedBySystem();
}

/// <summary>
/// プレイヤーの動きを制御
/// </summary>
public class BallPlayer : PlayerRoll, PlayerRollBySystem
{
    /// <summary>
    /// キー操作（左右、上下）によって、
    /// 角度（Direction）の情報を制御
    /// </summary>
    /// <returns>角度（Direction）</returns>
    public override object GetDirectionByOparation()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");
        return new Vector3(moveHorizontal, 0, moveVertical);
    }

    public override object GetSpeedByOparation()
    {
        throw new System.NotImplementedException();
    }

    public object GetDirectionBySystem()
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// システムによって、
    /// 速度（Speed）を制御
    /// </summary>
    /// <returns>速度（Speed）</returns>
    public object GetSpeedBySystem()
    {
        return BallSpeed;
    }
}
