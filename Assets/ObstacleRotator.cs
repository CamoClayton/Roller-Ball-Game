using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotator : MonoBehaviour {

    // Update is called once per frame, we want the cylinder to spin every frame.
    void Update()
    {

        transform.Rotate(new Vector3(0, -90, 0) * Time.deltaTime); //uses simplest method rotate on axis. Only want it to rotate on the y axis anti clockwise

    }
}