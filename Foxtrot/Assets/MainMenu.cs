using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject HelpMenu;
    public GameObject HelpMenu2;
    public void startGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Help1()
    {
        HelpMenu.SetActive(true);
    }

    public void Help2()
    {
        HelpMenu.SetActive(false);
        HelpMenu2.SetActive(true);
    }

    public void Finish()
    {
        HelpMenu2.SetActive(false);
    }
}
