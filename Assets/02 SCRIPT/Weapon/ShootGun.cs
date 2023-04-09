using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    [SerializeField] List<Transform> listFirePos = new List<Transform>();
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float FireForce;
    //[SerializeField] Transform firePos;

    [SerializeField] float timeBTWFire;
    float timeCount;
    void Start()
    {
        timeCount = timeBTWFire;
    }


    void Update()
    {
        timeCount -= Time.deltaTime;
        if (Input.GetMouseButton(0) && timeCount <= 0)
        {
            Fire();
            CamCtrl.instance.Shake();
            timeCount = timeBTWFire;
        }
    }

    void Fire()
    {
        foreach(Transform firePos in listFirePos)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePos.position, firePos.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(FireForce * firePos.up, ForceMode2D.Impulse);
        }
        
    }
}
