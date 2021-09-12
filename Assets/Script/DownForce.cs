using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownForce : MonoBehaviour
{
    public GameObject Left;
    public GameObject Right;
    Rigidbody2D Leftrb;
    Rigidbody2D Rightrb;
    public float Speed;
    void Start()
    {
        Leftrb = Left.GetComponent<Rigidbody2D>();
        Rightrb = Right.GetComponent<Rigidbody2D>();
        transform.position = new Vector2(0f, -1f);
    }

    // Update is called once per frame
    void Update()
    {
        Leftrb.AddForce(transform.position * Speed);
        Rightrb.AddForce(transform.position * Speed);

        
    }
}
