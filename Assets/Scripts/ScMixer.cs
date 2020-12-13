using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScMixer : MonoBehaviour
{
    /// <summary>共通ロジック</summary>
    CsNormalLogicDesignOfCommon logicCommon;

    // Start is called before the first frame update
    void Start()
    {
        this.logicCommon = new CsNormalLogicDesignOfCommon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        // このオブジェクトに対してプレイヤーが衝突した際に、このオブジェクトをプレイヤーオブジェクトの配下に追加する処理を起動する
        if (gameObject.transform.parent == null || gameObject.transform.parent.name != CsNormalLevelDesignOfBall.GAMEOBJECTS_SP_BALL)
        {
            if (col.transform.gameObject.name == CsNormalLevelDesignOfBall.GAMEOBJECTS_SP_BALL
                || (col.transform.parent.gameObject != null && col.transform.parent.gameObject.name == CsNormalLevelDesignOfBall.GAMEOBJECTS_SP_BALL))
            {
                Rigidbody r = GameObject.Find(CsNormalLevelDesignOfBall.GAMEOBJECTS_SP_BALL).GetComponent<Rigidbody>();
                FixedJoint f = gameObject.GetComponent<FixedJoint>();
                f.connectedBody = r;
                logicCommon.GetComponentScriptInGameObject<ScOperationPlayer>(CsNormalLevelDesignOfBall.GAMEOBJECTS_SP_BALL).OnCollisionEnterParent(this.gameObject);
            }
        }
    }
}
