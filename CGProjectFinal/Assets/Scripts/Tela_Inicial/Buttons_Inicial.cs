using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons_Inicial : MonoBehaviour
{
    //private Animation FadeOut;
    public GameObject Fade;
    private AudioSource Click;
    private void Start()
    {
        Click = GetComponent<AudioSource>();
        //FadeOut = Fade.GetComponent<Animation>();
    }
    public void Button_Play()
    {
        Click.Play();
        Invoke("MudarScene", 4f);
        Fade.SetActive(true);
        //FadeOut.Play("FadeOut");

    }
    private void MudarScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Quarto_Tutorial");
    }
    public void Button_Sair()
    {
        Click.Play();
        Invoke("Sair", 2f);
    }
    private void Sair()
    {
        Application.Quit();
        Debug.Log("Saiu");
    }
}
