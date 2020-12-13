using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤー制御オブジェクト用のスクリプト
/// </summary>
public class ScOperationPlayer : MonoBehaviour
{
    /// <summary>プレイヤーのゲームオブジェクトの物理情報</summary>
    private Rigidbody rbdy;
    /// <summary>プレイヤー制御関数</summary>
    private CsNormalLogicDesignOfBallPlayer bplyr;
    /// <summary>移動速度</summary>
    private float speed;
    /// <summary>移動角度</summary>
    private Vector3 direction;

    // TODO:20201123 プレイヤー操作フラグを別オブジェクトで管理する？
    /// <summary>プレイヤーの操作禁止フラグ</summary>
    private bool oparationDisabledFlag;

    /// <summary>プレイヤーが衝突したオブジェクトのリスト</summary>
    private List<GameObject> collisionedObjects;
    
    void Awake()
    {
        this.oparationDisabledFlag = true;
        this.collisionedObjects = new List<GameObject>();
    }

    // Start is called before the first frame update
    void Start()
    {
        this.rbdy = GetComponent<Rigidbody>();
        this.bplyr = new CsNormalLogicDesignOfBallPlayer();
        this.speed = (float)bplyr.GetSpeedBySystem(CsNormalLevelDesignOfBall.BALL_SPEED);
    }

    // Update is called once per frame
    void Update()
    {
        if (!oparationDisabledFlag)
        {
            this.direction = (Vector3)bplyr.GetDirectionByOparation();
            rbdy.AddForce(direction * speed);

            foreach (Transform transform in gameObject.transform)
            {
                GameObject g = transform.gameObject;
                g.GetComponent<Rigidbody>().AddForce(direction * speed);
            }

        }
    }

    /// <summary>
    /// オブジェクトが衝突した際に、
    /// <para/>親オブジェクト　＞　被オブジェクト（衝突されたオブジェクト）
    /// <para/>となるように被オブジェクトを親オブジェクトの配下に入れる
    /// <para/>被オブジェクトには下記コンポーネントを追加すること
    /// <para/>・Rigitbody
    /// <para/>・Fixed Joint
    /// </summary>
    /// <param name="gameObject">被オブジェクト</param>
    public void OnCollisionEnterParent(GameObject gameObject)
    {
        if (this.gameObject.transform.childCount < 1)
        {
            gameObject.transform.parent = this.gameObject.transform;
        }
        else
        {
            foreach (Transform transform in this.gameObject.transform)
            {
                if (transform.gameObject != gameObject)
                {
                    gameObject.transform.parent = this.gameObject.transform;
                }
            }
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
