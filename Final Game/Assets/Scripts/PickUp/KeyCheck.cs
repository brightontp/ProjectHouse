using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCheck : MonoBehaviour, IInteractable
{
    public Pickup script;
    public bool clicked;
    public GameObject neededObject;

    public GameObject pickUp;

    private Animator animator;
    public GameObject otherObject;
    public float rayDistance = 4f;
    private RaycastHit hitInfo;


    private void Start()
    {
        clicked = false;
        animator = otherObject.GetComponent<Animator>();
        



    }

    public void Interact()
    {

        if (script.itemOwned == "owned")  //If the player has picked up the key
        {
            clicked = true;
            neededObject.SetActive(false);  //destroy physical object and UI screenshot
            pickUp.SetActive(false);
        }

    }

    private void FixedUpdate()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;


        Debug.DrawRay(origin, direction * 2f, Color.red);  //debugger ray
        Ray ray = new Ray(origin, direction);
        if (script.itemOwned == "owned")
        {
            if (Physics.Raycast(ray, out hitInfo, rayDistance))
            {
                if (Input.GetKeyDown("e"))
                {
                    animator.Play("Door_open");  //plays open door animation if e is pressed and player is withing raydistance of wall
  
                    clicked = true;

                    neededObject.SetActive(false);
                    pickUp.SetActive(false);
                }
            }
        }


    }


}