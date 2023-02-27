using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    private int time = 0;
    private bool start = true;
    private bool bgm_start = true;
    GameObject Count_5;
    GameObject Count_4;
    GameObject Count_3;
    GameObject Count_2;
    GameObject Count_1;
    AudioSource bgm;

    // Start is called before the first frame update
    void Start()
    {
        Count_5 = GameObject.Find("countdown_5");
        Count_4 = GameObject.Find("countdown_4");
        Count_3 = GameObject.Find("countdown_3");
        Count_2 = GameObject.Find("countdown_2");
        Count_1 = GameObject.Find("countdown_1");

        Count_5.transform.Translate(new Vector3(-15, 0, 0));

        bgm = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        this.time += 1;

        if (start)  //게임 시작 시 카운트다운
        {
            if (this.time == 60)
            {
                Destroy(Count_5);
                Count_4.transform.Translate(new Vector3(-15, 0, 0));
            }
            else if (this.time == 120)
            {
                Destroy(Count_4);
                Count_3.transform.Translate(new Vector3(-15, 0, 0));
            }
            else if (this.time == 180)
            {
                Destroy(Count_3);
                Count_2.transform.Translate(new Vector3(-15, 0, 0));
            }
            else if (this.time == 240)
            {
                Destroy(Count_2);
                Count_1.transform.Translate(new Vector3(-15, 0, 0));
            }
            else if (this.time == 300)
            {
                Destroy(Count_1);
                this.time = 0;
                start = false;
            }
        }

        else    //카운트다운 종료 후 게임 시작
        {
            if (bgm_start)
            {
                bgm.Play();
                bgm_start = false;
            }
        }
    }
}
