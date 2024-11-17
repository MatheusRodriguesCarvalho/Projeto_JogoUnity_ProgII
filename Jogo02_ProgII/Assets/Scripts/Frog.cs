using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Frog : MonoBehaviour
{

    public float speed = 5f;
    public float xDist = 2;
    public float yDist = 2;

    public float smoothTime = 0.1f;
    private Vector3 velocity;

    public Rigidbody2D body;

    public float cameraWidth = 0;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        //cameraWidth = Camera.main.orthographicSize * Camera.main.aspect;
        //xDist = cameraWidth * 3f / 12.5f;
        //yDist = Camera.main.orthographicSize / 5f * 2f;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 targetPosition = transform.position + new Vector3(MoveHorizontal(), MoveVertical(), 0f) * speed;

        if (targetPosition.x > -7)
        {
            Debug.Log("dentro da tela");
            //transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
        else
        {
            Debug.Log("fora da tela");
        }

    }

    public float MoveHorizontal()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            return -xDist;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            return xDist;
        }
        else
        {
            return 0f;
        }
    }
    public float MoveVertical()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            return yDist;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            return -yDist;
        }
        else
        {
            return 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.CompareTag("Vehicles"))
        {
            Vehicles vehicles = collision.GetComponent<Vehicles>();
            if (vehicles != null)
            {
                Destroy(gameObject);
            }
        }

    }

}
