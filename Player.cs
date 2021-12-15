using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rigidBodyComponent;
    private float horizontalInput;
    private float verticalInput;
    private int speed;
    private bool player_jumped;
    private bool isGrounded;
    private bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -20.0F, 0);
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        rigidBodyComponent = GetComponent<Rigidbody>();
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            player_jumped = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        if(!isGrounded)
        {
            canJump = false;
            //return;
        }
        else
        {
            canJump = true;
        }
        
        if (player_jumped && canJump)
        //if (player_jumped)
        {
            rigidBodyComponent.AddForce(new Vector3(rigidBodyComponent.velocity.x, 12, rigidBodyComponent.velocity.z), ForceMode.VelocityChange);
            player_jumped = false;
        }

        rigidBodyComponent.velocity = new Vector3(horizontalInput, rigidBodyComponent.velocity.y/speed , verticalInput) * speed;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

}
