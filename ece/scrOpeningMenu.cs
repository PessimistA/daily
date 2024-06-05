using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrOpeningMenu : MonoBehaviour
{
    public void Signin(string gameName)
    {
        SceneManager.LoadSceneAsync("signinScene");
    }
    public void quitgame(string gameName)
    {
        Application.Quit();
    }
    public void Log�N()
    {
        SceneManager.LoadSceneAsync("loginScene");
    }
    public void ToMainMenu(string gameName)
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync("mainMenu");
    }
    public void aktarma()
    {
        SceneManager.LoadSceneAsync("forgetPassword");
    }
    public void Restart(string gameName)
    {
        //yeniden ba�lat tu�u i�levi buraya
    }
    public void keepitGoing(string gameName)
    {
        //devam et tu�ununun i�levleri buraya
    }

}