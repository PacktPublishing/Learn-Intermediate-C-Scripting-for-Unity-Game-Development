using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public static ObjectPool instance;

    public GameObject poolObject;
    public int poolCount;

    Queue<GameObject> pooledObjcts = new Queue<GameObject>();


    public bool canGrow = false;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 0; i < poolCount; i++)
        {
            GameObject obj = Instantiate(poolObject);
            obj.SetActive(false);

            pooledObjcts.Enqueue(obj);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public GameObject GetFromPool()
    {
        if(pooledObjcts.Count > 0)
        {
            GameObject o = pooledObjcts.Dequeue();
            return o;
        }
        else if (canGrow)
        {
            GameObject obj = Instantiate(poolObject);
            
            //obj.SetActive(false);
            //pooledObjcts.Enqueue(obj);

            return obj;
        }

        else
        {
            return null;
        }

    }

    public void ReturnToPool(GameObject obj)
    {

        pooledObjcts.Enqueue(obj);

    }



}
