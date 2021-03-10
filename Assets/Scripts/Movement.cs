using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    Vector2 Speed;
    public float multiplier;
    void FixedUpdate()
    {
        Speed = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rigidBody2D.velocity = Speed * multiplier;
    }
}
