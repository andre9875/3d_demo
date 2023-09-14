using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStartGame : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject model01;
    public GameObject model02;
    public GameObject model03;

    public GameObject mobileStart;
    public GameObject pcStart;

    bool isMobile = Application.isMobilePlatform;

    void Start()
    {
        mobileStart.SetActive(false);
        pcStart.SetActive(false);

        model01.SetActive(true);
        model02.SetActive(true);
        model03.SetActive(true);


        if (isMobile)
        {
            mobileStart.SetActive(true);
        }
        else
        {
            pcStart.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }

}
