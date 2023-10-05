using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlain : MonoBehaviour
{
    public Transform player;
    public Transform respawn_point;
    private bool check;

    private void OnTriggerEnter(Collider other)
    {
        check = true;
    }

    private void OnTriggerExit(Collider other)
    {
        check = false;
    }

}
