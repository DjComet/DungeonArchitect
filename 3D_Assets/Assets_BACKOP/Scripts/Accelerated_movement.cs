using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerated_movement : MonoBehaviour {

    public float acceleration = 2;
    public float maxSpeed = 50;
    private float Speed = 0;
    private float time = Time.deltaTime;
	
	// Update is called once per frame
	void Update () {

        if ((Input.GetKey(KeyCode.A)) && (Speed < maxSpeed))
        {

            Speed -= acceleration * time;
        }
        else if ((Input.GetKey(KeyCode.D)) && (Speed > -maxSpeed))
        {
            Speed += acceleration * time;

        }
        



    }
}
