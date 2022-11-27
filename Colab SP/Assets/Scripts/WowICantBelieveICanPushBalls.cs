using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WowICantBelieveICanPushBalls : MonoBehaviour
{
    public GameObject Arm; //thing want move;
    public GameObject Core;//thing original pos;
    public GameObject Cire;//where want thing go;
    private Vector3 StartPos; //thing where first start;
    private Vector3 EndPos; //thing where end up after blacking out on a party;
    private float lerpTime = 5f;//how long it take to get to EndPos;
    private float currentLurpTime = 5f; //idk man i watched a yt video to make this script;
    bool Check;

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        StartPos = Core.transform.position;
        EndPos = Cire.transform.position;
        if (Input.GetButtonDown("Fire1") && Check == false)
        {
            currentLurpTime += Time.deltaTime;
            if (currentLurpTime >= lerpTime)
            {
                currentLurpTime = lerpTime;
            }

            float perc = currentLurpTime / lerpTime;
            Arm.transform.position = Vector3.Lerp(StartPos, EndPos, perc);
            Check = true;
        }
        else if (Input.GetButtonDown("Fire1") && Check == true)
        {
            currentLurpTime += Time.deltaTime;
            if (currentLurpTime >= lerpTime)
            {
                currentLurpTime = lerpTime;
            }

            float perc = currentLurpTime / lerpTime;
            Arm.transform.position = Vector3.Lerp(EndPos, StartPos, perc);
            Check = false;
        }
    }
}
