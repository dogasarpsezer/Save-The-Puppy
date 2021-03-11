using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Comfort : MonoBehaviour
{
    public static int comfort = 100;
    public Text comfortText;
    public GameObject roof;
    public bool disregard;
    void Start()
    {
        if (disregard == false)
        {
            comfortText.text = "Comfort = " + comfort;
        }
    }

    
    void Update()
    {
        if (disregard == false && comfort>0)
        {
            comfortText.text = "Comfort = " + comfort;
        }
        else if (comfort <= 0)
        {
            comfortText.text = "Dog is too uncomfortable";
        }
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemies"))
        {
            comfort -= 2;
        }else
       if( collision.gameObject.layer == 8)
        {
            comfort -= 2;
        }else
       if( collision.gameObject.layer == 10 )
        {
            comfort -= 2;
        }else
       if( collision.gameObject.CompareTag("Akyuvar"))
        {
            comfort -= 2; 
        }
    }
    private void FixedUpdate()
    {
        if (comfort <= 0)
        {
            MenuManager.atStateOfRecover = 0;
            MenuManager.downFixed = false;
            MenuManager.upFixed = false;
            MenuManager.isBad = true;
            comfort = 100;
            fadeObj.Delay();
            Invoke("GoMenu", 1);
        }
    }

    public Fade fadeObj;
    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
