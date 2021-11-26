using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject[] spawner;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        spawner = new GameObject[5];

        for (int i = 0; i < spawner.Length; i++)
        {
            spawner[i] = transform.GetChild(i).gameObject;
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnEnemy();
        }
    }
    void SpawnEnemy()
    {
        int spawnerID = Random.Range(0, spawner.Length);
        Instantiate(enemy, spawner[Random.Range(0, spawner.Length)].transform.position, spawner[Random.Range(0, spawner.Length)].transform.rotation);
    }
}
