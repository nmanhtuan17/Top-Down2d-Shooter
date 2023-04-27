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
        limitCam();
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
        for (int i = 0; i < shakeVibrato; i++)
        {
            Vector3 shakePos = currentPos + Random.onUnitSphere * shakeRandomess;
            yield return new WaitForSeconds(shakeTime);
            transform.position = shakePos;
        }
    }
    public IEnumerator ShakeCamera(float duration, float magnitude)
    {
        Vector3 originalPosition = transform.localPosition;
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(originalPosition.x + x, originalPosition.y + y, originalPosition.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPosition;
    }

}
