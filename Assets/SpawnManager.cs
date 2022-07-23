using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] m_SpawnPoints;
    public GameObject enemyPrefab;
    public GameObject spawnPrefab;
    public GameObject spawnPrefab2;
    Health spawnHealth1;
    Health spawnHealth2;

    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    public void SpawnObject1()
    {

        if (spawnHealth1.isAlive == true)
        {
            Instantiate(enemyPrefab, m_SpawnPoints[0].transform.position, Quaternion.identity);


            if (stopSpawning)
            {
                CancelInvoke("SpawnObject1");

            }
        }

    }

    public void SpawnObject2()
    {

        if (spawnHealth2.isAlive == true)
        {

            Instantiate(enemyPrefab, m_SpawnPoints[1].transform.position, Quaternion.identity);

            if (stopSpawning)
            {
                CancelInvoke("SpawnObject2");

            }
        }

    }
    void Awake()
    {
        spawnHealth1 = spawnPrefab.GetComponent<Health>();
        spawnHealth2 = spawnPrefab2.GetComponent<Health>(); 

    }

    // Start is called before the first frame update
    void Start()
    {
            SpawnNewEnemy();
            InvokeRepeating("SpawnObject1",spawnTime,spawnDelay);
           
            InvokeRepeating("SpawnObject2",spawnTime,spawnDelay);


    }

    void Update()
    {
    }


    void SpawnNewEnemy()
    {

            Instantiate(enemyPrefab, m_SpawnPoints[0].transform.position, Quaternion.identity);

    }

    // Update is called once per frame
    //void Update()
    
        
   
}
