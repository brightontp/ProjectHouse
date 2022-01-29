using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotCheck : MonoBehaviour
{
    public Interaction script;
    private Animator animator, animator1;
    public GameObject otherObject, ladel;
    public float rayDistance = 4f;
    private RaycastHit hitInfo;


    private void Start()
    {

        animator = otherObject.GetComponent<Animator>();
        animator1 = ladel.GetComponent<Animator>();




    }


    private void FixedUpdate()
    {
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;


        Debug.DrawRay(origin, direction * 2f, Color.red);  //debugger ray
        Ray ray = new Ray(origin, direction);
        if (script.canFlipPan)
        {
            if (Physics.Raycast(ray, out hitInfo, rayDistance))
            {
                if (Input.GetKeyDown("e"))
                {
                    animator.Play("Pot");  //plays pot fall animation if e is pressed and player is withing raydistance of wall
                    animator1.Play("LadelFall");
                }
            }
        }


    }


}