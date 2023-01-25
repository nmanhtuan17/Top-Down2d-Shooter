using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterComponant : MonoBehaviour
{
    protected Vector2 inputMovement;
    protected PlayerCtrl playerCtrl;
    protected WeaponCtrl weaponCtrl;
    
    protected virtual void Start()
    {
        playerCtrl = GetComponent<PlayerCtrl>();
        weaponCtrl = FindObjectOfType<WeaponCtrl>();
    }

    protected virtual void Update()
    {
        HandleAbility();
    }
    
   protected virtual void HandleAbility()
   {
        InternalInput();
        HandleInput();
   }

    
    protected virtual void HandleInput()
   {

   }

    
    protected virtual void InternalInput()
   {
        inputMovement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
   }
}
