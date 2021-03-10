using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfortBar : MonoBehaviour
{
    public RectTransform child;

    private void FixedUpdate()
    {
        child.sizeDelta = new Vector2(Comfort.comfort * 5,0);
    }
}
