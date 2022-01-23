using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class searchForItem : MonoBehaviour, IInteractable
{
    public PickupTest script;
    public bool clicked;
    public GameObject neededObject;
    public GameObject reaction;
    private void Start()
    {
        reaction.SetActive(false);
        clicked = false;
    }

    public void Interact()
    {

        if (script.itemOwned == "owned")
        {
            clicked = true;
            reaction.SetActive(true);
            Destroy(neededObject);
        }
            
    }
   
    
}
