using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    bool EscLock;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        turn.y = Mathf.Clamp(turn.y, -21f, 21f);
        transform.localRotation = Quaternion.Euler(turn.y * y, turn.x * x, 0f);
        pivot.transform.rotation = transform.rotation;

        if (Time.timeScale == 1f)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }

        

    }

}
