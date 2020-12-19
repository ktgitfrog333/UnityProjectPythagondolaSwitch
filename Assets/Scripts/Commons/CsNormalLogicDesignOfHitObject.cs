using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// エフェクト制御
/// <para/>ゲームオブジェクト内のParticleSystemを取得及び制御を行う
/// </summary>
public class CsNormalLogicDesignOfHitObject
{
    /// <summary>
    /// 衝突速度を調べて倍率値を調整する
    /// </summary>
    /// <param name="collision">コリジョン情報</param>
    /// <returns>倍率値</returns>
    public float MeasureHitSpeedAndFixedLimit(Collision collision)
    {
        float f = 1.0f;
        if (1.0f < collision.impulse.magnitude)
        {
            if (10.0f < collision.impulse.magnitude)
            {
                f = 10.0f;
            }
            else
            {
                f = collision.impulse.magnitude;
            }
        }
        return f;
    }

    /// <summary>
    /// パーティクル演出を変化
    /// <para />StartSizeを倍にする
    /// </summary>
    /// <param name="gameObject">ゲームオブジェクト（子要素にParticleSystemがあること）</param>
    /// <param name="multiplication">倍率値</param>
    /// <returns>更新後の値</returns>
    public void DinamicParticleOfStartSize(GameObject gameObject, float multiplication)
    {
        GameObject g;
        if ((!ReferenceEquals(gameObject, null) && gameObject != null)
            && (!ReferenceEquals(gameObject.transform.GetChild(0).gameObject, null) && gameObject.transform.GetChild(0).gameObject != null))
        {
            g = gameObject.transform.GetChild(0).gameObject;
            if ((!ReferenceEquals(g.GetComponent<ParticleSystem>(), null) && g.GetComponent<ParticleSystem>() != null))
            {
                ParticleSystem ps = g.GetComponent<ParticleSystem>();
                ps.startSize = ps.startSize * multiplication;
            }
        }
    }
}
