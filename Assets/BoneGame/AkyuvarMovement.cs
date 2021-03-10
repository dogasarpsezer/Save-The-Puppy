using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkyuvarMovement : MonoBehaviour
{

    public Rigidbody2D rb2d;


    
    void OnCollisionEnter2D(Collision2D collision)
    {
      
    
            if (collision.gameObject.layer == 10 || collision.gameObject.CompareTag("Body"))
            {
                Destroy(gameObject);
            }
        
  

    }
    void FixedUpdate()
    {
        rb2d.velocity = (new Vector2(rb2d.transform.position.x,(rb2d.transform.position.y + 5f)));  
    }
}
