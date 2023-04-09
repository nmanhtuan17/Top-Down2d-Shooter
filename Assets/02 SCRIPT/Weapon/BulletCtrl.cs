using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    public GameObject bulletEffect;
    float timeCount = 1.5f;
    void Start()
    {
        
    }

    
    void Update()
    {
        OnBecameInvisible();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Instantiate(bulletEffect, transform.position, Quaternion.identity);
            
        }
    }

    void OnBecameInvisible()
    {
        timeCount -= Time.deltaTime;
        if(timeCount <= 0){
            BulletPoolCtrl.instance.ReturnBullet(gameObject);
            timeCount = 1.5f;
        }
            
    }
}
