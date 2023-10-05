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
    Outline outline;
    public GameObject Viseble;

    void Start()
    {
        plat.enabled = false;
        outline = Viseble.GetComponent<Outline>();
    }

    private void OnMouseUpAsButton()
    {
        if (down == false)
        {
            transform.position = point2.position;
            source.PlayOneShot(clip);
            down = true;
            plat.enabled = true;
            outline.OutlineColor = Color.green;
        }
        else if (down == true)
        {
            transform.position = point1.position;
            source.PlayOneShot(clip);
            down = false;
            plat.enabled = false;
            outline.OutlineColor = Color.black;
        }
    }


}
