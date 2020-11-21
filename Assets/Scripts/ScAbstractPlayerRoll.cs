using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScPlayerRoll : MonoBehaviour
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
/// プレイヤーの下記情報をゲーム上のキー入力によって制御
/// ・角度（Direction）
/// ・速度（Speed）
/// </summary>
public abstract class PlayerRoll : LevelDesignOfBall
{
    public abstract object GetDirectionByOparation();
    public abstract object GetSpeedByOparation();
}
