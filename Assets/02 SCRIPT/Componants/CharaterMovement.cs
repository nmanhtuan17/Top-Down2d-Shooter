using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterMovement : CharacterComponant
{
    [SerializeField] float speed = 6f;
    public float walkSpeed { get; set; }
    protected override void Start()
    {
        base.Start();
        walkSpeed = speed;
    }
    protected override void HandleAbility()
    {
        base.HandleAbility();
        CharacterMove();
    }
    private void CharacterMove()
    {
        playerCtrl.setMovement(inputMovement.normalized * walkSpeed);
    }

}
