using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explodeEffect;
    public GameObject soundEffect;
    

    void OnTriggerEnter(Collider col)
    {
        PlayerPrefs.SetInt("Bonus", PlayerPrefs.GetInt("Bonus") + 10);
        GameObject effect = Instantiate(explodeEffect, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(effect, 5f);
        GameObject sound = Instantiate(soundEffect, gameObject.transform.position, gameObject.transform.rotation);
        sound.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Sound", 1);
        Destroy(sound, 5f);
        Destroy(this.gameObject);
        this.gameObject.SetActive(false);
        
        
        
    }
}
