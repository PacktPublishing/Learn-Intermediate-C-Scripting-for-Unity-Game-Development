using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryTutorial : MonoBehaviour
{

    public Dictionary<string, int> scoreManger = new Dictionary<string, int>();

    Dictionary<int, string> inventory = new Dictionary<int, string>();


    public string playerName;

    // Start is called before the first frame update
    void Start()
    {

        scoreManger.Add("Raja", 50);
        scoreManger.Add("Goku", 30);
        scoreManger.Add("Peter", 40);


        print(scoreManger[playerName]);


        inventory.Add(1, "Helmet");
        inventory.Add(2, "Gun");
        inventory.Add(3, " Bullet");

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
