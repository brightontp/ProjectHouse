using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary1 : MonoBehaviour
{
    public Interaction script;
    public GameObject DiaryPage;
    void Start()
    {
        DiaryPage.SetActive(false);

    }

    private void Update()
    {
        if (script.activate == "on")
        {
            DiaryPage.SetActive(true);
            StartCoroutine(ReadTime());
        }


    }

    IEnumerator ReadTime()
    {
        if (script.activate == "on")
        {
            yield return new WaitForSecondsRealtime(20.0f);
            Destroy(DiaryPage);
        }
    }

}