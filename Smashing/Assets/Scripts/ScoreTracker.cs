using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText;


    void Update()
    {
        scoreText.text = "Score: " + PlayerPrefs.GetInt("Score").ToString();
    }
}
