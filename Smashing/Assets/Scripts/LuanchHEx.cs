using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuanchHEx : MonoBehaviour
{
    public float force = 10f;
    public float forceY = 0f;
    public float forceZ = 0f;
    public Transform parent;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Vector3 angles = parent.rotation.eulerAngles;
            float forward = (Mathf.Cos(Mathf.Deg2Rad*angles.y) * Mathf.Cos(Mathf.Deg2Rad * angles.z));
            float upways =   (Mathf.Sin(Mathf.Deg2Rad * angles.z));
            float sideways = (Mathf.Sin(Mathf.Deg2Rad * angles.y) * Mathf.Cos(Mathf.Deg2Rad * angles.z));
            Rigidbody ball = other.GetComponent<Rigidbody>();

            ball.AddForce(-force*forward, -force*upways, force*sideways, ForceMode.VelocityChange);



        }

    }
}
