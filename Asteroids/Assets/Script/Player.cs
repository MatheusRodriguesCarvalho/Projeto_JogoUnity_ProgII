using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public int life = 3;

    public GameObject bala;
    public Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal();
        Shoot();
        KeepInbounds();


    }

    public void MoveHorizontal()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(x, 0f, 0f);
    }

    public void Shoot()
    {

        if(Input.GetKeyDown("space"))
        {
            Instantiate(bala, transform.position, Quaternion.identity);
        }

    }

    public void KeepInbounds()
    {
        if (transform.position.x > 5.6f || transform.position.x < -5.6f)
        {
            float posx = Mathf.Clamp(transform.position.x, -5.6f, 5.6f);
            transform.position = new Vector3(posx, transform.position.y, transform.position.z);
        }
    }



}
