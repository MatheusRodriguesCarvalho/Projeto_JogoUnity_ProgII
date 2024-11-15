using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicles : MonoBehaviour
{

    //public GameObject[] lista;
    public int speed = -3;
    public int x = 1;
    public float cameraWidth = 0;
    void Start()
    {
        Camera camera = Camera.main;
        cameraWidth = camera.orthographicSize * camera.aspect;
    }
    void Update()
    {
        float move = speed * Time.deltaTime;
        transform.Translate(move, 0, 0);

    }

    void OnBecameInvisible()
    {
        //speed = speed * -1;
        transform.position = new Vector3(cameraWidth, 0);
        //x = x * -1;
        //transform.localScale = new Vector3(x, 1, 1);
    }
}
