using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Test
{
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
                //Shoot();

                //ShootFromPool();

                ShootFromPoolMultiple();
            }
        }


        void ShootFromPoolMultiple()
        {
            GameObject b = ObjectPoolMultiple.instance.GetFromPool("EnemyBullet");
            b.transform.position = shootPoint.position;
            b.SetActive(true);
        }
    }

}

