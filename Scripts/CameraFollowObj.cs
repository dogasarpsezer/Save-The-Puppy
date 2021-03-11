using System.Collections;
using UnityEngine;

public class CameraFollowObj : MonoBehaviour
{
    public Rigidbody2D myrigidb;
    public GameObject toFollow;

    void Start()
    {
        StartCoroutine(Follow());
    }

    IEnumerator Follow()
    {
        //this way instead of transform making it chubby it makes everything smoother 
        Vector3 placeToGo = toFollow.transform.position;
        placeToGo = placeToGo - transform.position;
        myrigidb.velocity = placeToGo * 5;
        yield return new WaitForSeconds(0.01f);
        StartCoroutine(Follow());
    }
    public void TP()
    {
        transform.position = toFollow.transform.position;
    }

    public CanvasGroup me;

    public void FadeV(int way, float time) { Debug.Log("gol"); StartCoroutine(Fade(way, time)); }

    IEnumerator Fade(int way, float time)
    {
        Debug.Log("gol2");
        float timeC = 0;
        switch (way)
        {
            case 1:
                while (timeC < time)
                {
                    yield return new WaitForSeconds(0.02f);
                    me.alpha += 1 / time * 0.02f;
                    timeC += 0.02f;
                }
                me.alpha = 1;
                break;
            case -1:
                while (timeC < time)
                {
                    yield return new WaitForSeconds(0.02f);
                    me.alpha -= 1 / time * 0.02f;
                    timeC += 0.02f;
                }
                me.alpha = 0;
                break;
        }
        yield return new WaitForSeconds(0.01f);
    }
}
