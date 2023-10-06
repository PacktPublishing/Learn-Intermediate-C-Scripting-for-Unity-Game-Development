using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{



    [System.Serializable]
    public class Pool
    {
        public int poolCount;
        public GameObject poolObject;
        public string tag;
        public bool canGrow;

    }


    public class ObjectPoolMultiple : MonoBehaviour
    {
        public static ObjectPoolMultiple instance;

        public List<Pool> pools = new List<Pool>();

        Dictionary<string, Queue<GameObject>> objectPools = new Dictionary<string, Queue<GameObject>>();

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
            foreach(Pool pool in pools)
            {
                Queue<GameObject> q = new Queue<GameObject>();

                for(int i = 0; i < pool.poolCount; i++)
                {
                    GameObject obj = Instantiate(pool.poolObject);
                    obj.SetActive(false);

                    q.Enqueue(obj);
                }
                objectPools.Add(pool.tag, q);

            }


        }

        // Update is called once per frame
        void Update()
        {

        }

        public GameObject GetFromPool(string tag)
        {
            if(objectPools[tag].Count > 0)
            {
                GameObject obj = objectPools[tag].Dequeue();
                return obj;
            }
            else
            {
                return null;
            }

        }


        public void ReturnToPool(string tag, GameObject obj)
        {
            objectPools[tag].Enqueue(obj);

        }


    }

}

