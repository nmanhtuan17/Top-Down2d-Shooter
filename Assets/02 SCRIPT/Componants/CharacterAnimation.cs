using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : CharacterComponant
{
    public Animator anim;
    protected override void Start()
    {
        base.Start();
    }

    protected override void HandleAbility()
    {
        base.HandleAbility();
        HandleAnimation();
    }
    private void HandleAnimation()
    {
        if (inputMovement == Vector2.zero)
            anim.SetBool("IsRun", false);
        else
            anim.SetBool("IsRun", true); 
    }


}
