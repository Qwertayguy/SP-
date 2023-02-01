using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyFollow : MonoBehaviour
{
    public Transform target;
    public float speed = 2f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        rb.MovePosition(pos);
        transform.LookAt(target);
    }
}
