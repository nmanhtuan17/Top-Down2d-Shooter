using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPoolCtrl : MonoBehaviour
{
    public static BulletPoolCtrl instance;
    public GameObject bulletPrefab;
    public int bulletPoolSize;
    private List<GameObject> bulletPool;
    private void Awake() {
        instance = this;
    }
    void Start()
    {
        bulletPool = new List<GameObject>();
        for (int i = 0; i < bulletPoolSize; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.SetActive(false);
            bulletPool.Add(bullet);
        }

    }

    
    void Update()
    {
        
    }

    public GameObject GetBullet()
    {
        for (int i = 0; i < bulletPoolSize; i++)
        {
            if (!bulletPool[i].activeInHierarchy)
            {
                bulletPool[i].SetActive(true);
                return bulletPool[i];
            }
        }
        GameObject newBullet = Instantiate(bulletPrefab, transform);
        newBullet.SetActive(false);
        bulletPool.Add(newBullet);
        return newBullet;
    }

    public void ReturnBullet(GameObject bullet)
    {
        bullet.SetActive(false);
        bulletPool.Add(bullet);
    }
}
