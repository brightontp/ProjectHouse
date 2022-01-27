using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public Interaction script;
    public GameObject uiObject;
    
    void Start()
    {
        uiObject.SetActive(false);
    }
   
    public void Update()
    {
        if (script.activate == "on")
        {
            uiObject.SetActive(true);
            if (Input.GetKey("c"))
            {
                uiObject.SetActive(false);
                script.activate = "off";
            }
        }
           
    } 

}