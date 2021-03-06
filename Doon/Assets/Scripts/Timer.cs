using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI timeText = null;
    private float oldTime;
    private float timeLimit;

    // Start is called before the first frame update
    void Start()
    {
        timeLimit = GManager.instance.timeLimit;
        GManager.instance.time = timeLimit;
        oldTime = timeLimit;
        timeText = GetComponent<TextMeshProUGUI>();
        timeText.text = "Time " + (int)timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        GManager.instance.time -= Time.deltaTime;

        if ((int)GManager.instance.time != (int)oldTime)
        {
            timeText.text = "Time " + ((int)GManager.instance.time).ToString("00");
            oldTime = GManager.instance.time;
        }

        if(GManager.instance.time <= 0 && !GManager.instance.isGameOver)
        {
            GManager.instance.isGameClear = true;
            Destroy(this.gameObject);
        }

        if (GManager.instance.isGameOver) Destroy(this.gameObject);

    }
}
