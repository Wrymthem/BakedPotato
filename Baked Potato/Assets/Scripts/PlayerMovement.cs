using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    Rigidbody rb;

	// Update is called once per frame
	void Update () {
        if (Input.GetKey("s")) {
            rb.velocity = new Vector3(10, 0, 10);
        }
	}
}
