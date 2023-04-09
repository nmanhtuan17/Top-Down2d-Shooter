using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D otherCol)
    {
        if(otherCol.tag == "Enemy")
        {
            HealthCtrl.instance.TakeDamage(EnemyCtrl.instance.damage);
        }
    }
}
