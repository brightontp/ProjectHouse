using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour, IInteractable
{


    public string activate = "off";

    public void Interact()
    {
    
        transform.Translate(1, 0, 0);
        activate = "on";
        ;
    }
}

