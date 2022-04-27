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
    public float transitionTime;
    public float interval;
    public float range_x;
    public float range_z;

    // Start is called before the first frame update
    void Start()
    {
        this.time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime;


        float x = Random.Range(-range_x, range_x);
        float z = Random.Range(-range_z, range_z);

        if (this.time > transitionTime)
        {
            Instantiate(explosionEffect, new Vector3(x, 0.0f, z),explosionEffect.transform.rotation);

            time = 0f;
        }

        if (GManager.instance.isGameOver || GManager.instance.isGameClear) Destroy(this.gameObject);
    }
}
