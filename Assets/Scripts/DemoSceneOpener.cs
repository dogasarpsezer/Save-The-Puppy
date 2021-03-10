using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DemoSceneOpener : MonoBehaviour
{
    public string[] stringNames;
    public Button[] buttons;
    public bool isEye;
    public Fade table, dog;
    private void Start()
    {
        if (isEye == false)
        {
            buttons[MenuManager.atStateOfRecover].interactable = true;
        }
        if (MenuManager.atStateOfRecover > 0 && isEye == false)
        {
            Set();
        }
    }
    public GameObject skp;
    public void Skip()
    {
        skp.SetActive(false);
        Set();
    }
    public void Set()
    {
        table.Delay();
        dog.Delay();
    }
    public void OpenScene(int i)
    {
        SceneManager.LoadScene(stringNames[i]);
    }
    public void ResetGame()
    {
        MenuManager.atStateOfRecover = 0;
        MenuManager.downFixed = false;
        MenuManager.upFixed = false;
        MenuManager.isBad = false;
        Comfort.comfort = 100;
        SceneManager.LoadScene(stringNames[0]);
    }
}
