using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Loja : MonoBehaviour
{
    [SerializeField]
    private GameObject botaoCompraViolao, botaoCompraGuitarra, textoPreçoViolao, textoPreçoGuitarra, japossuiViolao, japossuiGuitarra, botaoUsarViolaoVelho, botaoUsarViolaoBom, botaoUsarGuitarra;
    [SerializeField]
    private TextMeshProUGUI moneyText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       moneyText.text = "$ " + PlayerStats.instance.money;

        if (PlayerStats.instance.hasGuitar)
        {
            botaoCompraGuitarra.SetActive(false);
            textoPreçoGuitarra.SetActive(false);
            japossuiGuitarra.SetActive(true);
            botaoUsarGuitarra.SetActive(true);
        }

        if (PlayerStats.instance.hasViolao)
        {
            botaoCompraViolao.SetActive(false);
            textoPreçoViolao.SetActive(false);
            japossuiViolao.SetActive(true);
            botaoUsarViolaoBom.SetActive(true);
        }
    }

    public void buyViolao()
    {
        if (PlayerStats.instance.money >= 800)
        {
            PlayerStats.instance.hasViolao = true;
            PlayerStats.instance.money -= 800;

        }

    }
    public void buyGuitar()
    {
        if (PlayerStats.instance.money >= 1000)
        {
            PlayerStats.instance.hasGuitar = true;
            PlayerStats.instance.money -= 1000;
        }
    }

    public void usarInstrumento(int option)
    {
        PlayerStats.instance.isUsingOption = option;
    }

    public void Sair()
    {
        SceneManager.LoadScene("Quarto");
    }

}
