using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

    public float speed;
    public Vector2 movement;
    Rigidbody2D _rb;


    [SerializeField] float mapX, mapY;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        boundMove();
    }
    void FixedUpdate()
    {
        Moving();
    }
    public void Moving(){
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        _rb.MovePosition(_rb.position + movement * speed * Time.fixedDeltaTime);
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
