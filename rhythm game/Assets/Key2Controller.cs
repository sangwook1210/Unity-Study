using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key2Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && this.transform.position.x < 3)
        {
            this.transform.Translate(new Vector3(2, 0, 0));
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && this.transform.position.x > -5)
        {
            this.transform.Translate(new Vector3(-2, 0, 0));
        }
    }
}
