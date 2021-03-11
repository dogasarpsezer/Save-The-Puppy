using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float xMin;
    public float xMax;
    public float speed = 35;
    Vector2 limit;
    public Text comfortTxt;
    int loss = 0;
 
     void Start()
    {
        limit = rb2d.transform.position;
    }
    public Fade fadeObj;
    bool end;
    void Update()
    {
        if (!end){
            if (rb2d.transform.position.x >= limit.x + xMax)
            {
                speed = -35f;
            }
            if (rb2d.transform.position.x <= limit.x + xMin)
            {
                speed = 35f;
            }
        }
        

        if( Input.GetKey("space"))
        {
            Destroy(rb2d);
            if (end) return;
            end = true;
            if( gameObject.transform.position.x <= 1 && gameObject.transform.position.x >= -1)
            {
                if (Comfort.comfort > 0) { }
                    comfortTxt.text = "You win with " + loss + " loss comfort";
            }
            else if((gameObject.transform.position.x < -1 && gameObject.transform.position.x >= -3) || (gameObject.transform.position.x > 1 && gameObject.transform.position.x <= 3))
            {
                loss = 10;
                Comfort.comfort -= loss;

                if (Comfort.comfort > 0)
                    comfortTxt.text = "You win with " + loss + " loss comfort";
            }
            else
            {
                loss = 15;

                Comfort.comfort -= loss;

                if (Comfort.comfort > 0)
                    comfortTxt.text = "You win with " + loss + " loss comfort";
            }


            if (Comfort.comfort > 0)
            {
                MenuManager.upFixed = true;
                fadeObj.Delay();
                Invoke("Fade", 2);
            }
        }
    }
    public void Fade()
    {
        if (MenuManager.upFixed && MenuManager.downFixed)
        {
            MenuManager.atStateOfRecover++;
            SceneManager.LoadScene("Demo");
        }
        else
        {
            SceneManager.LoadScene("EyeMain");
        }
            
    }

    void FixedUpdate()
    {
        if (end) return;
        rb2d.velocity = new Vector2(rb2d.transform.position.x + speed, rb2d.transform.position.y);
    }
}
