using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explodeEffect;
    void OnTriggerEnter(Collider col)
    {
        PlayerPrefs.SetInt("Bonus", PlayerPrefs.GetInt("Bonus") + 10);
        GameObject effect = Instantiate(explodeEffect, gameObject.transform.position, gameObject.transform.rotation);
        Destroy(effect, 5f);
        Destroy(this.gameObject);
        this.gameObject.SetActive(false);
        
        
    }
}
