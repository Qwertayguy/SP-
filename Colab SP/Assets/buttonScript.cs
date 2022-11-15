using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public GameObject Door;
    DoorScript doorScript;
    bool activator;

    void Start()
    {
        doorScript = Door.GetComponent<DoorScript>();
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "HeayCube")
        {
            transform.position = point2.position;
            doorScript.Activator = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        transform.position = point1.position;
        doorScript.Activator = false;
    }
}
