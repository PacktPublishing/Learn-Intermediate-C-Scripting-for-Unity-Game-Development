using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{
    public class EnemyBullet : MonoBehaviour
    {
        public float bulletSpeed;


        private void OnEnable()
        {
            Invoke("DestroyBullet", 2f);
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(-transform.up * bulletSpeed * Time.deltaTime);
        }

        void DestroyBullet()
        {
            gameObject.SetActive(false);
            //ObjectPool.instance.ReturnToPool(gameObject);

            ObjectPoolMultiple.instance.ReturnToPool("EnemyBullet", gameObject);
        }
    }

}

