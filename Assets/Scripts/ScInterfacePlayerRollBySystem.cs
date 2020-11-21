using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScInterfacePlayerRollBySystem : MonoBehaviour
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
/// プレイヤーの下記情報をシステム上の入力によって制御
/// ・角度（Direction）
/// ・速度（Speed）
/// </summary>
public interface PlayerRollBySystem
{
    object GetDirectionBySystem();
    object GetSpeedBySystem();
}
