using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public GameObject Fade;
    //private Animation Anim;
    private void Start()
    {
        Fade.SetActive(true);
        //Anim = Fade.GetComponent<Animation>();
        Invoke("Fades", 1f);
        //Anim.Play("FadeIn");
    }
    private void Fades()
    {
        Fade.SetActive(false);
    }

    public void fadein()
    {
        Fade.SetActive(true);
        Invoke("Fades", 1f);
    }
}
