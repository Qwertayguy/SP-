using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] Transform Self;
    [SerializeField] Vector2 turn;
    [SerializeField] float y;
    [SerializeField] float x;
    [SerializeField] float speed;
    float SerlRY;

    private void Start()
    {

    }
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        transform.rotation = Quaternion.Euler(turn.y * y, turn.x * x, 0f);
    }

}
