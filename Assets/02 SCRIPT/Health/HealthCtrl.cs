using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCtrl : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] float initialHealth = 10f;
    [SerializeField] float maxHealth = 10f;

    [Header("Setting")]
    [SerializeField] bool destroyObj;

    public float curentHealth;
    private void Awake()
    {
        curentHealth = initialHealth;
    }
    public void TakeDamage(int damage)
    {

    }

    private void Die()
    {

    }
    
    private void Revive()
    {

    }

    private void DestroyObj()
    {

    }
}
