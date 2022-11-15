using UnityEngine;
using System.Collections;



public class ExampleClass : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public GameObject Player;
    [SerializeField] Transform GC;
    [SerializeField] LayerMask ground;
    public bool DoubleJump = false;

    public Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    void Update()
    {
        var cam = Camera.main;

        if (characterController.isGrounded)
        {


            moveDirection = new Vector3(0.0f, 0.0f, 0.0f);

            moveDirection *= speed;


        }
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            
            
            
                moveDirection.y = jumpSpeed;
                DoubleJump = true;

            
            
        }
        var H = Input.GetAxis("Horizontal") * cam.transform.right;
        var V = Input.GetAxis("Vertical") * cam.transform.forward;

        bool IsGrounded()
        {
            return Physics.CheckSphere(GC.position, .1f, ground);
        }

        moveDirection.y -= gravity * Time.deltaTime;

        characterController.Move(moveDirection * Time.deltaTime);

        characterController.Move(((H + V) * speed) * Time.deltaTime);
    }
}
