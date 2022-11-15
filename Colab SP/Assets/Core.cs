using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    public GameObject OtherGameObject;
    public GameObject Cire;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OtherGameObject.transform.position = Cire.transform.position;
    }
}
