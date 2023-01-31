using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    Rigidbody2D _rb;
    public Vector2 currentMovement { get; set; }


    [SerializeField] float mapX, mapY;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        boundMove();
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
    void boundMove()
    {
        if(transform.position.x > mapX )
        {
            transform.position = new Vector3(mapX, transform.position.y, 0);
        }
        else if(transform.position.x < -mapX)
        {
            transform.position = new Vector3(-mapX, transform.position.y, 0);
        }
        else if (transform.position.y > mapY)
        {
            transform.position = new Vector3(transform.position.x, mapY, 0);
        }
        else if (transform.position.y < -mapY)
        {
            transform.position = new Vector3(transform.position.x, -mapY + 0.3f, 0);
        }
    }
}
