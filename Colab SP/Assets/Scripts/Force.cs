using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    public GameObject Go;
    public float ForcePower;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce((Go.transform.position - transform.position) * ForcePower * Time.smoothDeltaTime);
    }
}
