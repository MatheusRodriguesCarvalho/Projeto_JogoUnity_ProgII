using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Frog : MonoBehaviour
{

    public float speed = 5f;
    public float xDist = 0;
    public float yDist = 0;
    public Transform target;
    public Rigidbody2D body;

    public float cameraWidth = 0;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        cameraWidth = Camera.main.orthographicSize * Camera.main.aspect;
        xDist = cameraWidth * 3f / 12.5f;
        yDist = Camera.main.orthographicSize / 5f * 2f;
    }

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal();
        MoveVertical();
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    public void MoveHorizontal()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            target.Translate(-xDist, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            target.Translate(xDist, 0, 0);
        }
    }
    void MoveVertical()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            target.Translate(0, yDist, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            target.Translate(0, -yDist, 0);
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
