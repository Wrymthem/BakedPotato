using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    private float lastMove;
    public float moveDelay = 0.1f;
    public float interpolationSpeed = 10.0F;
    Vector3 nextPosition;

    // Use this for initialization
    void Start () {
        nextPosition = transform.position;
        rb.freezeRotation = true;
	}

	// Update is called once per frame
	void Update () {
        wasdMovement();
        transform.position = Vector3.Lerp(transform.position, nextPosition, interpolationSpeed * Time.deltaTime);
    }

    void wasdMovement() {
        if (Time.time - lastMove > moveDelay) {
            if (Input.GetKey("w")) {
                nextPosition += new Vector3(-1, 0, -1);
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            if (Input.GetKey("a")) {
                nextPosition += new Vector3(1, 0, -1);
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            if (Input.GetKey("s")) {
                nextPosition += new Vector3(1, 0, 1);
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            if (Input.GetKey("d")) {
                nextPosition += new Vector3(-1, 0, 1);
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            lastMove = Time.time;
        }
    }
}
