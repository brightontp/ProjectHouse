using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory2 : MonoBehaviour
{
    public Interaction script;
    public GameObject UiObject;
    public GameObject memoryObject;
    void Start()
    {
        UiObject.SetActive(false);
        
    }

    private void Update()
    {
        if (script.activate == "on")
        {
            UiObject.SetActive(true);
            memoryObject.SetActive(true);
            StartCoroutine(WaitForSec());
        }


    }

    IEnumerator WaitForSec()
    {
        if (script.activate == "on")
        {
            yield return new WaitForSecondsRealtime(3.0f);
            Destroy(UiObject);
        }
    }

}

