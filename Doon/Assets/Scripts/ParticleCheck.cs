using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCheck : MonoBehaviour
{

    private string playerTag = "Player";
    private string groundTag = "Ground";
    public GameObject breakEffect;

    private void OnParticleCollision(GameObject gameObj)
    {
        if (gameObj.tag == playerTag)
        {
            Destroy(gameObj);
            GenerateEffect(gameObj);
        }
        else if(gameObj.tag == groundTag)
        {
            Destroy(this.gameObject);
            Instantiate(breakEffect);
        }

    }

    void GenerateEffect(GameObject gameObj)
    {
        GameObject effect = Instantiate(breakEffect) as GameObject;
        effect.transform.position = gameObj.transform.position;
    }
}
