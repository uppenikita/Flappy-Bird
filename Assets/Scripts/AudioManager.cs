using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource Backgroundmusic;
    public static AudioManager instance;
    public GameObject gameOverSound;
        void Start()
    {
        Backgroundmusic.Play();
    }
    private void Awake(){
    instance = this;
}

}


