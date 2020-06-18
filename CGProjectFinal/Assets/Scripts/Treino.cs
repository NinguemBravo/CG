using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Treino : MonoBehaviour
{
    public float trainCooldown;
    [SerializeField]
    private int xpGain;
    private float lastTimeTrained;

    public GameObject xpText;
    public GameObject hungerText;
    public GameObject energyText;
    // Start is called before the first frame update
    void Start()
    {
        lastTimeTrained = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastTimeTrained >= trainCooldown)
        {
            PlayerStats.instance.loseHunger(6);
            PlayerStats.instance.loseEnergy(5);
            PlayerStats.instance.gainXp(xpGain);
            lastTimeTrained = Time.time;
            ShowXpText(xpGain);
            ShowHungerText(6);
            ShowEnergyText(5);
        }
        if (Input.GetButtonDown("Action") || PlayerStats.instance.energy <= 4 || PlayerStats.instance.hunger <= 5)
        {
            SceneManager.LoadScene("Quarto");
        }
    }
    void ShowXpText(int xp)
    {
        var xptext = Instantiate(xpText, transform.position, transform.rotation, transform);
        xptext.GetComponent<TextMesh>().text = "+" + xp + " xp";
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
