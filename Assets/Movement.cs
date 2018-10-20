using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float velocity;
    public float acceleration;
    public float mass;
    public GameObject car;

    public float collisionAngle;


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

   void OnCollisionEnter(Collision collision)
    {

        float currentVelocity = (velocity / mass) * acceleration;

        Vector2 normal = collision.contacts[0].normal;
        collisionAngle = 90 - Vector2.Angle(transform.position, -normal);

        if (collisionAngle > 1.7)
        {
            transform.position = Vector2.Lerp(transform.position, transform.TransformPoint(Vector2.up), currentVelocity * Time.deltaTime);
        }


    }
}
