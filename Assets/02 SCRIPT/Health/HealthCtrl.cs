using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCtrl : MonoBehaviour
{
    public static HealthCtrl instance;


    
    public float curentHealth;
    public float maxHealth = 10;

    
    private void Awake()
    {
        instance = this;
        curentHealth = maxHealth;
    }
    private void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        curentHealth -= damage;
        if(curentHealth <= 0)
        {
            gameObject.SetActive(false);
            Time.timeScale = 0;
        }
    }
}
