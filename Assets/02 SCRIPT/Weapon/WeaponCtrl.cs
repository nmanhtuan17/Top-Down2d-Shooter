using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCtrl : MonoBehaviour
{
    public static WeaponCtrl instance;
    [SerializeField] WeaponDataSO weaponData;
    [SerializeField] List<Transform> listFirePos = new List<Transform>();
    float timeCount;
    private void Awake() {
        instance = this;
    }
    void Start()
    {
        timeCount = weaponData.timeBTWFire;
    }


    void Update()
    {
        timeCount -= Time.deltaTime;
        if (Input.GetMouseButton(0) && timeCount <= 0)
        {
            Fire();
            CamCtrl.instance.Shake();
            timeCount = weaponData.timeBTWFire;
        }
    }
    public int GetDamage(){
        return weaponData.damage;
    }
    void Fire()
    {
        
        
        foreach (Transform firePos in listFirePos)
        {
            AudioManager.instance.PlaySFX(0);
            GameObject bullet = BulletPoolCtrl.instance.GetBullet();
            bullet.transform.position = firePos.position;
            bullet.transform.rotation = firePos.rotation;
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(weaponData.fireForce * firePos.up, ForceMode2D.Impulse);
        }
    }
}
