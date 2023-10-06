using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private void OnEnable()
    {
        Invoke("DestroyBullet", 2f);
    }


    // Start is called before the first frame update
    void Start()
    {
        //Invoke("DestroyBullet", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
    }

    void DestroyBullet()
    {

        //ObjectPool.instance.ReturnToPool(gameObject);
        ObjectPoolPro.instance.ReturnToPool("PlayerBullet", gameObject);
        gameObject.SetActive(false);
        //Destroy(gameObject);
    }

}
