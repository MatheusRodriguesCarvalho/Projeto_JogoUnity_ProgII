using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiclesSpawner : MonoBehaviour
{
    public GameObject vehicle;

    public int SpawnTime = 5;
    void Start()
    {
        //GetTimeSpawn();
        InvokeRepeating("CreateVehicle", SpawnTime, SpawnTime);

    }

    void GetTimeSpawn()
    {
        Vehicles car = GetComponent<Vehicles>();
        SpawnTime = (car.speed * -1) - 2;
    }

    void CreateVehicle()
    {
        var SpawnPoint = new Vector2(transform.position.x, transform.position.y);
        Instantiate(vehicle, SpawnPoint, Quaternion.identity);
    }

}
