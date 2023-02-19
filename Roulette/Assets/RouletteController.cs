using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (this.rotSpeed == 0)
            {
                this.rotSpeed = 10;
            }
            else if (this.rotSpeed == 10)
            {
                this.rotSpeed *= 0.96f;
            }
        }

        if (this.rotSpeed > 0.001 && this.rotSpeed < 10)
        {
            this.rotSpeed *= 0.96f;
        }
        else if (this.rotSpeed <= 0.001)
        {
            this.rotSpeed = 0;
        }

        //회전 속도만큼 룰렛을 회전
        transform.Rotate(0, 0, this.rotSpeed);
        //transform.Rotate(this.rotSpeed, 0, 0);
        //transform.Rotate(0, this.rotSpeed, 0);
    }
}
