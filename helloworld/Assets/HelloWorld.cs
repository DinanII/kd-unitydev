using System.Collections;
using System.Collections.Generic;
using UnityEngine; // Unity specific utilities

// Objects are called "GameObjects" in Unity
public class HelloWorld : MonoBehaviour // So we can put HelloWorld on Unity object.
{
    [SerializeField] private float speed = 10.5f; // Will be overwritten by the value in the inspector
    [SerializeField] private Vector3 vector;

    // Variables default private
    // Serialize is an Attribute. Dont do anything, acts as a mark. So Unity will show them at cmp.
    // Can be edited whilst program is running.
    // Start is called before the first frame update (When GameObject is spawned)
    void Start()
    {
        Debug.Log("Hello World!");
	print("Hello World, but a shorthand in Python syntax.");
	print($"Cube speed: {speed}");
	transform.position = vector; // Teleports to vector.
    }	

    // Update is called once per frame (Logics and rendering, NOT for moving)
    void Update()
    {
        // Beweeg de kubus langzaam naar rechts
	    transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
