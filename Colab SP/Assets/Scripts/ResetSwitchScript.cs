using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetSwitchScript : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    bool activator;
    public AudioSource source;
    public AudioClip clip;
    [SerializeField] bool down;
    Outline outline;
    public GameObject Viseble;

    void Start()
    {
        
        outline = Viseble.GetComponent<Outline>();
    }
    IEnumerator WaitADamnMoment()
    {
        if (down == true)
        {
            transform.position = point2.position;
            source.PlayOneShot(clip);
            outline.OutlineColor = Color.green;
            down = false;
            yield return new WaitForSeconds(1.1f);
        }
        if (down == false)
        {
            transform.position = point1.position;
            source.PlayOneShot(clip);
            outline.OutlineColor = Color.black;
        }
        

    }
    private void OnMouseDown()
    {
        if (down == false)
        {
            down = true;
            StartCoroutine(WaitADamnMoment());
        }
    }
    private void Update()
    {
       
            StartCoroutine(WaitADamnMoment());
        
        
    }

}
