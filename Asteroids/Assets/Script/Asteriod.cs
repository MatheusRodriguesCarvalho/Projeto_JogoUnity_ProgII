using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteriod : MonoBehaviour
{
    public float speed;
    public Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        SetBehavior();

        Destroy(gameObject, 4);
    }

    void Update()
    {
        
    }

    public void SetBehavior()
    {
        speed = Random.Range(-3f, -6f);
        body.velocity = new Vector2(0f, speed);
        body.angularVelocity = Random.Range(-200, 200);
    }

}
