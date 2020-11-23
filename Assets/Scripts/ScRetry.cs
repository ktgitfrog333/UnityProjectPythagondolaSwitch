using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScRetry : MonoBehaviour
{
    GameObject go;
    ScWarpScences wc;

    // Start is called before the first frame update
    void Start()
    {
        this.go = GameObject.Find("ManageObject");
        this.wc = go.GetComponent<ScWarpScences>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            wc.FadeOutStart(0, 0, 0, 0, ScLevelDesignCommon.SCENES_STAGE);
        }
    }
}
