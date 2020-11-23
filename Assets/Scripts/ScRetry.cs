using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScRetry : MonoBehaviour
{
    GameObject go;
    ScWarpScences wc;
    private bool keyPushFlag;

    // Start is called before the first frame update
    void Start()
    {
        this.go = GameObject.Find("ManageObject");
        this.wc = go.GetComponent<ScWarpScences>();

        this.keyPushFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return) && !keyPushFlag)
        {
            wc.FadeOutStart(0, 0, 0, 0, ScLevelDesignCommon.SCENES_STAGE);
            this.keyPushFlag = true;
        }
    }
}
