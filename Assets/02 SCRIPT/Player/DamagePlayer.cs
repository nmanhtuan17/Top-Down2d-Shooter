using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCol)
    {
        if(otherCol.tag == "Enemy")
        {
            HealthCtrl.instance.TakeDamage(EnemyCtrl.instance.damage);
            //CamCtrl.instance.Shake();
            if(gameObject.activeInHierarchy){
                StartCoroutine(Camera.main.GetComponent<CamCtrl>().ShakeCamera(0.1f, 0.1f));
            }
        }
    }
}
