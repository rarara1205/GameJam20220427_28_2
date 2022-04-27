using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItemRandomPosition : MonoBehaviour
{
    public GameObject createPrefab;

    private float time = 0f;
    public float interval = 1.0f;
    public float range_x;
    public float range_z;

    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime;

        if(this.time > interval)
        {
            float x = Random.Range(-range_x, range_x);
            float z = Random.Range(-range_z, range_z);

            Instantiate(createPrefab, new Vector3(x, 0.0f, z), createPrefab.transform.rotation);

            time = 0f;
        }

        if (GManager.instance.isGameOver) Destroy(this.gameObject);
    }
}
