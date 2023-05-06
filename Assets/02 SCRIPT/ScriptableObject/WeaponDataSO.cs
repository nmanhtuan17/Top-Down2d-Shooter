using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "WeaponData", menuName = "Scriptable Object/Weapon Data")]
public class WeaponDataSO : ScriptableObject
{
    
    public int damage;
    public string weaponName;
    public float fireForce;
    public float timeBTWFire;
    public GameObject weaponPrefab;
}
