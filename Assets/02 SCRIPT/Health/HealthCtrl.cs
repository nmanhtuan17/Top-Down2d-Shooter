using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCtrl : MonoBehaviour
{
    public static HealthCtrl instance;
    [Header("Health")]
    [SerializeField] float initialHealth = 10f;
    [SerializeField] float maxHealth = 10f;

    [Header("Setting")]
    [SerializeField] bool destroyObj;

    [SerializeField] float curentHealth;
    private void Awake()
    {
        instance = this;
        curentHealth = initialHealth;
    }
    private void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        if(curentHealth <= 0)
            return;
        curentHealth -= damage;
        if(curentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
    
    private void Revive()
    {

    }
}
