using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageController : MonoBehaviour
{
    [Header("Player GameObject")] public GameObject playerObj;
    [Header("Start Position")] public GameObject startPoint;
    [Header("GameOver Object")] public GameObject gameOverObj;
    [Header("GameClear Object")] public GameObject gameClearObj;

    private bool retryGame = false;

    // Start is called before the first frame update
    void Start()
    {
        gameOverObj.SetActive(false);
        gameClearObj.SetActive(false);
        Instantiate(playerObj, startPoint.transform.position, playerObj.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (GManager.instance.isGameOver)
        {
            gameOverObj.SetActive(true);
        }

        if (retryGame)
        {
            GManager.instance.RetryGame();
            SceneManager.LoadScene("Play");
        }

        if (GManager.instance.isGameClear)
        {
            gameClearObj.SetActive(true);
        }
    }

    public void Retry()
    {
        retryGame = true;
    }
}
