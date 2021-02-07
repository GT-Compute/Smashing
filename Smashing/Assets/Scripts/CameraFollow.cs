using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform tracked;

    private Vector3 CamOffSet;
    public float SmoothFactor = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        CamOffSet = transform.position - tracked.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = tracked.position + CamOffSet;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
    }
}
