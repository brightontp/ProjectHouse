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
   
    private void Update()
    {
        if (script.activate == "on")
            uiObject.SetActive(true);

    } 

}