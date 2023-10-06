using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTutorial : MonoBehaviour
{

    public List<string> collectedItems = new List<string>();

    public List<int> bonusPoints = new List<int>();


    // Start is called before the first frame update
    void Start()
    {

        collectedItems.Add("Gun");
        collectedItems.Add("Bullet");
        collectedItems.Add("Diamond");



        foreach(string item in collectedItems)
        {
            //print(item);
        }


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            bonusPoints.Add(Random.Range(0, 50));

            print("Number of Bonus Points : " +  bonusPoints.Count);

        }

        if (Input.GetKeyDown(KeyCode.R))
        {

            //bonusPoints.Clear();

            bonusPoints.RemoveAt(bonusPoints.Count - 1);

            print("Number of Bonus Points : " + bonusPoints.Count);
        }


        
    }
}
