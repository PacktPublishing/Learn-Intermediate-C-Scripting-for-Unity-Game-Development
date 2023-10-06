using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{
    public class ObjectPool : MonoBehaviour
    {
        public static ObjectPool instance;

        public int poolCount;
        public GameObject poolObject;
        Queue<GameObject> pooledObjects = new Queue<GameObject>();

        public bool canGrow = false;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < poolCount; i++)
            {
                GameObject obj = Instantiate(poolObject);
                obj.SetActive(false);
                pooledObjects.Enqueue(obj);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }


        public GameObject GetFromPool()
        {
            if (pooledObjects.Count > 0)
            {
                return pooledObjects.Dequeue();
            }
            else if (canGrow)
            {
                GameObject obj = Instantiate(poolObject);
                //obj.SetActive(false);
                //pooledObjects.Enqueue(obj);

                return obj;
            }
            else
            {
                return null;
            }
        }

        public void ReturnToPool(GameObject obj)
        {
            pooledObjects.Enqueue(obj);

        }

    }

}

