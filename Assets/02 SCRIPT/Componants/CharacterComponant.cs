using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterComponant : MonoBehaviour
{
    protected float horizontalInput;
    protected float verticalInput;
    void Start()
    {
        
    }

    protected virtual void Update()
    {
        HandleAbility();
    }
    //input logic of each ability
   protected virtual void HandleAbility()
   {
        InternalInput();
   }

    //get the necassary input to perform our actions
    protected virtual void HandleInput()
   {

   }

    //get the main input to ctrl character
    protected virtual void InternalInput()
   {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
   }
}
