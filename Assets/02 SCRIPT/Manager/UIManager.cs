using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] Slider healthBar;
    [SerializeField] TextMeshProUGUI healthNum;
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
        healthBar.value = Mathf.Lerp(healthBar.value,
            HealthCtrl.instance.curentHealth / HealthCtrl.instance.maxHealth, 10f * Time.deltaTime);

        healthNum.text = HealthCtrl.instance.curentHealth.ToString() + 
                        "/" + HealthCtrl.instance.maxHealth.ToString();
    }
}
