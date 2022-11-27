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

    private void Update()
    {
        if (check == true)
        {
            player.transform.position = respawn_point.transform.position;
            Debug.Log("happened");
        }
    }
}
