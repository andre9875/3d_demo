using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{

    public AudioSource invisibleWall; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayAudio() {
        invisibleWall.Play();
    }



}
