using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScWarpGoal : MonoBehaviour
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
        
    }
    void OnCollisionEnter(Collision col)
    {
        ws.WarpScencesResultClear(ScLevelDesignCommon.SCENES_RESULT);
    }
}
