using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LButtonDown()
    {
        if (transform.position.x > -9)
        {
            transform.Translate(-1, 0, 0);  //�������� 1 �̵�
        }
    }

    public void RButtonDown()
    {
        if (transform.position.x < 9)
        {
            transform.Translate(1, 0, 0);   //���������� 1 �̵�
        }
    }

    /*
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x > -9)
            {
                transform.Translate(-1, 0, 0);  //�������� 1 �̵�
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x < 9)
            {
                transform.Translate(1, 0, 0);   //���������� 1 �̵�
            }
        }

    }
    */
}
