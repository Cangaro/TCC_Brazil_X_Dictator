using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class QuitGame : MonoBehaviour
{
    public string Cena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StarGame()
    {
        SceneManager.LoadScene(Cena);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void quitGame()
    {
        //editor na unity
        UnityEditor.EditorApplication.isPlaying = false;
        //Jogo Compilado, tirar o comentário antes de compilar.
        
        //Application.Quit();

    }
}
