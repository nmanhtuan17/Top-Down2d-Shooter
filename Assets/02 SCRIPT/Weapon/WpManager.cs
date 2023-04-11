using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WpManager : MonoBehaviour
{
    [SerializeField] List<GameObject> WeaponToUses = new List<GameObject>();
    [SerializeField] Transform WeaponParent;

    private void Start()
    {
        
        EquipWeapon(WeaponToUses[Random.Range(0, 3)], WeaponParent);
    }
    void EquipWeapon(GameObject weapon, Transform weaponPos)
    {
        Instantiate(weapon, weaponPos).transform.parent = WeaponParent;
    }
}
