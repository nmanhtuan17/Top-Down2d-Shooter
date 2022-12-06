using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D _rb;
    Vector2 movement;
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
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        _rb.velocity = movement * speed * Time.deltaTime;
    }
}
