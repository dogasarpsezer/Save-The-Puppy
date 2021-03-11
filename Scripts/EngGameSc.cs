using UnityEngine;
using UnityEngine.SceneManagement;

public class EngGameSc : MonoBehaviour
{
    public bool isTrigger;
    public Fade black;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player") && !isTrigger)
        {
            black.Delay();
            Invoke("ChangeScene", 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player") && isTrigger)
        {
            black.Delay();
            Invoke("ChangeScene", 1);
        }
    }
    void ChangeScene() {
        NextLevel();
        MenuManager.atStateOfRecover++;
        SceneManager.LoadScene("Demo");
    }
    void NextLevel()
    {
        if (Comfort.comfort < 85)
            Comfort.comfort += 15;
        else
            Comfort.comfort = 100;
    }
}
