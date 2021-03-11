using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public float timer;
    public int waitSeconds;
    public bool fadeOut, callMe;
    public CanvasGroup me;

    private void Start()
    {
        if (callMe) return; 

        if (MenuManager.atStateOfRecover == 0)
        Invoke("Delay", waitSeconds);
    }
    public void Delay()
    {
        StartCoroutine(FadeIn());
    }
    public IEnumerator FadeIn()
    {
        float value = 1 / (timer * 100), now = 0f;

        for (int i = 0; i < (timer * 100); i++)
        {
            yield return new WaitForSeconds(0.01f);
            now += value;
            me.alpha = now;
        }
        me.interactable = true;
        yield return new WaitForSeconds(0.01f);
    }
}
