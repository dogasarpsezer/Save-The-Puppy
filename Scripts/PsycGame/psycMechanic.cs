using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class psycMechanic : MonoBehaviour
{
    public Vector2[] target;
    public GameObject ball;
    int rand;
    public static float speed = 1f;
    void Start()
    {
        StartCoroutine(spawnTime());
        spawnTime();
    }

    public Fade fadeObj;
    void Fade()
    {
        SceneManager.LoadScene("End");
    }

    IEnumerator spawnTime()
    {
        yield return new WaitForSeconds(1f);
        while (true)
        {
            rand = Random.Range(0, 4);
            Debug.Log(rand);
            if( rand == 0)
            {
                Instantiate(ball, new Vector3(-3.2f, 6f,-9f), Quaternion.identity);
                yield return new WaitForSeconds(speed);
                
            }
            else if( rand == 1)
            {
                Instantiate(ball, new Vector3(-1.2f, 6.15f,-9f), Quaternion.identity);
                yield return new WaitForSeconds(speed);
            }
            else if( rand == 2)
            {
                Instantiate(ball, new Vector3(0.8f, 6.15f,-9f), Quaternion.identity);
                yield return new WaitForSeconds(speed);
            }
            else if( rand == 3 )
            {
                Instantiate(ball, new Vector3(2.7f, 6.15f,-9f), Quaternion.identity);
                yield return new WaitForSeconds(speed);
            }
            speed -= 0.005f;

            if( speed < 0.256f)
            {
                fadeObj.Delay();
                Invoke("Fade", 2);
                break;
            }
        }
    }
}
