using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour, IInteractable
{

    [SerializeField]
    public GameObject interactMessage;
    public GameObject background;

    public string activate = "off";
    public bool canFlipPan = false;

    public void Start()
    {
        interactMessage.SetActive(false);   //if i is pressed then can see the inventory
        background.SetActive(false); //if i is pressed then can see the inventory
    }

    public void OnMouseOver() //If mouse goes over place
    {
        interactMessage.SetActive(true);  //can see UI
        background.SetActive(true);  //Can see background
    }
    public void OnMouseExit()  //when mouse leaves
    {
        interactMessage.SetActive(false);  //cant see ui
        background.SetActive(false);  //cant see background
    }
    public void Interact()
    {
        activate = "on";
        canFlipPan = true;

    }

    
}

