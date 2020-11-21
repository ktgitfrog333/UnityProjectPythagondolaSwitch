using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScOprationPlayer : MonoBehaviour
{
    private Rigidbody rb;
    private BallPlayer bp;

    private float speed;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = GetComponent<Rigidbody>();
        this.bp = new BallPlayer();
        this.speed = (float)bp.GetSpeedBySystem();
    }

    // Update is called once per frame
    void Update()
    {
        this.direction = (Vector3)bp.GetDirectionByOparation();
        rb.AddForce(direction * speed);
    }
}
