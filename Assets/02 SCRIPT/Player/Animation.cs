using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator anim;
    public PlayerCtrl playerCtrl;
    private void Start() {
        
        playerCtrl = GetComponent<PlayerCtrl>();
    }
    private void Update() {
        UpdateAnimation();
    }
    private void UpdateAnimation()
    {
        if (playerCtrl.movement == Vector2.zero)
            anim.SetBool("IsRun", false);
        else
            anim.SetBool("IsRun", true);
    }


}
