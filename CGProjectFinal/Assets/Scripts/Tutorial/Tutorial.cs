using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public GameObject exp;
    public GameObject money;
    public GameObject day;
    public GameObject energ;
    public GameObject hugry;
    public GameObject move;
    //private Animation Dawn;
    public GameObject AExp;
    public GameObject AMoney;
    public GameObject ADay;
    public GameObject AEnerg;
    public GameObject AHugry;
    public GameObject Anim;

    private void Start()
    {
        //Anim.GetComponent<Animator>().SetBool("goDown", false);
        Invoke("Day", 3f);
        Invoke("Money", 11f);
        Invoke("Hugry", 19f);
        Invoke("Energ", 27f);
        Invoke("Exp", 36f);

    }

    private void Day()
    {
        Destroy(day, 7.3f);
        ADay.SetActive(true);
        Destroy(ADay, 7.3f);
        day.GetComponent<Textonatela>().start = true;
    }

    private void Money()
    {
        AMoney.SetActive(true);
        Destroy(money, 7.3f);
        Destroy(AMoney, 7.3f);
        money.GetComponent<Textonatela>().start = true;
    }

    private void Hugry()
    {
        AHugry.SetActive(true);
        Destroy(hugry, 7.3f);
        Destroy(AHugry, 7.3f);
        hugry.GetComponent<Textonatela>().start = true;
    }

    private void Energ()
    {
        AEnerg.SetActive(true);
        Destroy(energ, 7.3f);
        Destroy(AEnerg, 7.3f);
        energ.GetComponent<Textonatela>().start = true;
    }

    private void Exp()
    {
        AExp.SetActive(true);
        Destroy(exp, 7.3f);
        Destroy(AExp, 7.3f);
        exp.GetComponent<Textonatela>().start = true;
    }

}
