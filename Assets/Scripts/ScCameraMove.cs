using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScCameraMove : MonoBehaviour
{
    /// <summary>カメラオブジェクト</summary>
    private GameObject camera;
    /// <summary>相対距離情報</summary>
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        this.camera = GameObject.Find(CsNormalLevelDesignOfBall.GAMEOBJECTS_SP_BALL);
        this.offset = transform.position - camera.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camera.transform.position + offset;
    }
}
