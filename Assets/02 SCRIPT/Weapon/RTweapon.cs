using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTweapon : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] SpriteRenderer avt;
    private void Start()
    {
        
    }
    private void Update()
    {

        RotateWeapon();
    }
    void RotateWeapon()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - transform.position.y,
                mousePos.x - transform.position.x) * Mathf.Rad2Deg;


        transform.rotation = Quaternion.Euler(0, 0, angle);
        if (angle < -90 || angle > 90)
        {
            if (Player.transform.eulerAngles.y == 0)
            {
                transform.localRotation = Quaternion.Euler(180, 0, -angle);
                avt.flipX = true;
            }
            else if (Player.transform.eulerAngles.y == 180)
            {
                transform.localRotation = Quaternion.Euler(180, 180, -angle);
            }
            
        }
        else
        {
            avt.flipX = false;
        }
    }
}
