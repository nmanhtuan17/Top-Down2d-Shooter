using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    


    public static EnemyCtrl instance;

    public float health;
    public float damage;
    public GameObject Player;
    [SerializeField] public float speed = 2.5f;
    float walkSpeed;
    [SerializeField] float atackSpeed = 5f;
    [SerializeField] float timeDelay = 3f;
    [SerializeField] float range = 1.5f;
    [SerializeField] Animator anim;


    Vector3 curentPos;



    public GameObject deathPref;




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
    }

    void followPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, (Vector2)Player.transform.position,
                                                walkSpeed * Time.deltaTime);


    }
    public void EnemyDead()
    {

        if (health <= 0)
        {
            EnemyPoolCtrl.instance.ReturnEnemy(gameObject);
            Instantiate(deathPref, transform.position, transform.rotation);
        }

    }
    private void OnTriggerEnter2D(Collider2D otherCol)
    {
        if (otherCol.tag == "Bullet")
        {
            health--;
            BulletPoolCtrl.instance.ReturnBullet(otherCol.gameObject);
        }
        if (otherCol.tag == "Player")
        {
            StartCoroutine(atackPlayer());
        }
    }

    IEnumerator atackPlayer()
    {
        walkSpeed = atackSpeed;
        anim.SetBool("attack", true);
        yield return new WaitForSeconds(timeDelay);
        walkSpeed = speed;
        anim.SetBool("attack", false);
    }
}
