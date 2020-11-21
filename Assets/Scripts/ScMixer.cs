using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScMixer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        // TODO_20201121:オブジェクトをボールにくっつける制御
        Debug.Log("OnCollisionEnter");
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.isKinematic = true;
    }
}
