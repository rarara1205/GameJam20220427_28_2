using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SManager : MonoBehaviour
{
    public AudioClip sound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void StartGame()
    {
        audioSource.PlayOneShot(sound);
        GManager.instance.AudioStart = true;
    }

    void Update()
    {
        if(!audioSource.isPlaying && GManager.instance.AudioStart)
        {
            SceneManager.LoadScene("Play");
            GManager.instance.AudioStart = false;
        }
    }

}
