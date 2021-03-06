using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float moveSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;


    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        if( Input.GetButtonDown("Jump"))
        {
            jump = true;

        }
    }
    void FixedUpdate()
    {

        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
