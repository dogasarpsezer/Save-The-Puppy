using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGreenEnemy : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.CompareTag("Player"))
        {
            Comfort.comfort -= 10;
        }
    }
}
