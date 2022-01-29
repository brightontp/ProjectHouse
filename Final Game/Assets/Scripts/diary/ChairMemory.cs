using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairMemory : MonoBehaviour
{
    public Interaction script;
    public GameObject UiObject;
    public GameObject memoryObject;
    void Start()
    {
        UiObject.SetActive(false);   //hides UI element at start
        
    }

    private void Update()
    {
        if (script.activate == "on")       //when other script on item says so
        {
            UiObject.SetActive(true);
            memoryObject.SetActive(true);      //open UI object, add it to the inventory, Wait for 3 seconds
            StartCoroutine(WaitForSec());
            script.activate = "off";
        }


    }

    IEnumerator WaitForSec()
    {
        if (script.activate == "on")
        {
            yield return new WaitForSecondsRealtime(3.0f);
            UiObject.SetActive(false);     //Delete it from to UI (still in the journal)
        }
    }

}

