using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCtrl : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
}
