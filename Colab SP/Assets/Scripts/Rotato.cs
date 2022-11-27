using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotato : MonoBehaviour
{
    public Transform rotate;
    public Transform rotater;
    public float speed;
    float angelX;
    float angelY;


    void Update()
    {
        angelX += Input.GetAxis("Mouse X") * speed * -Time.deltaTime;
        angelY += Input.GetAxis("Mouse Y") * speed * -Time.deltaTime;
        rotate.localRotation = Quaternion.AngleAxis(angelX, Vector3.up);
        rotater.localRotation = Quaternion.AngleAxis(angelY, Vector3.right);
    }
}
