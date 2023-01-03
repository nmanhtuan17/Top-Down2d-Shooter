using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCtrl : MonoBehaviour
{
    [SerializeField] GameObject Player;
    void Start()
    {
        
    }

    
    void Update()
    {
        FollowPlayer();
    }
    void FollowPlayer()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, -10);
    }
}
