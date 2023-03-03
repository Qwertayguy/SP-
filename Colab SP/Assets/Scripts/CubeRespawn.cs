using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRespawn : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Spawn;
    private Rigidbody objectRigidbody;
    PauseMenu pauseMenu;
    public Vector3 Pos;

    private void Start()
    {
        Pos = transform.position;
        pauseMenu = Canvas.GetComponent<PauseMenu>();
        objectRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (pauseMenu.reset == true)
        {
            Debug.Log("bals");
            objectRigidbody.useGravity = false;
            transform.position = Pos;
            objectRigidbody.useGravity = true;
            pauseMenu.reset = false;
        }
    }
}
