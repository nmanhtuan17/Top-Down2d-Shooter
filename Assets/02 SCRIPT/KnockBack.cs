using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    public static KnockBack instance;

    private Transform player;

    
    public float knockForce;
    public float knockTime;

    private void Awake() {
        instance = this;
    }
    private void Start() {
        
        
    }
    private void Update() {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy"){
            Rigidbody2D enemyRb = other.GetComponent<Rigidbody2D>();
            if (enemyRb != null)
            {
                enemyRb.isKinematic = false;
                Vector2 difference = enemyRb.transform.position - transform.position;
                enemyRb.AddForce(difference.normalized * knockForce, ForceMode2D.Impulse);
                StartCoroutine(KnockCo(enemyRb));
            }
        }
    }
    
    
    IEnumerator KnockCo(Rigidbody2D enemyRb)
    {
        if (enemyRb != null)
        {
            yield return new WaitForSeconds(knockTime);
            enemyRb.velocity = Vector2.zero;
            enemyRb.isKinematic = true;
        }
    }
}
