using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    Vector2 border;
    Vector2 posSpawn;
    float timeCountDown;

    [SerializeField] float numOfEnemy;
    [SerializeField] GameObject enemyPrefab;
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
        numOfEnemy = Random.Range(3f, 5f);
        for(int i = 0; i < numOfEnemy; i++)
        {
            posSpawn = new Vector2(Random.Range(-border.x, border.x), Random.Range(-border.y, border.y));
            Instantiate(enemyPrefab, posSpawn, Quaternion.identity);
        }
        
        timeCountDown = Random.Range(3f, 4f);
    }
}
