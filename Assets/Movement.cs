using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float velocity;
    public float acceleration;
    public float mass;
    public GameObject car;


    // Use this for initialization
    void Start () {

        acceleration = 9.8f;
	}
	
	// Update is called once per frame
	void Update () {

        float currentVelocity = (velocity / mass) * acceleration;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = Vector2.Lerp(transform.position, transform.TransformPoint(Vector2.left), currentVelocity * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = Vector2.Lerp(transform.position, transform.TransformPoint(Vector2.right), currentVelocity * Time.deltaTime);
        }


    }
}
