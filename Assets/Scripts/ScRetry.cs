using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScRetry : MonoBehaviour
{
    ScWarpScences ws;

    // Start is called before the first frame update
    void Start()
    {
        this.ws = new ScWarpScences();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            ws.WarpScencesResultClear(ScLevelDesignCommon.SCENES_STAGE);
        }
    }
}
