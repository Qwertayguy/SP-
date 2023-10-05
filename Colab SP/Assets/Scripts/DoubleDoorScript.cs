using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleDoorScript : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public bool RedActivator;
    public bool BlueActivator;



    void Start()
    {

    }
    void Update()
    {
        if (RedActivator && BlueActivator == true)
        {
            transform.position = point1.position;
        }
        else
        {
            transform.position = point2.position;
        }
    }
}
