using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : CharacterComponant
{
    public Animator anim;
    protected override void HandleAbility()
    {
        base.HandleAbility();
        UpdateAnimation();
    }
    private void UpdateAnimation()
    {
        if (inputMovement == Vector2.zero)
            anim.SetBool("IsRun", false);
        else
            anim.SetBool("IsRun", true);
    }


}
