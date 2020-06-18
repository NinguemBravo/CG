using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatsCanvasScript : MonoBehaviour
{

   // public static StatsCanvasScript instance { get; private set; }

    [SerializeField]
    private Image energyBar, hungerBar, xpBar;
    [SerializeField]
    private TextMeshProUGUI moneyText, levelText, dayText;

   /* private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }*/

    void Start()
    {
        
    }

    
    void Update()
    {
        energyBar.fillAmount = (PlayerStats.instance.energy / PlayerStats.instance.maxEnergy);
        hungerBar.fillAmount = (PlayerStats.instance.hunger / PlayerStats.instance.maxHunger);
        xpBar.fillAmount = (PlayerStats.instance.xp / PlayerStats.instance.maxXp);
        moneyText.text = ""+ PlayerStats.instance.money;
        dayText.text = "Dia " + PlayerStats.instance.day;
        levelText.text = "" + PlayerStats.instance.level;
    }
}
