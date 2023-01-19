using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCtrl : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float timeBtwShoot = 0.5f;
    [SerializeField] float FireForce = 40f;
    [SerializeField] Transform firePos;

    CharaterMovement CharactorMovement;
    [SerializeField] bool useRecoil = true;
    [SerializeField] float RecoilForce = 5f;
    void Start()
    {
        CharactorMovement = FindObjectOfType<CharaterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
        RotateWeapon();
    }
     void RotateWeapon()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - transform.position.y,
            mousePos.x - transform.position.x) * Mathf.Rad2Deg;

        // Rotate the weapon to the calculated angle
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FireForce * firePos.up, ForceMode2D.Impulse);
        Destroy(bullet, 2f);
    }

    
}
