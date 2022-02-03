using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    void Update()
    {
        audio.Play();
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("EscenaPrincipal");
    }

    public void salir()
    {
        Debug.Log("Salir..");
        Application.Quit();
    }
    

}
