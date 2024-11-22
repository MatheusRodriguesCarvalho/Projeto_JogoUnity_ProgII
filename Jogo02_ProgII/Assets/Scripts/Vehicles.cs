using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicles : MonoBehaviour
{
    public int speed = 0;
    private Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = new Vector3(speed, 0f, 0f);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    public void StopMovement()
    {
        speed = 0;
    }
}
