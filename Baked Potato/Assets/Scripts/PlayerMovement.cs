using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public Rigidbody rb;

	// Update is called once per frame
	void Update () {
        if (Input.GetKey("s")) {
            rb.velocity = new Vector3(10, 0, 10);
        }
        if (Input.GetKey("w")) {
            rb.velocity = new Vector3(-10, 0, -10);
        }
        if (Input.GetKey("a")) {
            rb.velocity = new Vector3(10, 0, -10);
        }
        if (Input.GetKey("d")) {
            rb.velocity = new Vector3(-10, 0, 10);
        }
        if (Input.GetKeyUp("s") || Input.GetKeyUp("w") || Input.GetKeyUp("a") || Input.GetKeyUp("d")) {
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
