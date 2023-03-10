using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //프레임마다 등속으로 낙하
        transform.Translate(0, -0.1f, 0);

        //화면 밖으로 나오면 오브젝트 소멸
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            //감독 스크립트에 플레이어와 화살이 충돌했다고 전달
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();

            //충돌한 경우는 화살을 지운다
            Destroy(gameObject);
        }
    }
}
