using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    public static EnemyCtrl instance;

    public float health;
    public float damage;
    public GameObject Player;
    public GameObject deathPref;
    public bool canMove = true;
    [SerializeField] float speed = 2.5f;
    [SerializeField] float atackSpeed = 5f;
    [SerializeField] float attackDelay = 3f;
    [SerializeField] Animator anim;
    private float walkSpeed;
    public CircleCollider2D circleCollider2D;


    private void OnEnable() {
        health = Random.Range(2f, 4f);
        circleCollider2D = GetComponent<CircleCollider2D>();
        circleCollider2D.enabled = true;
    }
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
        circleCollider2D = GetComponent<CircleCollider2D>();
        walkSpeed = speed;
        
    }

    void Update()
    {
        EnemyDead();
        followPlayer();
    }

    void followPlayer()
    {
        if(canMove){
            transform.position = Vector2.MoveTowards(transform.position, (Vector2)Player.transform.position,walkSpeed * Time.deltaTime);
        }
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
            health -= WeaponCtrl.instance.GetDamage();
            BulletPoolCtrl.instance.ReturnBullet(otherCol.gameObject);
        }
        if (otherCol.tag == "Player")
        {
            StartCoroutine(atackPlayerCo());
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player"){
            circleCollider2D.enabled = false;
            StartCoroutine(EnableCollider());
        }
    }


    
    IEnumerator atackPlayerCo()
    {
        walkSpeed = atackSpeed;
        anim.SetBool("attack", true);
        yield return new WaitForSeconds(attackDelay);
        walkSpeed = speed;
        anim.SetBool("attack", false);
    }
    IEnumerator EnableCollider(){
        yield return new WaitForSeconds(1f);
        circleCollider2D.enabled = true;
    }
}
