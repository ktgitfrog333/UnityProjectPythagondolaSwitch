using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScBallPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
