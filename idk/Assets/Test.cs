using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    float xInput;
    float zInput;
    public float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 500);
        }

        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical" );

        rb.AddForce(xInput * speed, 0, zInput * speed);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bad")
        {
            Destroy(gameObject);
        }
    }
}
