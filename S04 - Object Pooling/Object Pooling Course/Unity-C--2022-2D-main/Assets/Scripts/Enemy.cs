using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject bullet;
    public Transform shootPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootFromPoolPro();

        }
    }


    void ShootFromPoolPro()
    {
        GameObject b = ObjectPoolPro.instance.GetFromPool("EnemyBullet");
        b.transform.position = shootPoint.position;
        b.SetActive(true);
    }
}
