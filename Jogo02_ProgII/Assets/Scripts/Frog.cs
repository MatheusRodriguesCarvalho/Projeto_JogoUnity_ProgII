using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class Frog : MonoBehaviour
{
    public Rigidbody2D body;
    public Vector3 target;
    public int points;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        target = new Vector3(0f, -4f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal();
        MoveVertical();
        MovementInbounds();
        transform.position = new Vector3(target.x, target.y, 0f);
    }
    public void MovementInbounds()
    {
        if (target.x > 9)
        {
            target.x -= 2f;
        }
        else if (target.x < -9)
        {
            target.x += 2f;
        }
        else if (target.y > 5)
        {
            target.y -= 2f;
        }
        else if (target.y < -5)
        {
            target.y += 2f;
        }
    }
    public void MoveHorizontal()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            target.x -= 2f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            target.x += 2f;
        }
    }
    public void MoveVertical()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            target.y += 2f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            target.y -= 2f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Vehicles"))
        {
            Vehicles vehicles = collision.GetComponent<Vehicles>();
            if (vehicles != null)
            {
                Debug.Log("Touched");
                Debug.Log(vehicles.transform.position.x);
                //Destroy(gameObject);
                //vehicles.StopMovement();
            }
        }
        else if(collision.gameObject.CompareTag("Fly"))
        {
            Fly fly = collision.GetComponent<Fly>();
            if(fly != null)
            {
                fly.replace();
                points += 1;
            }
        }
    }
}
