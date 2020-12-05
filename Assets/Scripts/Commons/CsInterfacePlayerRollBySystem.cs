using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーの下記情報をシステム上の入力によって制御
/// ・角度（Direction）
/// ・速度（Speed）
/// </summary>
public interface CsInterfacePlayerRollBySystem
{
    object GetDirectionBySystem(float value);
    object GetSpeedBySystem(float value);
}
