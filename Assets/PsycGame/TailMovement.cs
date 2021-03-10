using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour
{
    float tailSpeed = 0.5f;


     void Update()
    {
        transform.Rotate(0, 0, tailSpeed);    
    }
}
