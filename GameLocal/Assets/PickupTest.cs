using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTest : MonoBehaviour, IInteractable
{
 
    public GameObject itemIcon;
    public GameObject realObject;
    public bool added = false;
    public string itemOwned = "notOwned";
    // Use this for initialization
    void Start()
    {
        itemIcon.SetActive(false);
        itemOwned = "notOwned";
        added = false;
    }

    public void Interact()
    {
        added = true;
        
    }

    void Update()
    {
        if (added == true)
        {
            itemIcon.SetActive(true);
            itemOwned = "owned";
            realObject.SetActive(false);
        }
    }

}