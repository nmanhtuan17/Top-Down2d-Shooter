using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCtrl : MonoBehaviour
{
    
    
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float FireForce = 40f;
    [SerializeField] Transform firePos;

    [SerializeField] float timeBTWFire;
     float timeCount;
    void Start()
    {
        timeCount = timeBTWFire;
    }

    
    void Update()
    {
        timeCount -= Time.deltaTime;
        if (Input.GetMouseButton(0) && timeCount <= 0)
        {
            Fire();
            CamCtrl.instance.Shake();
            timeCount = timeBTWFire;
        }
    }
     
    void Fire()
    {
        GameObject bullet = BulletPoolCtrl.instance.GetBullet();
        bullet.transform.position = firePos.position;
        bullet.transform.rotation = firePos.rotation;
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FireForce * firePos.up, ForceMode2D.Impulse);
    }

    
}
