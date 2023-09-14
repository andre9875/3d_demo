using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public GameObject audioWall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == audioWall && audioWall.GetComponent<AudioSource>().isPlaying == false)
        {
            print("This Works.");
            audioWall.GetComponent<AudioSource>().Play();

        }

    }
    private void OnTriggerExit(Collider other)
    {
        audioWall.GetComponent<AudioSource>().Pause();

    }

}
