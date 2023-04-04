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


    public Vector2 minPos, maxPos;
    public Transform target;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        

        //FollowPlayer();
        limitCam();
        //timeBTWFire += Time.deltaTime;
        /*if (Input.GetMouseButton(0) && timeBTWFire >= 0.1f)
        {
            Shake();
            timeBTWFire = 0f;
        }*/
    }
    
    void limitCam()
    {
        float xPos = Mathf.Clamp(target.position.x, minPos.x, maxPos.x);
        float yPos = Mathf.Clamp(target.position.y, minPos.y, maxPos.y);

        transform.position = new Vector3(xPos, yPos, transform.position.z);
    }
    public void Shake()
    {
        StartCoroutine(IEShake());
    }
    public IEnumerator IEShake()
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
