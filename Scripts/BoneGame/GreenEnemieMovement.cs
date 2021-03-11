using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenEnemieMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float xMax;
    public float xMin;
    public float speed = 5f;
    Vector2 limit;

    void Start()
    {
        limit = rb2d.transform.position;

    
        

    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.CompareTag("Player"))
        {
            speed = -speed;
        }
    }
    void Update()
    {
        if( rb2d.transform.position.x >= limit.x + xMax )
        {
            speed = -5f;
        }
        else if(rb2d.transform.position.x <= limit.x - xMin )
        {
            speed = 5f;
        }
    }
    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
    }
}
