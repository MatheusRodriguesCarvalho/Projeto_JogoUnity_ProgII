using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public Vector3 pos;
    public int x = 8;
    public int y = 4;
    public Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    public void replace()
    {
        int randomX = GenerateRandomEven(-8, 8);
        int randomY = GenerateRandomEven(-4, 4);
        transform.position = new Vector3(randomX, randomY, 0f);
    }

    public int GenerateRandomEven(int min, int max)
    {
        int number;
        do
        {
            number = Random.Range(min, max);
        } while (number %2 != 0);
        return number;
    }

}
