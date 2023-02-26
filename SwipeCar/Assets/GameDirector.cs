using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    bool game_over = false;

    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if (length < 0)
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "게임 오버!";
            game_over = true;
        }
        else if (length < 0.3)
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "성공!";
        }
        else if (game_over == false)
        {
            this.distance.GetComponent<TextMeshProUGUI>().text = "목표 지점까지 " + length.ToString("F2") + "m";
        }
    }
}
