using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] Slider healthBar;
    [SerializeField] TextMeshProUGUI healthNum;
    [SerializeField] Text timeText;
    [SerializeField] float timeInLevel;



    float minute, second;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealth();
        displayTime();
    }
    void UpdateHealth()
    {
        healthBar.value = Mathf.Lerp(healthBar.value,
            HealthCtrl.instance.curentHealth / HealthCtrl.instance.maxHealth, 10f * Time.deltaTime);

        if(HealthCtrl.instance.curentHealth >= 0)
        {
            healthNum.text = HealthCtrl.instance.curentHealth.ToString() +
                        "/" + HealthCtrl.instance.maxHealth.ToString();
        }


        
    }

    
    void displayTime()
    {
        if (timeInLevel <= 0)
        {
            Time.timeScale = 0;
        }
            
        
        timeInLevel -= Time.deltaTime;
        minute = Mathf.Floor(timeInLevel / 60f);
        second = timeInLevel % 60f;
        if(minute > 0)
        {
            timeText.text = Mathf.RoundToInt(minute).ToString() + ":" + Mathf.RoundToInt(second).ToString();
        }
        else
        {
            timeText.text = Mathf.RoundToInt(second).ToString();
        }

    }
}
