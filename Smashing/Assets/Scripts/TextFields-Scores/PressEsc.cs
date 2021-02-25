using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressEsc : MonoBehaviour
{
    public GameObject EscMenu;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
