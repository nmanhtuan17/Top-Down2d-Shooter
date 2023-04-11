using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    Vector2 border;
    Vector2 posSpawn;
    [SerializeField] float mapX, mapY;
    float timeCountDown = 2f;

    [SerializeField] float numOfEnemy;
    [SerializeField] GameObject enemyPrefab;
    void Start()
    {
        
    }

    
    void Update()
    {
        border = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        
        timeCountDown -= Time.deltaTime;
        if (timeCountDown <= 0)
        {
            Spawn();
            timeCountDown = Random.Range(3f, 5f);
        }
        
    }

    void Spawn()
    {
        //numOfEnemy = Mathf.Floor(Random.Range(3f, 5f));
        for(int i = 0; i < numOfEnemy; i++)
        {
            posSpawn = new Vector2(Random.Range(-mapX, mapX), Random.Range(-mapY, mapY));
            GameObject enemy = EnemyPoolCtrl.instance.GetEnemy();
            enemy.transform.position = posSpawn;
        }
        
    }
}
