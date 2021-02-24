using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSlider : MonoBehaviour
{
    public void setLevel(float sliderValue)
    {
        PlayerPrefs.SetFloat("backGroundMusic", sliderValue);
    }
}
