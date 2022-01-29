using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour, IInteractable
{
    public GameObject itemIcon;
    public GameObject key;
    public bool added = false;
    public string itemOwned = "notOwned";
    // Use this for initialization
    void Start()
    {

        itemIcon.SetActive(false); //sets so cant see UI at start


    }

    public void Interact()
    {
        added = true;  //set what is picked up to true
    }

    private void Update()
    {
        if (added == true)
        {
            itemIcon.SetActive(true);  //show item in inventory
            itemOwned = "owned";  //set item to owned
            key.SetActive(false); //hide physical object
        }

    }
}
