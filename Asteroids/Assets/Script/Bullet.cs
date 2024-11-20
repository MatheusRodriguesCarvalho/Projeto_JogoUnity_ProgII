using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        //Move();

    }

    public void Move()
    {
        body.velocity = new Vector2(0, speed);
    }

    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
