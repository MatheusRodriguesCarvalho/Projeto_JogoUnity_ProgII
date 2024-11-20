using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteriodSpawner : MonoBehaviour
{
    public float spawnTime = 2;
    public GameObject Asteriod;
    void Start()
    {
        InvokeRepeating("spawnAsteriods", spawnTime, spawnTime);
    }

    void Update()
    {
        
    }

    void spawnAsteriods()
    {
        Renderer render = GetComponent<Renderer>();
        var x1 = transform.position.x - render.bounds.size.x / 2;
        var x2 = transform.position.x + render.bounds.size.x / 2;
        var spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        Instantiate(Asteriod, spawnPoint, Quaternion.identity);
    }

}
