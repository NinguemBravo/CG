using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrumentos : MonoBehaviour
{
    [SerializeField]
    private GameObject violaoVelho, violaoBom, guitarra;
    void Start()
    {
        if(PlayerStats.instance.isUsingOption == 1)
        {
            violaoVelho.SetActive(true);
            violaoBom.SetActive(false);
            guitarra.SetActive(false);
        }
        else if (PlayerStats.instance.isUsingOption == 2)
        {
            violaoVelho.SetActive(false);
            violaoBom.SetActive(true);
            guitarra.SetActive(false);
        }
        else if (PlayerStats.instance.isUsingOption == 3)
        {
            violaoVelho.SetActive(false);
            violaoBom.SetActive(false);
            guitarra.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
