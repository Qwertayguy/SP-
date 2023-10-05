using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxDoor : MonoBehaviour
{
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
        if (other.tag == "Player")
        {
            
            
            doorScript.Activator = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            doorScript.Activator = false;
        }
    }
}
