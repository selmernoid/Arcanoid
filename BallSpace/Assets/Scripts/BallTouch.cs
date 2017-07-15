using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTouch : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D ball) {
        Debug.Log("enter");
//        Destroy(GetComponent<Rigidbody2D>().gameObject);
    }
    void OnTriggerExit2D(Collider2D ball) {
        Debug.Log("exit");
        Destroy(GetComponent<Rigidbody2D>().gameObject);
    }
    void OnTriggerStay2D(Collider2D ball) {
        Debug.Log("stay");
    }
}
