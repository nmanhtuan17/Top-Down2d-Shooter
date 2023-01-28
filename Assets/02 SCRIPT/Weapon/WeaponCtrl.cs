using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCtrl : MonoBehaviour
{
    

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float FireForce = 40f;
    [SerializeField] Transform firePos;

    [SerializeField] float timeBTWFire = 0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        timeBTWFire += Time.deltaTime;
        if (Input.GetMouseButton(0) && timeBTWFire >= 0.1f)
        {
            Fire();
            timeBTWFire = 0f;
        }
    }
     
    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FireForce * firePos.up, ForceMode2D.Impulse);
        
        Destroy(bullet, 2f);
    }

    
}
