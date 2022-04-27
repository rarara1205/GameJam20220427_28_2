using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public static GManager instance = null;
    public int score;
    public float time;
    [HideInInspector] public bool isGameOver = false;
    [HideInInspector] public bool isGameClear = false;

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
        isGameClear = false;
        isGameOver = false;
        score = 0;
    }
}
