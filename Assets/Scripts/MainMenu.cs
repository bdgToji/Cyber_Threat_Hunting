using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject tut1;
    [SerializeField] private GameObject tut2;
    [SerializeField] private GameObject tut3;
    public void StartBtn()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void TutBtn()
    {
        tut1.SetActive(!tut1.activeSelf);
        tut2.SetActive(!tut2.activeSelf);
        tut3.SetActive(!tut3.activeSelf);
    }

    public void QuitBtn()
    {
        Application.Quit();
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
