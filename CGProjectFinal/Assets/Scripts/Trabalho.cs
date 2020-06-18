using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trabalho : MonoBehaviour
{
    
    public float workCooldown;
    private float lastTimeWorked;

    public GameObject moneyText;
    public GameObject hungerText;
    public GameObject energyText;

    // Start is called before the first frame update
    void Start()
    {
        lastTimeWorked = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastTimeWorked >= workCooldown)
        {
            int hungerlost = Random.Range(1, 5);
            int energylost = Random.Range(1, 5);
            PlayerStats.instance.loseHunger(hungerlost);
            PlayerStats.instance.loseEnergy(energylost);
            PlayerStats.instance.gainMoney(5);
            ShowMoneyText(5);
            ShowHungerText(hungerlost);
            ShowEnergyText(energylost);
            lastTimeWorked = Time.time;
        }
        if (Input.GetButtonDown("Action") || PlayerStats.instance.energy <= 0)
        {
            SceneManager.LoadScene("Cozinha");
        }
    }
    void ShowMoneyText(int xp)
    {
        var moneytext = Instantiate(moneyText, transform.position, transform.rotation, transform);
        moneytext.GetComponent<TextMesh>().text = "+ $" + xp;
        //xptext.GetComponent<TextMesh>().color = new Color(84, 255, 0);
    }
    void ShowHungerText(int xp)
    {
        var hungertext = Instantiate(hungerText, transform.position - new Vector3(0, 1.6f, 0), transform.rotation, transform);
        hungertext.GetComponent<TextMesh>().text = "- " + xp + " fome";
        //hungertext.GetComponent<TextMesh>().color = new Color(231, 154, 71);
    }
    void ShowEnergyText(int xp)
    {
        var energytext = Instantiate(energyText, transform.position - new Vector3(0, 3.2f, 0), transform.rotation, transform);
        energytext.GetComponent<TextMesh>().text = "- " + xp + " energia";
        //energytext.GetComponent<TextMesh>().color = new Color(66, 193, 229);
    }
}
