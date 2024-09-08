using System;
using System.Collections;
using System.Collections.Generic;
//using System.Numerics;

//using System.Numerics;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    [SerializeField] GameObject otherCubeObject;
    // Start is called before the first frame update
    void Start()
    {
        otherCubeObject = GameObject.Find("Cube2");
        
        
    }

    // Update is called once per frame
    void Update()
    {

        
        double difX = otherCubeObject.transform.position.x - transform.position.x;
        double difY = otherCubeObject.transform.position.y - transform.position.y;
        double difZ = otherCubeObject.transform.position.z - transform.position.z;

        double pythagoras = difX = Math.Pow(difX,2)+Math.Pow(difY,2) + Math.Pow(difZ,2);
        double distance = Math.Sqrt(pythagoras);
        print($"Distance between cubes: {distance}");

        // Dot product. Gives information about the orientation about two objects.
        Vector3 forwardA = transform.forward;
        Vector3 forwardB = otherCubeObject.transform.forward;
        float dotProduct = Vector3.Dot(forwardA.normalized, forwardB.normalized);

        print($"Dot Product: {dotProduct}");
        
        if (dotProduct >= 0.5f && dotProduct <= 1f)
        {
            print("Objects (almost) are almost looking into the same direction.");
        }
        else
        {
            print("Objects are not looking into the same direction");
        }
    }


}
