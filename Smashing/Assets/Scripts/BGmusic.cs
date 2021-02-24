using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGmusic : MonoBehaviour
{
    // Start is called before the first frame update
    private static BGmusic instance = null;
    public static BGmusic Instance
    {
        get { return instance;  }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("backGroundMusic", 1);
    }
}
