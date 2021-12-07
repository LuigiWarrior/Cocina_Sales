using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject DisplayPpal;
    public GameObject DisplayFases;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            DisplayPpal.SetActive(true);
        }
    }

    public void EscenaJuego(){
        SceneManager.LoadScene("Tutorial");
    }

    public void Salir(){
        Application.Quit();
    }


    public void SeleccionarFases()
    {
        DisplayPpal.SetActive(false);
        DisplayFases.SetActive(true);
    }

    public void SalirFases()
    {
        DisplayPpal.SetActive(true);
        DisplayFases.SetActive(false);
    }

    public void FaseTuto()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void FaseDiag()
    {
        SceneManager.LoadScene("Diagnostico");
    }
    public void Fase1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Fase2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Fase3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void Fase4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void RegresaMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Reanudar()
    {
        DisplayPpal.SetActive(false);
    }

}
