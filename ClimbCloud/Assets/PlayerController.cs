using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //LoadScene을 사용하는데 필요

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    float threshold = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //점프
        if (Input.GetMouseButtonDown(0) && this.rigid2D.velocity.y == 0)
        {
            this.animator.SetTrigger("JumpTrigger");
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        //좌우 이동
        int key = 0;
        if (Input.acceleration.x > this.threshold) key = 1;
        if (Input.acceleration.x < -this.threshold) key = -1;

        //플레이어의 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);
        //Debug.Log("x: " + transform.position.x + ", y: " + transform.position.y);
        
        //스피드 제한
        if (speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }
        else
        {
            speedx = this.maxWalkSpeed;
        }
        

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if (this.rigid2D.velocity.y == 0)
        {
            this.animator.speed = speedx / 2.0f;
        }
        else
        {
            this.animator.speed = 1.0f;
        }

        //this.animator.speed = speedx / 2.0f;

        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    //골 도착
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("ClearScene");
    }
}
