using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEffect : MonoBehaviour
{
    void Update()
    {
        StartCoroutine(Effect());
    }
    IEnumerator Effect()
    {
        if(gameObject.activeInHierarchy){
            yield return new WaitForSeconds(.5f);
            BulletEffctPool.instance.ReturnBulletEffect(gameObject);
        }
        
    }
}
