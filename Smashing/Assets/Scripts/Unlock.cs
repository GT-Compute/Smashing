using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    public GameObject boi;
    

    private void OnTriggerEnter(Collider other)
    {
        boi.SetActive(true);
        Destroy(gameObject);
    }



    private void OnCollisionEnter(Collision other)
    {
        boi.SetActive(true);
    }
}
