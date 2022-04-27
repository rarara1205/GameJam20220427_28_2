using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    [Header("���Z����X�R�A")] public int myScore;
    [Header("�v���C���[�̔���")] public PlayerTriggerCheck playerCheck;
    private float time = 0f;

    // Update is called once per frame
    void Update()
    {
        if (playerCheck.isOn)
        {
            if(GManager.instance != null)
            {
                GManager.instance.score += myScore;
                Destroy(this.gameObject);
            }
        }

        this.time += Time.deltaTime;
        if(this.time > 5f)
        {
            Destroy(this.gameObject);
            this.time = 0f;
        }



    }
}
