using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public bool Activator;



    void Start()
    {
       
    }
    void Update()
    {
       if (Activator == true)
        {
            transform.position = point1.position;
        }
        if (Activator == false)
        {
            transform.position = point2.position;
        }
    }
}
