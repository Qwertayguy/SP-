using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellButtonScript : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public GameObject Door;
    public GameObject DoorO;
    DoorScript doorScript;
    DoorScript doorScriptO;
    bool activator;
    public AudioSource source;
    public AudioClip clip;

    void Start()
    {
        doorScript = Door.GetComponent<DoorScript>();
        doorScriptO = DoorO.GetComponent<DoorScript>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "HeayCube")
        {
            transform.position = point2.position;
            source.PlayOneShot(clip);
            doorScript.Activator = true;
            doorScriptO.Activator = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "HeayCube")
        {
            transform.position = point1.position;
            source.PlayOneShot(clip);
            doorScript.Activator = false;
            doorScriptO.Activator = true;
        }
    }


}
