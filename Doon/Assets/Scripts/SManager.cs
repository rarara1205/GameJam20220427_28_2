using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Play");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Title");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
