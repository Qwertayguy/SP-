using UnityEngine;
using System.Collections;



public class NewMove : MonoBehaviour
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
    public Transform cam;



    public float TurnSmoothTime =0.1f;
    float turnSmoothVelocity;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

    }

    void Update()
    {
        

        var MovementThisFrame = Vector3.zero;

        if (Input.GetButton("Jump") && characterController.isGrounded)
        {
            MoveDirectY = jumpSpeed;
            
        }
        else if (characterController.isGrounded)
        {
            MoveDirectY = 0;
            
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        MoveDirectY -= gravity * Time.deltaTime;

        MovementThisFrame.y += MoveDirectY;

        characterController.Move(MovementThisFrame * Time.deltaTime);

        MovementThisFrame.y += MoveDirectY;
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, TurnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            characterController.Move(moveDir.normalized * speed * Time.deltaTime);
        }

    }
}