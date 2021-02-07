using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Win : MonoBehaviour
{
    private int tempScore = 0;
    private int increase = 0;
    private int points = 0;
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

        int levels = PlayerPrefs.GetInt("Levels");
        int Score = PlayerPrefs.GetInt("Score");
        points = Score * levels;
        increase = points / 120;
        PlayerPrefs.SetInt("Points", (PlayerPrefs.GetInt("Points") + points));
        //Debug.Log(tempScore);
    }

    // Update is called once per frame
    void Update()
    {
        if ((tempScore+increase) <= points)
        {
            tempScore = tempScore + increase +1;
            scoreText.text = "Score: " + tempScore.ToString();
            Debug.Log(tempScore);
        }
        else
        {
            
            scoreText.text = "Score: " + points.ToString();
        }
        
    }
}
