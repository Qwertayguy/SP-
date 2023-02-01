using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float xInput;
    float zInput;
    public float moveSpeed;

    private bool isColliding;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isColliding == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 300);
        }
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void OnCollisionEnter(Collision collision)
    {
        isColliding = true;

        if(collision.gameObject.tag == ("Bad") && moveSpeed == 5)
        {
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == ("Bad") && moveSpeed == 6)
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == ("PowerUp"))
        {
            moveSpeed = 6;
             
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isColliding = false;
    }

    private void FixedUpdate()
    {
        float xVelocity = xInput * moveSpeed;
        float zVelocity = zInput * moveSpeed;

        rb.velocity = new Vector3(xVelocity, rb.velocity.y, zVelocity);
    }
}
