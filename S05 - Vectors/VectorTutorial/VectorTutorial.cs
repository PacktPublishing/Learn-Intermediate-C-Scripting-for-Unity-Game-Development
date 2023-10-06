using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTutorial : MonoBehaviour
{

    public GameObject obj1;

    public GameObject obj2;

    public Vector3 test;

    // Start is called before the first frame update
    void Start()
    {

        // Cross Product
        // left hand rule

        

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 a = obj1.transform.up;
        Vector3 b = obj2.transform.forward;

        Vector3 c = Vector3.Cross(a, b);

        Debug.DrawRay(obj1.transform.position, a * 10f, Color.red);
        Debug.DrawRay(obj2.transform.position, b * 10f, Color.green);

        Debug.DrawRay(c, c * 10f, Color.blue);

    }
}
