using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDoThat : MonoBehaviour
{
    public GameObject me;
    void Start()
    {
        me.transform.localScale = new Vector3(1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
