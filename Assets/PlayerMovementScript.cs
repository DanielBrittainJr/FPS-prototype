using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    private float jumpHeight = 1.0f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;

    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        Gravity();


        PlayerJump();


        PlayerMove();

        
    }

    void PlayerJump()
    {
        //if player presses jump and is on the ground
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //calculating x and z movement. 
        Vector3 move = transform.right * x + transform.forward * z;
        //moving controller based on calculated position * speed * deltatime
        controller.Move(move * speed * Time.deltaTime);
        controller.Move(velocity * Time.deltaTime);
    }

    void Gravity()
    {
        //checking if on the ground with a checksphere/raycast
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        //applying gravity force
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        velocity.y += gravity * Time.deltaTime;

    }
}
