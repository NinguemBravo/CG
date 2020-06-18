using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Música : MonoBehaviour
{
    public static Música instance { get; private set; }
private void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
