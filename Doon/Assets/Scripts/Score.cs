using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI scoreText = null;
    private int oldScore = 0;
    public AudioClip sound;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreText.text = "Score " + GManager.instance.score;
    }

    // Update is called once per frame
    void Update()
    {
        if(oldScore != GManager.instance.score)
        {
            scoreText.text = "Score " + GManager.instance.score;
            oldScore = GManager.instance.score;
            audioSource.PlayOneShot(sound);
        }
    }
}
