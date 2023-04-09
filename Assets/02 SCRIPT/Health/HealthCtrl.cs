using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCtrl : MonoBehaviour
{
    public static HealthCtrl instance;


    
    public float curentHealth;
    public float maxHealth;

    public GameObject GameOver;
    private void Awake()
    {
        instance = this;
        curentHealth = maxHealth;
    }
    private void Update()
    {
        
    }
    public void TakeDamage(float damage)
    {
        curentHealth -= damage;
        if(curentHealth < 0)
        {
            gameObject.SetActive(false);
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
