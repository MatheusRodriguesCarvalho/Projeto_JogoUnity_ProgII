using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{

    public float speed = 10;
    public float xDist = 0;
    public float yDist = 0;
    public float cameraWidth = 0;
    void Start()
    {
        Camera camera = Camera.main;
        cameraWidth = camera.orthographicSize * camera.aspect * 1.3f;
        xDist = cameraWidth / 5;
        yDist = camera.orthographicSize / 2;
    }

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal();
        MoveVertical();
    }
    public void MoveHorizontal()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-xDist, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(xDist, 0, 0);
        }
    }
    void MoveVertical()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, yDist, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0, -yDist, 0);
        }
    }
}
