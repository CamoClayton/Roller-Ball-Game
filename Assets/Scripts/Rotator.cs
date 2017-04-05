using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

		
	// Update is called once per frame, we want the cylinder to spin every frame.
	void Update () {

        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); //uses simplest method rotate on axis
		
	}
}
