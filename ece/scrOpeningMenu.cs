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
    public void LogÝN()
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
        //yeniden baþlat tuþu iþlevi buraya
    }
    public void keepitGoing(string gameName)
    {
        //devam et tuþununun iþlevleri buraya
    }

}