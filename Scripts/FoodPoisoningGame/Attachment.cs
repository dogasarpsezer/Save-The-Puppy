using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attachment : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Transform player;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if( collision.gameObject.CompareTag("Player"))
        {
            gameObject.transform.parent = collision.gameObject.transform;
            open.isTrigger = true;
            Destroy(rb2d);       
        }    
    }

    public BoxCollider2D open;

}
