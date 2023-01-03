using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Image healthBar;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealth();
    }
    void UpdateHealth()
    {
        healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount,
            HealthCtrl.instance.curentHealth / HealthCtrl.instance.maxHealth, 10f * Time.deltaTime);
    }
}
