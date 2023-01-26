using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAim : MonoBehaviour
{
    [SerializeField] GameObject reticlePrefab;
    GameObject reticle;

    Vector2 mousePos;
    
    void Start()
    {
        Cursor.visible = false;
        reticle = Instantiate(reticlePrefab);
    }

    
    void Update()
    {
        GetMousePos();
        MoveReticle();
    }
    void GetMousePos()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    void MoveReticle()
    {
        reticle.transform.position = mousePos;
        reticle.transform.rotation = Quaternion.identity;
    }
}
