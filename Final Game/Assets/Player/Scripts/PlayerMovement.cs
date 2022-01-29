using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float jumpHeight = 20f;
    private Animator animator;
    Vector3 velocity;
    bool isGrounded;
    public float waitTime;

    // Start is called before the first frame update
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        controller.center = new Vector3(0, 1, 0);
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); //Checks to see if the player is on the ground

        if (isGrounded && velocity.y < 0) //Ensure character is on the ground (not floating on the groundcheck)
        {
            velocity.y = -2f;
        }
        

        //calls the move function

        Move();

        //if press jump button (space) and are on the ground

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            animator.SetTrigger("Jump");  //play the jump animator
            StartCoroutine(Jump());  //wait for time before actually moving up
             
        }

        //calculates gravity

        velocity.y += gravity + Time.deltaTime;

        //moves according to gravity

        controller.Move(velocity * Time.deltaTime);
    }

    private void Move()
    {
        float z = Input.GetAxis("Vertical"); //movement forward/backward values

        if (isGrounded)
        {
            Vector3 moveDirection = new Vector3(0, 0, z * speed);
            moveDirection = transform.TransformDirection(moveDirection);
            controller.Move(moveDirection * Time.deltaTime);
            animator.SetFloat("Speed", moveDirection.magnitude);


        }
    }

    IEnumerator Jump()
    {
        yield return new WaitForSecondsRealtime(waitTime);  //
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        

    }




}
