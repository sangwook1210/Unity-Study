using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour
{
    GameObject key1;
    GameObject key2;
    GameObject key3;
    GameObject key4;
    string key1_keyboard = "q";
    string key2_keyboard = "w";
    string key3_keyboard = "e";
    string key4_keyboard = "r";
    Animator animator;
    float speed = 0.12f;    //note가 떨어지는 속도

    public void setSpeed(float speed)
    {
        this.speed = speed;
    }

    void Hit_Dectection(double note_position, double key_position, Animator anim)  //속도가 빨라지면 판정을 널널하게 해야할수도?
    {
        double distance = Math.Abs(note_position - key_position + 3.64);    //노트의 중심과 판정선 사이의 거리

        if (distance <= 0.11)
        {
            Debug.Log("perfect");
            setSpeed(0f);
            anim.SetTrigger("HitTrigger");
        }
        else if (distance <= 0.21)
        {
            Debug.Log("cool");
            setSpeed(0f);
            anim.SetTrigger("HitTrigger");
        }
        else if (distance <= 0.51)
        {
            Debug.Log("good");
            setSpeed(0f);
            anim.SetTrigger("HitTrigger");
        }
        else
        {
            Debug.Log("miss");
        }

        Debug.Log(distance);
        Debug.Log("note: " + note_position);
    }

    // Start is called before the first frame update
    void Start()
    {
        this.key1 = GameObject.Find("key1");
        this.key2 = GameObject.Find("key2");
        this.key3 = GameObject.Find("key3");
        this.key4 = GameObject.Find("key4");

        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed, 0);

        Vector2 note_pos = transform.position;
        Vector2 key1_pos = this.key1.transform.position;
        Vector2 key2_pos = this.key2.transform.position;
        Vector2 key3_pos = this.key3.transform.position;
        Vector2 key4_pos = this.key4.transform.position;

        if (note_pos.x - key1_pos.x < 0.5)  //만약 key1의 위치에 있다면
        {
            if (Input.GetKeyDown(key1_keyboard))    //key1의 키를 눌렀다면
            {
                Hit_Dectection(note_pos.y, key1_pos.y, this.animator);
            }
        }
        else if (note_pos.x - key2_pos.x < 0.5) //만약 key2의 위치에 있다면
        {
            if (Input.GetKeyDown(key2_keyboard))    //key2의 키를 눌렀다면
            {
                Hit_Dectection(note_pos.y, key2_pos.y, this.animator);
            }
        }
        else if (note_pos.x - key3_pos.x < 0.5) //만약 key3의 위치에 있다면
        {
            if (Input.GetKeyDown(key3_keyboard))    //key3의 키를 눌렀다면
            {
                Hit_Dectection(note_pos.y, key3_pos.y, this.animator);
            }
        }
        else if (note_pos.x - key4_pos.x < 0.5) //만약 key4의 위치에 있다면
        {
            if (Input.GetKeyDown(key4_keyboard))    //key4의 키를 눌렀다면
            {
                Hit_Dectection(note_pos.y, key4_pos.y, this.animator);
            }
        }
        //Debug.Log("x: " + note_pos.x + "y: " + note_pos.y);
        //Debug.Log("x: " + key1_pos.x + "y: " + key1_pos.y);


        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }
}
