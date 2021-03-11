using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Vector2[] target;
    public Rigidbody2D rb2d;
    public static float speed;

    void Start()
    {
        rb2d.velocity = new Vector2(rb2d.transform.position.x,-(rb2d.transform.position.y + speed));
    }

    
    void Update()
    {
        if(Input.GetKeyDown("q")){
            if ((rb2d.transform.position.y <=  -0.8f && rb2d.transform.position.y >= -2.1f) && (rb2d.transform.position.x == -3.2f))
            {
               
                Destroy(gameObject);
            }
            else if((rb2d.transform.position.y > -0.8f && rb2d.transform.position.y < -2.1f))
            {
                Comfort.comfort -= 2;
                
            }
        }
        else if (Input.GetKeyDown("w"))
        {
            if ((rb2d.transform.position.y <= -0.8f && rb2d.transform.position.y >= -2.1f) && (rb2d.transform.position.x == -1.2f))
            {

                Destroy(gameObject);
            }
            else if ((rb2d.transform.position.y > -0.8f && rb2d.transform.position.y < -2.1f))
            {
                Comfort.comfort -= 2;

            }
        }
        else if (Input.GetKeyDown("e"))
        {
            if ((rb2d.transform.position.y <= -0.8f && rb2d.transform.position.y >= -2.1f) && (rb2d.transform.position.x == 0.8f))
            {

                Destroy(gameObject);
            }
            else if ((rb2d.transform.position.y > -0.8f && rb2d.transform.position.y < -2.1f))
            {
                Comfort.comfort -= 2;

            }
        }
        else if (Input.GetKeyDown("r"))
        {
            if ((rb2d.transform.position.y <= -0.8f && rb2d.transform.position.y >= -2.1f) && (rb2d.transform.position.x == 2.7f))
            {

                Destroy(gameObject);
            }
            else if ((rb2d.transform.position.y > -0.8f && rb2d.transform.position.y < -2.1f))
            {
                Comfort.comfort -= 2;

            }
        }

        if( gameObject.transform.position.y < -5)
        {
            Comfort.comfort -= 2;
            Destroy(gameObject);
        }

    }
}
