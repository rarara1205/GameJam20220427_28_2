using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public static GManager instance = null;
    public int score;
    public float time;
    public float timeLimit;
    [HideInInspector] public bool isGameOver = false;
    [HideInInspector] public bool isGameClear = false;
    [HideInInspector] public bool AudioStart = false;
    [HideInInspector] public bool gameOverActive;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    public void RetryGame()
    {
        gameOverActive = false;
        isGameClear = false;
        isGameOver = false;
        score = 0;
    }
}
