using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class ScoreDisplayWin : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text livesText;


    void Update()
    {
        scoreText.text = "Score: " + PlayerPrefs.GetInt("Score").ToString();
        livesText.text = "Lives: " + PlayerPrefs.GetInt("Lives").ToString();
    }
}
