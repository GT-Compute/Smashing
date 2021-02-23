using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscMenuScript : MonoBehaviour
{

    public GameObject escMenu;
    public void resumeButton()
    {
        escMenu.SetActive(false);
        Time.timeScale = 1;

    }

    public void menuButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void quitButton()
    {
        Application.Quit();
        Time.timeScale = 1;
    }
}
