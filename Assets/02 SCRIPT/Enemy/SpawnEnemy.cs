using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    float timeCountDown;
    float waveNumber = 0;
    Vector2 border;
    [SerializeField] GameObject enemyPrefab;
    
    [SerializeField] List<Vector2> posSpawns = new List<Vector2>();

    Vector2 posSpawn;
    [SerializeField] Vector2 randomPos;
    void Start()
    {
        border = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    
    void Update()
    {
        //Spawn Enemies
        timeCountDown -= Time.deltaTime;
        if (timeCountDown <= 0)
        {
            Spawn();
            
        }
            
        
    }

    void Spawn()
    {
        randomPos = new Vector2(Random.Range(0.1f, 0.5f), Random.Range(0.1f, 0.5f));
        posSpawn = new Vector2 (Random.Range(-border.x, border.x), Random.Range(-border.y, border.y));
        posSpawns.Add(posSpawn);

        Instantiate(enemyPrefab, posSpawns[Random.Range(0, posSpawns.Count)], Quaternion.identity);


        timeCountDown = Random.Range(2f, 2.5f);
    }
}
