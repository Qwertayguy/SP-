using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamFollow : MonoBehaviour
{
    
    CinemachineFreeLook cam;
    bool ShiftLock = false;

    void Start()
    {
        cam = GetComponent<CinemachineFreeLook>();
    }
    void Update()
    {
        if (ShiftLock == false)
        {
            if (Input.GetButton("Fire2"))
            {
                cam.m_YAxis.m_MaxSpeed = 3.5f;
                cam.m_XAxis.m_MaxSpeed = 300;

            }
            else
            {
                cam.m_YAxis.m_MaxSpeed = 0;
                cam.m_XAxis.m_MaxSpeed = 0;
            }
        }
        else
        {
            cam.m_YAxis.m_MaxSpeed = 3.5f;
            cam.m_XAxis.m_MaxSpeed = 300;
        }


        if (Input.GetButtonDown("Fire3"))
        {
            if (ShiftLock == false)
            {
                ShiftLock = true;
            }
            else
            {
                ShiftLock = false;
            }
        }
    }
}
