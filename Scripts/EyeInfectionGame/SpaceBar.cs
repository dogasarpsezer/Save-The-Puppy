using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceBar : MonoBehaviour
{
    public Rigidbody2D rb2d;
    float speed = -1.2f;
    int loss;
    
    void Start()
    {
        StartCoroutine(timer());

        timer();
    }

    bool end;
    void Update()
    {
        if (end) return;
        if ( Input.GetKeyDown("space") && rb2d.transform.position.x <= 2.7f)
        {
            rb2d.transform.position = new Vector3(rb2d.transform.position.x + 0.5f,rb2d.transform.position.y,rb2d.transform.position.z );
        }
        if(rb2d.transform.position.x <= -3f || rb2d.transform.position.x >=3f )
        {
            rb2d.velocity = new Vector2(0, 0);

        }
        else
        {
            if( rb2d.transform.position.x <= 0 )
            {
                rb2d.velocity = new Vector2(rb2d.transform.position.x + speed, rb2d.transform.position.y);
            }
            else
            {
                rb2d.velocity = new Vector2(-(rb2d.transform.position.x - speed), rb2d.transform.position.y);
            }
            
        }
    }

    IEnumerator timer()
    {
        yield return new WaitForSeconds(7.5f);
        Destroy(rb2d);
        end = true;

        if (Comfort.comfort > 0)
        {
            MenuManager.downFixed = true;
            fadeObj.Delay();
            Invoke("Fade", 2);
        }
        else
        {
            fadeObj.Delay();
            SceneManager.LoadScene("End");
        }

        if ( gameObject.transform.position.x >= 1)
        {

        }
        else if( gameObject.transform.position.x < 1 && gameObject.transform.position.x >= -1)
        {
            loss = -10;
            Comfort.comfort += loss;
        }
        else
        {
            loss = -15;
            Comfort.comfort += loss;
        }
    }
    public Fade fadeObj;
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
}
