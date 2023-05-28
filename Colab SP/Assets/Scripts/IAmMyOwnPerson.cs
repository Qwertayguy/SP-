using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAmMyOwnPerson : MonoBehaviour
{
    private Quaternion LastParentRotation;
    void Start()
    {
        LastParentRotation = transform.parent.localRotation;
    }

    void FixedUpdate()
    {
        transform.localRotation = Quaternion.Inverse(transform.parent.localRotation) * LastParentRotation * transform.localRotation;

        LastParentRotation = transform.parent.localRotation;
    }
}
