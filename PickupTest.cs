using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTest : MonoBehaviour, IInteractable
{
 
    public GameObject itemIcon;
    public bool added = false;
    public string itemOwned = "notOwned";
    // Use this for initialization
    void Start()
    {
        itemIcon.SetActive(false);
    }

    public void Interact()
    {
        added = true;
    }

    private void Update()
    {
        if (added == true)
        {
            itemIcon.SetActive(true);
            itemOwned = "owned";
            Destroy(gameObject);
        }

    }

}