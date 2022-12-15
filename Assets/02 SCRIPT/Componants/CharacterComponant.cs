using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterComponant : MonoBehaviour
{
    protected Vector2 inputMovement;
    protected PlayerCtrl playerCtrl;

    protected virtual void Start()
    {
        playerCtrl = GetComponent<PlayerCtrl>();
    }

    protected virtual void Update()
    {
        HandleAbility();
    }
    //input logic of each ability
   protected virtual void HandleAbility()
   {
        InternalInput();
        HandleInput();
   }

    //get the necassary input to perform our actions
    protected virtual void HandleInput()
   {

   }

    //get the main input to ctrl character
    protected virtual void InternalInput()
   {
        inputMovement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
   }
}
