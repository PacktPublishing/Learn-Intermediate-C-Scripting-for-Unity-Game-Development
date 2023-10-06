using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueTutorial : MonoBehaviour
{

    public List<GameObject> itemList = new List<GameObject>();

    Queue<GameObject> items = new Queue<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            foreach( GameObject g in itemList)
            {

                items.Enqueue(g);
                g.SetActive(false);

            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject item = items.Dequeue();
            item.SetActive(true);
        }


        
    }
}
