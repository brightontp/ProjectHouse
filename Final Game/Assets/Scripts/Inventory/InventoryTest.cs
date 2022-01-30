using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTest : MonoBehaviour
{

    public GameObject invTab;
    // Use this for initialization
    void Start()
    {
        invTab.SetActive(false);  //sets so cant see UI at start
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("i"))
        {
            invTab.SetActive(true);     //if i is pressed then can see the inventory
        }
        else
        {
            invTab.SetActive(false);    //if i isn't pressed then can't see the inventory
        }
    }
}
