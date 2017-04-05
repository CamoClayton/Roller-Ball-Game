using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;     //private so we can set it in the script. Subtracts position of camera from position of sphere/object.

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;     //each frame before showing what the camera can see, the camera is moved so its is alligned with the sphere.
	}
}
