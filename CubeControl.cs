using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour {

    public float mouseSensivity = 100f;
    public GameObject player;

	void Update () {
		float lookLeftAndRight = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity;
		float lookUpAndDown = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensivity;
		player.transform.Rotate(lookLeftAndRight, lookUpAndDown, 0);
	}
}
