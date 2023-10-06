using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTutorial : MonoBehaviour
{

    Stack<string> items = new Stack<string>();

    Stack<char> reverser = new Stack<char>();

    public string Name = "RAJA";
    string newName = "";

    // RAJA == AJAR

    // Start is called before the first frame update
    void Start()
    {
        items.Push("Item 1");
        items.Push("Item 2");
        items.Push("Item 3");
        items.Push("Item 4");

        //print(items.Peek());

        


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            items.Pop();

            print(items.Peek());
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ReverseString();
        }

    }

    void ReverseString()
    {
        foreach (char c in Name)
        {
            reverser.Push(c);
        }

        //RAJA

        while (reverser.Count > 0)
        {
            newName += reverser.Pop();

            // "AJAR"

        }

        print(newName);
    }


}
