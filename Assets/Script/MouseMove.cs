using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public GameObject Left;
    public GameObject Right;

    public float LeftSpeed = 1f;
    public float RightSpeed = 1f;

    Rigidbody2D LeftRigid;
    Rigidbody2D RightRigid;
    void Start()
    {
       LeftRigid =  Left.GetComponent<Rigidbody2D>();
       RightRigid =  Right.GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LeftRigid.AddForce(Vector2.up * LeftSpeed);
        }
        if (Input.GetMouseButtonDown(1))

        {
            RightRigid.AddForce(Vector2.up * RightSpeed);
        }
    }
}

