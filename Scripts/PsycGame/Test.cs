using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test : MonoBehaviour
{
    public Text speedTest;
    void Start()
    {
        speedTest.text = "Speed =" + psycMechanic.speed;
    }

    // Update is called once per frame
    void Update()
    {
        speedTest.text = "Speed =" + psycMechanic.speed;
    }
}
