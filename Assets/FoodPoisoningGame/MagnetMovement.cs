using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    float horizontal;
    float vertical;

     void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rb2d.AddForce(new Vector2(horizontal * 5, vertical * 5));
    }
}
