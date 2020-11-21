using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーの下記情報をゲーム上のキー入力によって制御
/// ・角度（Direction）
/// ・速度（Speed）
/// </summary>
public abstract class ScPlayerRoll
{
    public abstract object GetDirectionByOparation();
    public abstract object GetSpeedByOparation();
}
