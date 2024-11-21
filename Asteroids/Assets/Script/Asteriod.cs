using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteriod : MonoBehaviour
{
    public float speed;
    public Rigidbody2D body;
    private PointsScript ptScript;
    void Start()
    {
        ptScript = GameObject.Find("Pontuacao").GetComponent<PointsScript>();
        body = GetComponent<Rigidbody2D>();
        SetBehavior();

        Destroy(gameObject, 4);
    }

    public void SetBehavior()
    {
        speed = Random.Range(-3f, -6f);
        body.velocity = new Vector2(0f, speed);
        body.angularVelocity = Random.Range(-200, 200);
    }

    private void OnTriggerEnter2D(Collider2D colisor)
    {
        if(colisor.gameObject.CompareTag("bulletTag"))
        {
            Destroy(gameObject);
            ptScript.points ++;
        }

    }

}
