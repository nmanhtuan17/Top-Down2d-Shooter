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

    [SerializeField] float x, y;
    Vector2 border;

    void Start()
    {
        
    }

    
    void Update()
    {
        border = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        FollowPlayer();
        limitCam();
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
    void limitCam()
    {
        if (border.x > x)
        {
            border.x = x;
        }
        else if (-border.x < -x)
        {
            border.x = -x + border.x;
        }
        else if (border.y > y)
        {
            border.y = y;
        }
        else if (-border.y < -y)
        {
            border.y = -y + border.y;
        }
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
