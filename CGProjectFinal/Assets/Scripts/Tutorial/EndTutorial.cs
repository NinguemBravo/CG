using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Game", 45.7f);
    }
    private void Game()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Quarto");
    }
}
