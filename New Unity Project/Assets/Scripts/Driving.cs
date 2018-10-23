using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driving : MonoBehaviour {

    public float velocity;
    public float acceleration;
    public float initVelocity;
    public float gravity;
    public Vector2 vGravity; // This will express gravity as a vector which will apply a force downwards
    public Vector2 vVelocity; // Express velocity as a vector that will change upon incline and declining gradients

	// Use this for initialization
	void Start () {
        vGravity = Vector2.down * gravity;
        vVelocity = Vector2.one * (velocity * gravity);
	}
	
	// Update is called once per frame
	void Update () {
       // acceleration = (velocity - initVelocity) / Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = ForceMode2D.Force(acceleration) = Vector2.Lerp(transform.position, transform.TransformPoint(Vector2.left), velocity * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = Vector2.Lerp(transform.position, transform.TransformPoint(Vector2.right), velocity * Time.deltaTime);
        }

    }
}
