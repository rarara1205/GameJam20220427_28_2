using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectDestroyGameOver : MonoBehaviour
{
    private ParticleSystem particle;
    [Header("GameOver Object")] public GameObject gameOverObj;

    // Start is called before the first frame update

    void Awake()
    {
        GManager.instance.isGameOver = true;
    }

    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (particle.isPlaying == false)
        {
            GManager.instance.gameOverActive = true;
            Destroy(gameObject);
        }
    }
}
