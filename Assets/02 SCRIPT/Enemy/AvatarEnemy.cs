using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarEnemy : EnemyCtrl
{
    private void OnTriggerEnter2D(Collider2D otherCol)
    {
        if(otherCol.tag == "Bullet")
        {
            health--;
        }
    }
}
