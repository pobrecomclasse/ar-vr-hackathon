using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDaSena;
    [SerializeField] private string senaVoltarMenu;
    [SerializeField] private GameObject painelInicial;

    public void Entrar()
    {
        SceneManager.LoadScene(nomeDoLevelDaSena);

    }

    public void Menu()
    {
            SceneManager.LoadScene(senaVoltarMenu);
        }
    public void Sair()
     {
            Application.Quit();
     }
}
