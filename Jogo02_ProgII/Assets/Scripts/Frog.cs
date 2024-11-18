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
    public bool isdead = false; // verificar

    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        target = new Vector3(0f, -4f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isdead)
        {
            MoveHorizontal();
            MoveVertical();
            MovementInbounds();
            transform.position = new Vector3(target.x, target.y, 0f);
        }
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
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
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
        if (collision.CompareTag("Vehicles"))
        {
            Vehicles vehicles = collision.GetComponent<Vehicles>();
            if (vehicles != null)
            {
                Debug.Log("Touched");
                Debug.Log("Collision with: " + collision.gameObject.name);
                //Destroy(gameObject);
                vehicles.StopMovement();
                isdead = true;
            }
        }
        else if (collision.gameObject.CompareTag("Fly"))
        {
            Fly fly = collision.GetComponent<Fly>();
            if (fly != null)
            {
                fly.replace();
                points += 1;
            }
        }
    }
}
