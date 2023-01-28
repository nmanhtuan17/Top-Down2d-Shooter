using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCtrl : MonoBehaviour
{
    public static CamCtrl instance;
    [SerializeField] GameObject Player;
    float timeBTWFire = 0f;
    [SerializeField] float shakeVibrato = 10f;
    [SerializeField] float shakeRandomess = 0.1f;
    [SerializeField] float shakeTime = 0.01f;


    void Start()
    {
        
    }

    
    void Update()
    {
        FollowPlayer();
        timeBTWFire += Time.deltaTime;
        if (Input.GetMouseButton(0) && timeBTWFire >= 0.1f)
        {
            Shake();
            timeBTWFire = 0f;
        }
    }
    void FollowPlayer()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, -10);
    }
    public void Shake()
    {
        StartCoroutine(IEShake());
    }
    IEnumerator IEShake()
    {
        Vector3 currentPos = transform.position;
        for(int i = 0; i < shakeVibrato; i++)
        {
            Vector3 shakePos = currentPos + Random.onUnitSphere * shakeRandomess;
            yield return new WaitForSeconds(shakeTime);
            transform.position = shakePos;
        }
    }
}
