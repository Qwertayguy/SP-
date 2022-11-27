using UnityEngine;
using System.Collections;



public class doublejump : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public GameObject Player;
    [SerializeField] Transform GC;
    [SerializeField] LayerMask ground;

    public Vector3 moveDirection = Vector3.zero;
    public float rotationSpeed;
    public float MoveDirectY = 0;
    public bool Doublejump = false;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    void Update()
    {
        var cam = Camera.main;

        var MovementThisFrame = Vector3.zero;

        if (Input.GetButton("Jump") && characterController.isGrounded)
        {
            MoveDirectY = jumpSpeed;
            Doublejump = true;
        }
        else if (Input.GetButtonDown("Jump") && Doublejump == true)
        {
            MoveDirectY = jumpSpeed;
            Doublejump = false;
        }

        var Horizontal = Input.GetAxis("Horizontal") * cam.transform.right;

        var Vertical = Input.GetAxis("Vertical") * cam.transform.forward;

        MovementThisFrame += ((Horizontal + Vertical) * speed);

        MoveDirectY -= gravity * Time.deltaTime;

        MovementThisFrame.y += MoveDirectY;

        characterController.Move(MovementThisFrame * Time.deltaTime);
    }
}