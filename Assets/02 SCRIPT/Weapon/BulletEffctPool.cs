using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEffctPool : MonoBehaviour
{
    public static BulletEffctPool instance;
    [SerializeField] GameObject bulletEffectPrefab;
    [SerializeField] int poolSize = 5;
    List<GameObject> listBulletEffect;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        listBulletEffect = new List<GameObject>();
        GrowPool(poolSize);
    }
    public void GrowPool(int size)
    {
        for (int i = 0; i < size; i++)
        {
            GameObject bulletEffect = Instantiate(bulletEffectPrefab);
            bulletEffect.SetActive(false);
            listBulletEffect.Add(bulletEffect);
        }
    }
    public GameObject GetBulletEffect()
    {
        for (int i = 0; i < listBulletEffect.Count; i++)
        {
            if (!listBulletEffect[i].activeInHierarchy)
            {
                listBulletEffect[i].SetActive(true);
                return listBulletEffect[i];
            }
        }
        GameObject bulletEffect = Instantiate(bulletEffectPrefab);
        bulletEffect.SetActive(false);
        listBulletEffect.Add(bulletEffect);
        return bulletEffect;

    }

    public void ReturnBulletEffect(GameObject bulletEffect)
    {
        bulletEffect.SetActive(false);
        listBulletEffect.Add(bulletEffect);
    }
}
