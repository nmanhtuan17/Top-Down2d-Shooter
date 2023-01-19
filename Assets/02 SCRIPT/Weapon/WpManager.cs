using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WpManager : CharacterComponant
{
    [SerializeField] List<WeaponCtrl> WeaponToUses = new List<WeaponCtrl>();
    [SerializeField] WeaponCtrl WeaponToUse;
    [SerializeField] Transform WeaponPos;

    protected override void Start()
    {
        base.Start();
        EquipWeapon(WeaponToUses[Random.Range(0, 1)], WeaponPos);
    }



    protected override void HandleAbility()
    {
        base.HandleAbility();
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

    }
    void Shoot()
    {

    }

    void EquipWeapon(WeaponCtrl weapon, Transform weaponPos)
    {
        Instantiate(weapon, weaponPos).transform.parent = WeaponPos;
    }
}
