using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    public static EnemyCtrl instance;

    public float health = 3;

    [SerializeField] GameObject Player;
    [SerializeField] public float speed = 2.5f;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        followPlayer();
        EnemyDead();
    }

    void followPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
    }
    public void EnemyDead()
    {
        if (health <= 0)
            Destroy(gameObject);
    }
}
