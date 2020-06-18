using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance { get; private set; }

    public float energy, maxEnergy, hunger, maxHunger, xp, maxXp;
    public int money, level, day;

    public bool hasViolao, hasGuitar;
    public int isUsingOption = 1;

    public GameObject fadeObj;

    private void Awake()
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
    }

    private void Update()
    {
        energy = Mathf.Clamp(energy, 0, maxEnergy);
        hunger = Mathf.Clamp(hunger, 0, maxHunger);

        if (xp >= maxXp)
        {
            levelUp(level);
        }
       
    }

    public void loseEnergy(float e)
    {
        energy -= e;
    }
    public void gainEnergy(float e)
    {
        energy += e;
    }
    public void restoreMaxEnergy()
    {
        energy = maxEnergy;
    }

    public void loseHunger(float h)
    {
        hunger -= h;
    }
    public void gainHunger(float h)
    {
        hunger += h;
    }
    public void restoreMaxHunger()
    {
        hunger = maxHunger;
    }

    public void loseMoney(int m)
    {
        money -= m;
    }
    public void gainMoney(int m)
    {
        money += m;
    }

    public void gainXp(int x)
    {
        xp += x;
    }

    public void levelUp(int l)
    {
        switch (l)
        {
            case 0:
                money += 10;
                maxXp = 250;
                break;
            case 1:
                money += 15;
                maxXp = 250;
                break;
            case 2:
                money += 18;
                maxXp = 350;
                break;
            case 3:
                money += 20;
                maxXp = 450;
                break;
            case 4:
                money += 23;
                maxXp = 550;
                break;
            case 5:
                money += 24;
                maxXp = 650;
                break;
            case 6:
                money += 25;
                maxXp = 750;
                break;
            case 7:
                money += 26;
                maxXp = 850;
                break;
            case 8:
                money += 30;
                maxXp = 950;
                break;
            case 9:
                money += 50;
                maxXp = 2000;
                break;
        }
        level++;
        xp = 0;
    }

    public void dayForward()
    {
        day++;
        fadeObj.GetComponent<FadeIn>().fadein();
    }

    
}
