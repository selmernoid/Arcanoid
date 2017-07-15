using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollider : MonoBehaviour {


    public Camera cam;
    private float maxWidth;
    public float MoveSpeed = 0.6f;

	// Use this for initialization
	void Start () {
        if (cam == null) cam = Camera.main;

        var upperCorner = new Vector3(Screen.width,Screen.height, 0);
	    maxWidth = cam.ScreenToWorldPoint(upperCorner).x - GetComponent<Renderer>().bounds.extents.x;
	}
	
	// Update is called once per physics timestep
	void FixedUpdate () {

	    var horizontalMove = Input.GetAxis("Horizontal")*MoveSpeed;
	    var body = GetComponent<Rigidbody2D>();
	    var newPosition = Mathf.Clamp(body.position.x + horizontalMove, -maxWidth, maxWidth);
        body.MovePosition(new Vector2(newPosition, body.position.y));
//        transform.Translate(new Vector3(newPosition ,0));


    }
}
