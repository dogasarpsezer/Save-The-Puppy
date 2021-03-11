using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void OpenScene()
    {
        SceneManager.LoadScene("Demo");
    }
    public static bool isBad = false, downFixed, upFixed;
    public GameObject openText, closeText, openPhoto;
    private void Start()
    {
        if (isBad)
        {
            openPhoto.SetActive(true);
            openText.SetActive(true);
            closeText.SetActive(false);
        }
    }

    public static float soundVol, musicVol;

    public static int atStateOfRecover = 0; 
    public Slider soundSlider, musicSlider;

    public GameObject aboutPanel, settingsPanel;
    int nowOpen =-1;
    public void PanelChange(int openedPanel)
    {

        if (nowOpen == openedPanel)
        {
            aboutPanel.SetActive(false);
            settingsPanel.SetActive(false);
        }
        else
        {
            nowOpen = openedPanel;
            if (nowOpen == 1)
            {
                aboutPanel.SetActive(true);

            }
            else
            {
                aboutPanel.SetActive(false);
 
            }
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
