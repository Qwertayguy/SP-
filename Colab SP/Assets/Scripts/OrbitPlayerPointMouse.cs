using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitPlayerPointMouse : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] Transform Self;
    [SerializeField] Vector2 turn;
    [SerializeField] float y;
    [SerializeField] float x;
    [SerializeField] float speed;
    float SerlRY;

    public Transform pivot;
    public float maxViewAngle;
    public float minViewAngle;

    private void Start()
    {
        
    }
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        turn.y = Mathf.Clamp(turn.y, -4f, 4f);
        transform.localRotation = Quaternion.Euler(turn.y * y, turn.x * x, 0f);
        pivot.transform.rotation = transform.rotation;


    }

}
