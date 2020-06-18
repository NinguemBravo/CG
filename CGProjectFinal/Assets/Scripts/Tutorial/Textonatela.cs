using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textonatela : MonoBehaviour
{
    public Text txt;
    public string texto;
    public bool start;
    private int cont = 0;
    //private Animation anim;
    private void Start()
    {
        start = false;
        //anim.GetComponent<Animation>();
    }
    private void Update()
    {
        if (start == true && cont == 0) {
            StartCoroutine(Ditado(texto));
            cont = 1;
        }
    }

    private IEnumerator Ditado(string frase)
    {
        //anim.Play();
        int letra = 0;
        txt.text = "";
        while (letra < frase.Length) {
            txt.text += frase[letra];
            letra += 1;
            yield return new WaitForSeconds(0.04f);
        }
    }
}
