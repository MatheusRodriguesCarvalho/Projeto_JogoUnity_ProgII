using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class Player : MonoBehaviour
{
    public float speed = 5;
    private int life = 5;

    public Text lifeUI;
    public GameObject bala;
    public Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        lifeUI.text = "Vidas: " + life;
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

    void OnTriggerEnter2D(Collider2D colisor)
    {

        if (colisor.gameObject.CompareTag("asteriodTag"))
        {
            life -= 1;
            lifeUI.text = "Vidas: " + life;
            if (life == 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("Menu");
            }
        }
    }



}
