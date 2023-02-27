using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note3Controller : MonoBehaviour
{
    //GameObject note;
    float speed = 0.3f;

    public void setSpeed(float speed)
    {
        this.speed = speed;
    }

    // Start is called before the first frame update
    void Start()
    {
        //this.note = GameObject.Find("normal note");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
    }
}
