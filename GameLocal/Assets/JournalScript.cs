using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalScript : MonoBehaviour
{
    public GameObject jorTab;
    // Use this for initialization
    void Start()
    {
        jorTab.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("j"))
        {
            jorTab.SetActive(true);
        }
        else
        {
            jorTab.SetActive(false);
        }
    }
}
