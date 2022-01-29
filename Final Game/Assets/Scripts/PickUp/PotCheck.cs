using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotCheck : MonoBehaviour
{
    public Interaction script;
    private Animator animator, animator1;
    public GameObject otherObject, ladel;
    private AudioSource s;
    public float waitTime = 2f;



    private void Start()
    {

        animator = otherObject.GetComponent<Animator>();
        animator1 = ladel.GetComponent<Animator>();
        s = otherObject.GetComponent<AudioSource>(); 
    }


    private void FixedUpdate()
    {

        if (script.canFlipPan)
        {
            
            animator.Play("Pot");  //plays pot fall animation if e is pressed and player is withing raydistance of wall
            animator1.Play("LadelFall");
            StartCoroutine(Wait(waitTime));
            
            script.canFlipPan = false;
            
               
           
        }


    }

    IEnumerator Wait(float waitTime)
    {
        yield return new WaitForSecondsRealtime(waitTime);
        s.Play();
    }


}