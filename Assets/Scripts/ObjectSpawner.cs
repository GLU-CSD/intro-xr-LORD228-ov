using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnInterval = 25f;
    private float lastSpawnTime;
    void Start()
    {
        
    }

    void Update()
    {
        if (Time.time >= lastSpawnTime + spawnInterval)
        {
            SpawnObject();
            SpawnObject();
            SpawnObject();
            lastSpawnTime = Time.time;
        }
    }

    void SpawnObject()
    {
        if (objectToSpawn != null)
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
        }
        else
        {
            //Debug.LogWarning("Object to spawn is not set.");
        }
    }
}
