using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalScript : MonoBehaviour
{
    public GameObject jorTab;
    // Use this for initialization
    void Start()
    {
        jorTab.SetActive(false);  //sets so cant see UI at start

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("j"))      //if J clicked
        {
            jorTab.SetActive(true);  //show UI
        }
        else
        {
            jorTab.SetActive(false);  //otherwise hide it
        }
    }
}
