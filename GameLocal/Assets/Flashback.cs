using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashback : MonoBehaviour
{
    public Interaction script;
    public GameObject background;
    public GameObject uiObject2;
    public GameObject uiObject3;
    public GameObject uiObject4;
    public GameObject uiObject5;
    public GameObject uiObject6;
    void Start()
    {
        background.SetActive(false);
        uiObject2.SetActive(false);
        uiObject3.SetActive(false);
        uiObject4.SetActive(false);
        uiObject5.SetActive(false);
        uiObject6.SetActive(false);
    }

    public void Update()
    {
        if (script.activate == "on")
        {
            StartCoroutine(FlashbackOrder());
        }
        script.activate = "off";
        

    }
    IEnumerator FlashbackOrder()
    {
        if (script.activate == "on")
        {
            background.SetActive(true);
            uiObject2.SetActive(true);
            yield return new WaitForSecondsRealtime(3.0f);
            uiObject2.SetActive(false);
            uiObject3.SetActive(true);
            yield return new WaitForSecondsRealtime(3.0f);
            uiObject3.SetActive(false);
            uiObject4.SetActive(true);
            yield return new WaitForSecondsRealtime(3.0f);
            uiObject4.SetActive(false);
            uiObject5.SetActive(true);
            yield return new WaitForSecondsRealtime(3.0f);
            uiObject5.SetActive(false);
            uiObject6.SetActive(true);
            yield return new WaitForSecondsRealtime(3.0f);
            uiObject6.SetActive(false);
            background.SetActive(false);
        }
    }
}