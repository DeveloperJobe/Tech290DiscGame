using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiscPhysics : MonoBehaviour
{
//setting up variables
    //Disc is the object we're throwing
    public GameObject Disc;
    //I had to assign an empty gameObject as the rotater for our disc, without this, the disc rotates really unpredictably
    public GameObject Rotater;
    Rigidbody rb;
    //this may be old code, can delete
    private bool OverDisc;
    //I also dont think we need this one, but it could possibly be useful
    private static bool GravityAsleep;
    //variables for velocity calculation
    Vector3 StartPosition, EndPosition, direction;
    float GrabTimeStart, GrabTimeFinish, TimeInterval;
    //this is how we can aim the disc
    float RotateUp, RotateDown, RotateLeft, RotateRight;
    bool ThrowAllowed = true;
    //haven't found use for this quaternion yet
    Quaternion RotatingQuat;

//getting the rigidbody component
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
    //what I'm doing here is making it so when we hold down the left mouse button, it grabs the disc, and locking the movement to forward
        if (Input.GetMouseButtonDown(0))
        {
            GrabTimeStart = Time.time;
            StartPosition = new Vector3(Input.mousePosition.x, 0, 0);
            



        }
//now if we let go, the disc continues moving at the same velocity it was when we released the button.
        if (Input.GetMouseButtonUp(0))
        {
            GrabTimeFinish = Time.time;
            TimeInterval = GrabTimeFinish - GrabTimeStart;
            EndPosition = new Vector3(Input.mousePosition.x, 0, 0);
            direction = StartPosition - EndPosition;
            rb.isKinematic = false;
            rb.useGravity = true;
            rb.AddRelativeForce(EndPosition, ForceMode.Acceleration);
            rb.AddRelativeTorque(new Vector3(Input.mousePosition.z, 0), ForceMode.Acceleration);
            //haven't hooked this one up yet
            ThrowAllowed = false;
        }
    }
}
