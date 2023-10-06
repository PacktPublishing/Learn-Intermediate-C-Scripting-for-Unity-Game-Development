using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed;

    private void OnEnable()
    {
        Invoke("DestroyBullet", 2f);
    }




    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
    }

    void DestroyBullet()
    {

        ObjectPoolPro.instance.ReturnToPool("EnemyBullet", gameObject);
        gameObject.SetActive(false);

    }
}
