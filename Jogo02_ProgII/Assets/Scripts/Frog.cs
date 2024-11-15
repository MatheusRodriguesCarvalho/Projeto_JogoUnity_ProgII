using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{

    public float speed = 10;


    // Update is called once per frame
    void Update()
    {
        MoveHorizontal();

    }
    public void MoveHorizontal()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(move, 0, 0);
    }

}
