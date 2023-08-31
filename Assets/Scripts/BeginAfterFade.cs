using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginAfterFade : MonoBehaviour
{
    public GameObject firstPerson;
    public GameObject fadeImage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BeginNow() {

        firstPerson.GetComponent<FirstPersonController>().enabled = true;
        fadeImage.SetActive(false);

    }
}
