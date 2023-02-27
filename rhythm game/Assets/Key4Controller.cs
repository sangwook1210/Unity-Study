using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key4Controller : MonoBehaviour
{
    GameObject temp_key1;
    GameObject temp_key2;
    GameObject temp_key3;
    GameObject temp_key4;

    // Start is called before the first frame update
    void Start()
    {
        this.temp_key1 = GameObject.Find("temp key1");
        this.temp_key2 = GameObject.Find("temp key2");
        this.temp_key3 = GameObject.Find("temp key3");
        this.temp_key4 = GameObject.Find("temp key4");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && this.transform.position.x < 7)
        {
            if (this.transform.position.x == -1)
            {
                temp_key1.transform.Translate(new Vector3(-8, 0, 0));
            }
            else if (this.transform.position.x == 1)
            {
                temp_key2.transform.Translate(new Vector3(-8, 0, 0));
            }
            else if (this.transform.position.x == 3)
            {
                temp_key3.transform.Translate(new Vector3(-8, 0, 0));
            }
            else if (this.transform.position.x == 5)
            {
                temp_key4.transform.Translate(new Vector3(-8, 0, 0));
            }
            this.transform.Translate(new Vector3(2, 0, 0));
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && this.transform.position.x > -1)
        {
            this.transform.Translate(new Vector3(-2, 0, 0));
        }
    }
}
