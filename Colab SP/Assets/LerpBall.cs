using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpBall : MonoBehaviour
{
    public Transform target;
    public float c;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.Lerp(a, b, c);
    }
}
