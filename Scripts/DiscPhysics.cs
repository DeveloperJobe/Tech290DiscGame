using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DiscPhysics : MonoBehaviour
{

    public GameObject Disc;
    public GameObject Rotater;
    Rigidbody rb;
    private bool OverDisc;
    private static bool GravityAsleep;
    Vector3 StartPosition, EndPosition, direction;
    float GrabTimeStart, GrabTimeFinish, TimeInterval;
    float RotateUp, RotateDown, RotateLeft, RotateRight;
    bool ThrowAllowed = true;
    Quaternion RotatingQuat;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GrabTimeStart = Time.time;
            StartPosition = new Vector3(Input.mousePosition.x, 0, 0);



        }

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
            ThrowAllowed = false;
        }
    }
}