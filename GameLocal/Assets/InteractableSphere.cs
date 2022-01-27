using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableSphere : MonoBehaviour, IInteractable
{


    public string activate = "off";

    private void fixedupdate()
    {

        if (activate == "on")
        {
            transform.position = new Vector3(0,0,2) * Time.deltaTime;
        }
        
    }
    
    
    public void Interact()
    {
        gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        transform.Translate(1, 0, 0);
        activate = "on";
        ;
    }
}

