using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour {

    public Transform player;
    public Vector3 offset = new Vector3 (2, 3, 2);

	void Update () {
        transform.position = player.position + offset;
	}
}
