using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWeapon : MonoBehaviour
{
    [SerializeField] List<WeaponDataSO> WeaponToUses = new List<WeaponDataSO>();
    [SerializeField] Transform WeaponParent;

    private void Start()
    {
        
        EquipWeapon(WeaponToUses[Random.Range(0, 3)], WeaponParent);
    }
    void EquipWeapon(WeaponDataSO weapon, Transform weaponPos)
    {
        Instantiate(weapon.weaponPrefab, weaponPos).transform.parent = WeaponParent;
    }
}
