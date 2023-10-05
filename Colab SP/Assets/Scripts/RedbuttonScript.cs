using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedbuttonScript : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public GameObject Door;
    DoubleDoorScript doubledoorScript;
    bool activator;
    public AudioSource source;
    public AudioClip clip;

    void Start()
    {
        doubledoorScript = Door.GetComponent<DoubleDoorScript>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "HeayCube")
        {
            transform.position = point2.position;
            source.PlayOneShot(clip);
            doubledoorScript.RedActivator = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "HeayCube")
        {
            transform.position = point1.position;
            source.PlayOneShot(clip);
            doubledoorScript.RedActivator = false;
        }
    }


}
