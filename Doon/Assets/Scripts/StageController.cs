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
    private bool toTitle = false;
    private bool highScoreActive = false;

    // Start is called before the first frame update
    void Start()
    {
        gameOverObj.SetActive(false);
        gameClearObj.SetActive(false);
        Instantiate(playerObj, startPoint.transform.position, playerObj.transform.rotation);
        highScoreActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (retryGame)
        {
            GManager.instance.RetryGame();
            SceneManager.LoadScene("Play");
        }

        if (GManager.instance.isGameClear)
        {
            gameClearObj.SetActive(true);
            if (!highScoreActive)
            {
                naichilab.RankingLoader.Instance.SendScoreAndShowRanking(GManager.instance.score);
                highScoreActive=true;
            }
        }

        if(toTitle)
        {
            GManager.instance.RetryGame();
            SceneManager.LoadScene("Title");
        }

        if(GManager.instance.gameOverActive)
        {
            gameOverObj.SetActive(true);
        }

    }

    public void Retry()
    {
        retryGame = true;
        highScoreActive = false;
    }

    public void ToTitle()
    {
        toTitle = true;
    }

    

}
