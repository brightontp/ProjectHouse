using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newspaper : MonoBehaviour
{
    public Interaction script;
    public GameObject uiObject;
    public GameObject itemIcon;
    public GameObject realObject;
    public bool closed = false;
    public bool added = false;
    public string itemOwned = "notOwned";
   
    // Use this for initialization
    void Start()
    {
        
        itemIcon.SetActive(false);
        itemOwned = "notOwned";
        added = false;
        uiObject.SetActive(false);
    }

    public void Interact()
    {
        added = true;

    }
    public void Update()
    {
        if (script.activate == "on")
        {
            uiObject.SetActive(true);
            if (Input.GetKey("c"))
            {
                uiObject.SetActive(false);
                itemIcon.SetActive(true);
                itemOwned = "owned";
                realObject.SetActive(false);
                script.activate = "on";
            }
            
        }
        
    }
}
