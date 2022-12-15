using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    Rigidbody2D _rb;
    public Vector2 currentMovement { get; set; }
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        MOVING();
    }
    public void MOVING()
    {
        Vector2 currentMovePosition = _rb.position + currentMovement * Time.fixedDeltaTime;
        _rb.MovePosition(currentMovePosition);
    }
    public void setMovement(Vector2 newPosition)
    {
        currentMovement = newPosition;
    }
}
