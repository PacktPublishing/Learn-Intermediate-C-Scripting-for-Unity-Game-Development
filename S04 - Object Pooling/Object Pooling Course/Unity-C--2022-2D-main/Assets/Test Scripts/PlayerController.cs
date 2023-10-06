using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{
    public class PlayerController : MonoBehaviour
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

            if (Input.GetMouseButtonDown(0))
            {
                //Shoot();

                //ShootFromPool();

                ShootFromPoolMultiple();
            }

        }


        void Shoot()
        {
            Instantiate(bullet, shootPoint.position, bullet.transform.rotation);
        }

        void ShootFromPool()
        {
            GameObject b = ObjectPool.instance.GetFromPool();
            b.transform.position = shootPoint.position;
            b.SetActive(true);

        }

        void ShootFromPoolMultiple()
        {
            GameObject b = ObjectPoolMultiple.instance.GetFromPool("PlayerBullet");
            b.transform.position = shootPoint.position;
            b.SetActive(true);
        }
    }



}

