using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableInfects : MonoBehaviour
{
    public GameObject down, up;

    private void Start()
    {
        if (MenuManager.downFixed)
            down.SetActive(false);
        if (MenuManager.upFixed)
            up.SetActive(false);
    }
}
