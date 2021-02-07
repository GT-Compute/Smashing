using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText;
    public TMP_Text livesText;
    public float TimeLeft = 120f;
    // Update is called once per frame
    void Update()
    {
        if (TimeLeft > 0)
        {
            TimeLeft -= Time.deltaTime;
        }

        scoreText.text = "Score: " + (PlayerPrefs.GetInt("Score") + Mathf.FloorToInt(TimeLeft) + PlayerPrefs.GetInt("Bonus")).ToString();
        livesText.text = "Lives: " + PlayerPrefs.GetInt("Lives").ToString();
    }
}
