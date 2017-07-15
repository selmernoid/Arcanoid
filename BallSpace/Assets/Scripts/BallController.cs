using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public float maxSpeed = 35f;
    public float currentSpeed = 0;
    private Rigidbody2D body;
	// Use this for initialization
	void Start () {
	    body = GetComponent<Rigidbody2D>();
//        body.velocity = Vector2.down;
        body.AddForce(new Vector2(0, -35));
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    currentSpeed = body.velocity.magnitude;
        if (body.velocity.magnitude > maxSpeed) {
            body.velocity = body.velocity.normalized * maxSpeed;
        }
    }
}
