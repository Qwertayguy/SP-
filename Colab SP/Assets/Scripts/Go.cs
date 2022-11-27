using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Go : MonoBehaviour

{

    private Vector3 mOffset;

    Outline outline;

    private float mZCoord;

    public Transform player;

    private Rigidbody objectRigidbody;

    private bool IsGround;
    public Transform Tran;


    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();
        outline = GetComponent<Outline>();



    }



    void Start()

    {
        
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;




        // Store offset = gameobject world pos - mouse world pos

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();



    }



    private Vector3 GetMouseAsWorldPoint()

    {

        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;



        // z coordinate of game object on screen

        mousePoint.z = mZCoord;



        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint) + player.position + Vector3.Normalize(transform.position - player.position) * Mathf.Min(0, Vector3.Magnitude(transform.position - player.position));

    }


    void OnMouseDown()
    {
        transform.position = GetMouseAsWorldPoint();

    }



    void FixedUpdate()

    {

        
           
            
           
            transform.position = GetMouseAsWorldPoint() + mOffset;
       
        
          
        
    }

    



}