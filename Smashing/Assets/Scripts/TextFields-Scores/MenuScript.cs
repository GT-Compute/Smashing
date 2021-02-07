using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void playButton()
    {
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("Levels", 0);
        PlayerPrefs.SetInt("Lives", 3);
        SceneManager.LoadScene("Level_1");

    }

    public void shopButton()
    {
        PlayerPrefs.SetInt("Score", 0);
        SceneManager.LoadScene("Shop");

    }

    public void RestartButton()
    {
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("Levels", 0);
        PlayerPrefs.SetInt("Lives", 3);
        SceneManager.LoadScene("Level_1");
    }

    public void menuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void optionsButton()
    {
        SceneManager.LoadScene("Options");
    }

    public void aboutButton()
    {
        SceneManager.LoadScene("About");
    }



    public void quitButton()
    {
        Application.Quit();
    }
}
