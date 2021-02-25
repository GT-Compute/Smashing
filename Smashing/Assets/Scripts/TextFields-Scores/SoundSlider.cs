using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSlider : MonoBehaviour
{
    public void setLevel(float sliderValue)
    {
        PlayerPrefs.SetFloat("Sound",sliderValue);
    }
}
