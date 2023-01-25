using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WpManager : CharacterComponant
{
    [SerializeField] List<WeaponCtrl> WeaponToUses = new List<WeaponCtrl>();
    [SerializeField] Transform WeaponParent;

    protected override void Start()
    {
        base.Start();
        EquipWeapon(WeaponToUses[Random.Range(0, 2)], WeaponParent);
    }



    protected override void HandleAbility()
    {
        base.HandleAbility();
    }
    

    void EquipWeapon(WeaponCtrl weapon, Transform weaponPos)
    {
        Instantiate(weapon, weaponPos).transform.parent = WeaponParent;
    }
}
