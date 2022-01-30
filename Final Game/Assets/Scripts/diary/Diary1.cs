using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary1 : MonoBehaviour
{
    public Interaction script;
    public GameObject DiaryPage;
    void Start()
    {
        DiaryPage.SetActive(false); //sets so cant see UI at start

    }

    private void Update()
    {
        if (script.activate == "on") //if is meant to be on
        {
            DiaryPage.SetActive(true);  //Can see page
            if (Input.GetKeyDown("f")) //if f is clicked then can no longer see page
            {
                script.activate = "off";
                DiaryPage.SetActive(false);
            }

        }


    }



}