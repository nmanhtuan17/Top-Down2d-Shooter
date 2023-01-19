using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterMovement : CharacterComponant
{
    [SerializeField] float speed = 5f;
    [SerializeField] float runSpeed = 10f;
    [SerializeField] float dashSpeed = 15f;
    [SerializeField] float dashTime, resetSpeed;

    public bool facingRight = false;
    public bool facingLeft = false;

    public enum FlipMode
    {
        MovementFlip,
        WeaponFlip
    }

    [SerializeField] FlipMode flipMode = FlipMode.MovementFlip;
    public float walkSpeed { get; set; }
    protected override void Start()
    {
        base.Start();
        walkSpeed = speed;
        resetSpeed = walkSpeed;
    }
    protected override void HandleAbility()
    {
        base.HandleAbility();
        CharacterMove();
        FlipCharacter();
    }
    protected override void HandleInput()
    {
        base.HandleInput();
        if (Input.GetKey(KeyCode.LeftShift))
        {
            RUN();
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            STOPRUN();
        }
    }
    private void CharacterMove()
    {
        if (Input.GetKeyDown(KeyCode.Space) && inputMovement != Vector2.zero)
        {
            StartCoroutine(Dash());
        }
        
        playerCtrl.setMovement(inputMovement.normalized * walkSpeed);
    }
    void RUN()
    {
        walkSpeed = runSpeed;
    }
    void STOPRUN()
    {
        walkSpeed = speed;
    }

    IEnumerator Dash()
    {
        walkSpeed = dashSpeed;
        yield return new WaitForSeconds(dashTime);
        walkSpeed = resetSpeed;
    }
    void FlipCharacter()
    {
        if(flipMode == FlipMode.MovementFlip)
        {
            Vector2 tmp = transform.localScale;
            if (inputMovement.x > 0)
            {
                tmp.x = 1;
                facingRight = true;
            }
            else if (inputMovement.x < 0)
            {
                tmp.x = -1;
                facingLeft = true;
            }
            transform.localScale = tmp;
        }
    }
       
}
