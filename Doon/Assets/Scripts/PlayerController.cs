using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float vx = 0;
    private float vz = 0;
    public float limit_x = 13.5f;
    public float limit_z = 7;
    public float speed = 30;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        vz = 0;

        if (Input.GetKey(KeyCode.LeftArrow) && this.transform.position.x > -limit_x)
        {
            vx = -speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && this.transform.position.x < limit_x)
        {
            vx = speed;
        }

        if (Input.GetKey(KeyCode.DownArrow) && this.transform.position.z > -limit_z)
        {
            vz = -speed;
        }
        else if (Input.GetKey(KeyCode.UpArrow) && this.transform.position.z < limit_z)
        {
            vz = speed;
        }

        this.transform.Translate(vx / 50, 0, vz/50);
    }

}
