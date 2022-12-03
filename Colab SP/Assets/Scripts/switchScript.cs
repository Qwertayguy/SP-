using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchScript : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    bool activator;
    public AudioSource source;
    public AudioClip clip;
    bool down;
    public Behaviour plat;

    void Start()
    {
        plat.enabled = false;

    }

    private void OnMouseUpAsButton()
    {
        if (down == false)
        {
            transform.position = point2.position;
            source.PlayOneShot(clip);
            down = true;
            plat.enabled = true;
        }
        else if (down == true)
        {
            transform.position = point1.position;
            source.PlayOneShot(clip);
            down = false;
            plat.enabled = false;
        }
    }


}
