using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deez : MonoBehaviour
{
    void Start()
    {
        int i = 5;
        i = ++i + ++i;
        Debug.Log(i);

        for (int e = 0; e < 5; e++)
        {
            Debug.Log(e);
        }
    }
}
