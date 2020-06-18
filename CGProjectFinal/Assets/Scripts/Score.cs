using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerStats.instance.level == 10)
        {
            scoreText.text = "Após treinar bastante você conseguiu chegar no nivel " + PlayerStats.instance.level + " e fez uma apresentação perfeita!!";
        }
        else if (PlayerStats.instance.level >= 8)
        {
            scoreText.text = "Após treinar bastante você conseguiu chegar no nivel " + PlayerStats.instance.level + " e fez uma ótima apresentação!!";
        }
        else if (PlayerStats.instance.level >= 6)
        {
            scoreText.text = "No final você conseguiu chegar ao nivel " + PlayerStats.instance.level + " e fez uma boa apresentação!!";
        }
        else if (PlayerStats.instance.level >= 4)
        {
            scoreText.text = "No final você conseguiu chegar ao nivel " + PlayerStats.instance.level + " e fez uma apresentação mediana.";
        }
        else
        {
            scoreText.text = "No final seu nivel foi " + PlayerStats.instance.level + " e vocÊ acabou fazendo uma apresentação ruim.";
        }
    }

}
