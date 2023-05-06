using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    float timeCount = 1.5f;
    void Start()
    {
        
    }

    
    void Update()
    {
        OnBecameInvisible();
    }
    
    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if(collision.tag == "Enemy")
    //     {
    //         GameObject effect = BulletEffctPool.instance.GetBulletEffect();
    //         effect.transform.position = transform.position;
    //     }
    // }
    
    void OnBecameInvisible()
    {
        timeCount -= Time.deltaTime;
        if(timeCount <= 0){
            BulletPoolCtrl.instance.ReturnBullet(gameObject);
            timeCount = 1.5f;
        }
            
    }

    
}
