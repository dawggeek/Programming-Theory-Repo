using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabs;
    public float spawnRangeX;
    public float spawnRangeY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObject", 0.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomObject()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY), 0);
        int index = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[index], spawnPos, prefabs[index].transform.rotation);
    }
}
