using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadHealth : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<RectTransform>() != null)
        {
            Destroy(this.gameObject);
        }
    }

    
}
