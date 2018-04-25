using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {
    public GameObject CollidingTrigger;
    public GameObject Disc;
    bool collision = true;


    void Update () {
        if (collision == true) {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Rotate(Vector3.up);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Rotate(Vector3.down);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.left);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.right);
            }

        }
        else
        {
            Debug.Log("You've Already Thrown");
        }
	}

}
