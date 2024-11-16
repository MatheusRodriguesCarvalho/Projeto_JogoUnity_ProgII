using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicles : MonoBehaviour
{

    //public GameObject[] lista;
    public int speed = -3;
    private float initialY = 0;
    private float cameraWidth = 0;
    private Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        cameraWidth = Camera.main.orthographicSize * Camera.main.aspect * 1.3f;
        initialY = transform.position.y;
    }
    void Update()
    {
        float move = speed * Time.deltaTime;
        transform.Translate(move, 0, 0);

    }

    void OnBecameInvisible()
    {
        transform.position = new Vector3(cameraWidth, initialY);
    }
}
