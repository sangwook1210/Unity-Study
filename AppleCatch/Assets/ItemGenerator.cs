using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;
    public GameObject bombPrefab;
    float span = 1.0f;  //积己 埃拜
    float delta = 0;
    int ratio = 2;  //气藕 积己 厚啦
    float speed = -0.03f;   //倡窍 加档

    void SetPosition(GameObject prefab)
    {
        GameObject item;
        int ran = Random.Range(0, 9);

        switch (ran)
        {
            case 0:
                item = Instantiate(prefab, new Vector3(1, 4, 1), prefab.transform.rotation);
                break;
            case 1:
                item = Instantiate(prefab, new Vector3(1, 4, 0), prefab.transform.rotation);
                break;
            case 2:
                item = Instantiate(prefab, new Vector3(1, 4, -1), prefab.transform.rotation);
                break;
            case 3:
                item = Instantiate(prefab, new Vector3(0, 4, 1), prefab.transform.rotation);
                break;
            case 4:
                item = Instantiate(prefab, new Vector3(0, 4, 0), prefab.transform.rotation);
                break;
            case 5:
                item = Instantiate(prefab, new Vector3(0, 4, -1), prefab.transform.rotation);
                break;
            case 6:
                item = Instantiate(prefab, new Vector3(-1, 4, 1), prefab.transform.rotation);
                break;
            case 7:
                item = Instantiate(prefab, new Vector3(-1, 4, 0), prefab.transform.rotation);
                break;
            default:
                item = Instantiate(prefab, new Vector3(-1, 4, -1), prefab.transform.rotation);
                break;
        }

        item.GetComponent<ItemController>().dropspeed = this.speed;
    }

    public void SetParameter(float span, float speed, int ratio)
    {
        this.span = span;
        this.speed = speed;
        this.ratio = ratio;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;

            int dice = Random.Range(0, 10);

            if (dice < this.ratio)
            {
                SetPosition(bombPrefab);
            }
            else
            {
                SetPosition(applePrefab);
            }
        }
    }
}
