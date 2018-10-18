using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float velocity;
    public float acceleration;
    public float mass;
    public Rigidbody cube;


    // Use this for initialization
    void Start () {

        cube = GetComponent<Rigidbody>();
        cube.mass = mass;
        
	}
	
	// Update is called once per frame
	void Update () {

        float currentVelocity = (velocity / mass) * acceleration;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = Vector3.Lerp(transform.position, transform.TransformPoint(Vector3.left), currentVelocity * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = Vector3.Lerp(transform.position, transform.TransformPoint(Vector3.right), currentVelocity * Time.deltaTime);
        }


    }
}
