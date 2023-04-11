using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPoolCtrl : MonoBehaviour
{
    public static EnemyPoolCtrl instance;
    public GameObject enemyPrefab;
    public int enemyPoolSize;
    public List<GameObject> enemyPool;
    private void Awake() {
        instance = this;
    }
    void Start()
    {
        enemyPool = new List<GameObject>();
        GrowPool(enemyPoolSize);

    }

    
    void Update()
    {
        
    }
    public void GrowPool(int size)
    {
        for (int i = 0; i < size; i++)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.SetActive(false);
            enemyPool.Add(enemy);
        }
    }
    public GameObject GetEnemy()
    {
        foreach (GameObject enemy in enemyPool)
        {
            if (!enemy.activeInHierarchy)
            {
                enemy.SetActive(true);
                return enemy;
            }
        }
        GameObject newEnemy = Instantiate(enemyPrefab, transform);
        newEnemy.SetActive(false);
        enemyPool.Add(newEnemy);
        return newEnemy;
    }

    public void ReturnEnemy(GameObject enemy)
    {
        
        enemy.SetActive(false);
        enemyPool.Add(enemy);
    }
}
