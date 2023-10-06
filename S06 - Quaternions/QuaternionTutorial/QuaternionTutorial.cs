using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionTutorial : MonoBehaviour
{

    public Transform target;
    public float slerpRatio;






    // Start is called before the first frame update
    void Start()
    {
        Quaternion rot = transform.rotation;

        Quaternion rot1 = Quaternion.Euler(0, 90, 0);

        transform.rotation = Quaternion.identity;














        Vector3 rot2 = new Vector3(0, 0, 45);


        //print(rot);
        //print(transform.rotation);
        //print(rot1);

        //transform.rotation = rot1;

        //transform.eulerAngles = rot2;
        //print(transform.eulerAngles);


        //Quaternion rot3 = Quaternion.Euler(0, 90, 0);
        //Quaternion rot4 = Quaternion.Euler(0, 0, 90);

        //transform.rotation = rot3 * rot4; // not same as rot4 * rot3

    }

    // Update is called once per frame
    void Update()
    {
       Vector3 direction  = target.position - transform.position;

        Quaternion targetRotation = Quaternion.LookRotation(direction);

        //transform.rotation = targetRotation;

        //transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, slerpRatio);



    }
}
