using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

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
        print(distance);
    }


}
