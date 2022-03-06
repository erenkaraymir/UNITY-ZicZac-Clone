using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform topKonum;
    Vector3 distance;

    void Start()
    {
        distance = transform.position - topKonum.position;    
    }

    void Update()
    {
        if(BallControl.dustu_mu == false)
        {
            transform.position = topKonum.position + distance;
        }
    }
}
