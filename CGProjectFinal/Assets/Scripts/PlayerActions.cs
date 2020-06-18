using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerActions : MonoBehaviour
{
    public float range = 4f;
    public GameObject rayCastReferencePosition;
    [SerializeField]
    private Image bgImage;
    [SerializeField]
    private TextMeshProUGUI nameText, actionText;

    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerStats.instance.xp == PlayerStats.instance.maxXp)
        {
            PlayerStats.instance.levelUp(PlayerStats.instance.level);
        }

        RaycastHit hit;
        if(Physics.Raycast(rayCastReferencePosition.transform.position, rayCastReferencePosition.transform.forward, out hit, range))
        {
            if (hit.transform.name == "Cama")
            {
                if (Input.GetButtonDown("Action") && PlayerStats.instance.hunger>=25)
                {
                    PlayerStats.instance.restoreMaxEnergy();
                    PlayerStats.instance.loseHunger(25);
                    PlayerStats.instance.dayForward();
                    
                    if (PlayerStats.instance.day>= 30)
                    {
                        SceneManager.LoadScene("Palco");
                    }
                }

                bgImage.gameObject.SetActive(true);
                nameText.gameObject.SetActive(true);
                nameText.text = "Cama";
                actionText.gameObject.SetActive(true);
                if(PlayerStats.instance.hunger >= 25)
                {
                    actionText.text = "Aperte E para dormir";
                }
                else
                {
                    actionText.text = "Aperte E para dormir - Precisa comer";
                }
                
            }
            else if (hit.transform.name == "PortaCozinha")
            {
                if (Input.GetButtonDown("Action"))
                {
                    SceneManager.LoadScene("Cozinha");
                }

                bgImage.gameObject.SetActive(true);
                nameText.gameObject.SetActive(true);
                nameText.text = "Cozinha";
                actionText.gameObject.SetActive(true);
                actionText.text = "Aperte E para interagir";
            }
            else if (hit.transform.name == "PortaTrabalho")
            {

                bgImage.gameObject.SetActive(true);
                nameText.gameObject.SetActive(true);
                nameText.text = "Trabalho";
                actionText.gameObject.SetActive(true);
                actionText.text = "Aperte E para interagir";

                if (Input.GetButtonDown("Action"))
                {
                    SceneManager.LoadScene("Cozinha_trabalho");
                }
            }
            else if (hit.transform.name == "PortaQuarto")
            {

                bgImage.gameObject.SetActive(true);
                nameText.gameObject.SetActive(true);
                nameText.text = "Quarto";
                actionText.gameObject.SetActive(true);
                actionText.text = "Aperte E para interagir";

                if (Input.GetButtonDown("Action"))
                {
                    SceneManager.LoadScene("Quarto");
                }
            }
            else if (hit.transform.name == "ViolaoVelho" && PlayerStats.instance.hunger> 10 && PlayerStats.instance.energy> 10)
            {
                if (Input.GetButtonDown("Action"))
                {
                    SceneManager.LoadScene("Quarto_treino_velho");
                }
                bgImage.gameObject.SetActive(true);
                nameText.gameObject.SetActive(true);
                nameText.text = "Violão velho";
                actionText.gameObject.SetActive(true);
                actionText.text = "Aperte E para treinar";
            }
            else if (hit.transform.name == "ViolaoBom" && PlayerStats.instance.hunger > 10 && PlayerStats.instance.energy > 10)
            {
                if (Input.GetButtonDown("Action"))
                {
                    SceneManager.LoadScene("Quarto_treino_bom");
                }
                bgImage.gameObject.SetActive(true);
                nameText.gameObject.SetActive(true);
                nameText.text = "Violão bom";
                actionText.gameObject.SetActive(true);
                actionText.text = "Aperte E para treinar";
            }
            else if (hit.transform.name == "Guitarra" && PlayerStats.instance.hunger > 10 && PlayerStats.instance.energy > 10)
            {
                if (Input.GetButtonDown("Action"))
                {
                    SceneManager.LoadScene("Quarto_treino_guitarra");
                }
                bgImage.gameObject.SetActive(true);
                nameText.gameObject.SetActive(true);
                nameText.text = "Guitarra";
                actionText.gameObject.SetActive(true);
                actionText.text = "Aperte E para treinar";
            }
            else if (hit.transform.name == "Computador" && PlayerStats.instance.hunger > 10 && PlayerStats.instance.energy > 10)
            {
                if (Input.GetButtonDown("Action"))
                {
                    SceneManager.LoadScene("Loja");
                }
                bgImage.gameObject.SetActive(true);
                nameText.gameObject.SetActive(true);
                nameText.text = "Computador";
                actionText.gameObject.SetActive(true);
                actionText.text = "Aperte E para usar";
            }
            else if (hit.transform.name == "Geladeira")
            {
                if (Input.GetButtonDown("Action") && PlayerStats.instance.money >= 4)
                {
                    PlayerStats.instance.gainHunger(Random.Range(5, 6));
                    PlayerStats.instance.loseMoney(4);
                }
                bgImage.gameObject.SetActive(true);
                nameText.gameObject.SetActive(true);
                nameText.text = "Geladeira";
                actionText.gameObject.SetActive(true);
                if(PlayerStats.instance.money >= 4)
                {
                    actionText.text = "Aperte E para comer ($4)";
                }
                else
                {
                    actionText.text = "Aperte E para comer ($4) - Sem dinheiro";
                }
                
            }

            else
            {
                bgImage.gameObject.SetActive(false);
                nameText.gameObject.SetActive(false);
                actionText.gameObject.SetActive(false);
            }
        }
        else
        {
            bgImage.gameObject.SetActive(false);
            nameText.gameObject.SetActive(false);
            actionText.gameObject.SetActive(false);
        }
    }
}
