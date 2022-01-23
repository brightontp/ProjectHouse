using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour, IInteractable
{

    [SerializeField]
    public GameObject interactMessage;
    public GameObject background;

    public string activate = "off";

    public void Start()
    {
        interactMessage.SetActive(false);
        background.SetActive(false);
    }

    public void OnMouseOver()
    {
        interactMessage.SetActive(true);
        background.SetActive(true);
    }
    public void OnMouseExit()
    {
        interactMessage.SetActive(false);
        background.SetActive(false);
    }
    public void Interact()
    {
    
        
        activate = "on";
        ;
    }

    
}

