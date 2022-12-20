using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    float timeSpawn;
    float timeCountDown;
    [SerializeField] GameObject enemyPrefab;
    Vector2 border;
    void Start()
    {
        border = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        timeSpawn = Random.Range(3f, 5f);
    }

    
    void Update()
    {
        timeCountDown -= Time.deltaTime;
        if (timeCountDown <= 0)
        {
            SpawnEnemy();
            timeCountDown = Random.Range(2f, 2.5f);
        }
            
            
        
    }

    void SpawnEnemy()
    {
         Vector2 posSpawn = new Vector2 (Random.Range(-border.x, border.x), Random.Range(-border.y, border.y));
        Instantiate(enemyPrefab, posSpawn, Quaternion.identity);
    }
    
}
