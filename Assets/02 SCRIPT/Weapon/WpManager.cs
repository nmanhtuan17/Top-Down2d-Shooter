using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WpManager : CharacterComponant
{
    [SerializeField] List<GameObject> WeaponToUses = new List<GameObject>();
    [SerializeField] Transform WeaponParent;

    protected override void Start()
    {
        base.Start();
        EquipWeapon(WeaponToUses[Random.Range(0, 3)], WeaponParent);
    }



    protected override void HandleAbility()
    {
        base.HandleAbility();
    }
    

    void EquipWeapon(GameObject weapon, Transform weaponPos)
    {
        Instantiate(weapon, weaponPos).transform.parent = WeaponParent;
    }
}
