using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicles : MonoBehaviour
{

    //public GameObject[] lista;
    public int speed = -3;
    public float y = 0;
    public float cameraWidth = 0;
    void Start()
    {
        Camera camera = Camera.main;
        cameraWidth = camera.orthographicSize * camera.aspect * 1.3f;
        y = transform.position.y;
    }
    void Update()
    {
        float move = speed * Time.deltaTime;
        transform.Translate(move, 0, 0);

    }

    void OnBecameInvisible()
    {
        transform.position = new Vector3(cameraWidth, y);
    }
}
