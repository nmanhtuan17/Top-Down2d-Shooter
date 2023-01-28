using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    public static EnemyCtrl instance;

    public float health = 3;

    [SerializeField] GameObject Player;
    [SerializeField] public float speed = 2.5f;
    float walkSpeed;
    [SerializeField] float atackSpeed = 5f;
    [SerializeField] float timeDelay = 3f;
    [SerializeField] float range = 1.5f;
    [SerializeField] Animator anim;

    Vector3 curentPos;


    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
        walkSpeed = speed;

        curentPos = transform.position;
    }

    void Update()
    {
        EnemyDead();
        followPlayer();

        //attack();
    }

    void followPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, (Vector2)Player.transform.position,
                                                walkSpeed * Time.deltaTime);
        

    }
    public void EnemyDead()
    {
        if (health <= 0)
            Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D otherCol)
    {
        if (otherCol.tag == "Bullet")
        {
            health--;
        }
        if(otherCol.tag == "Player")
        {
            StartCoroutine(atackPlayer());
        }
    }
    /*void attack()
    {
        
        
        if (Vector3.Distance(Player.transform.position, transform.position)  <= range)
        {
            
            StartCoroutine(atackPlayer());

        }
        
    }*/

    IEnumerator atackPlayer()
    {
        walkSpeed = atackSpeed;
        anim.SetBool("attack", true);
        yield return new WaitForSeconds(timeDelay);
        walkSpeed = speed;
        anim.SetBool("attack", false);
    }
}
