using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEffect : MonoBehaviour
{
    public GameObject trackingEffect;
    public GameObject explosionEffect;
    public GameObject verticalEffect;
    public GameObject horizonEffect;

    private float time;
    private int Cnt;
    public float[] intervalTime;
    public float[] transitionTime;
    public float range_x;
    public float range_z;
    public float scale_min;
    public float scale_max;

    // Start is called before the first frame update
    void Start()
    {
        this.time = 0f;
        this.Cnt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GManager.instance.isGameOver || GManager.instance.isGameClear) Destroy(this.gameObject);

        this.time += Time.deltaTime;


        if (GManager.instance.time < transitionTime[Cnt])
        {
            this.Cnt++;
        }

        if (this.time > intervalTime[Cnt])
        {

            float x = Random.Range(-range_x, range_x);
            float z = Random.Range(-range_z, range_z);
            float scaleVal = Random.Range(scale_min, scale_max);
            GetChildrenChangeStartSize(explosionEffect, scaleVal);
            Instantiate(explosionEffect, new Vector3(x, 0.0f, z),explosionEffect.transform.rotation);

            this.time = 0f;
        }
    }

    void GetChildrenChangeStartSize(GameObject obj, float scaleVal)
    {
        ParticleSystem[] childrenParticles = obj.GetComponentsInChildren<ParticleSystem>();
        foreach (ParticleSystem obParticle in childrenParticles)
        {
            var main = obParticle.main;
            main.startSize = scaleVal;
        }
    }
}
