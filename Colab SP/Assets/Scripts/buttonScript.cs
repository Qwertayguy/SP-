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
    public AudioSource source;
    public AudioClip clip;

    void Start()
    {
        doorScript = Door.GetComponent<DoorScript>();
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "HeayCube")
        {
            transform.position = point2.position;
            source.PlayOneShot(clip);
            doorScript.Activator = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "HeayCube")
        {
            transform.position = point1.position;
            source.PlayOneShot(clip);
            doorScript.Activator = false;
        }
    }

    
}
