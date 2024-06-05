using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartbutinOldFashion : MonoBehaviour
{
    public void Gamescene1(string gameName)
    {
        SceneManager.LoadSceneAsync("GameScene");//1. bölümü tekrardan ekrana yükler
    }
    public void Gamescene2(string gameName)
    {
        SceneManager.LoadSceneAsync("GameScene");//2. bölümü tekrardan ekrana yükler
    }
    public void Gamescene3(string gameName)
    {
        SceneManager.LoadSceneAsync("GameScene");//3. bölümü tekrardan ekrana yükler
    }
    public void Gamescene4(string gameName)
    {
        SceneManager.LoadSceneAsync("GameScene");//4. bölümü tekrardan ekrana yükler
    }
    public void Gamescene5(string gameName)
    {
        SceneManager.LoadSceneAsync("GameScene");//5. bölümü tekrardan ekrana yükler
    }
    public void Gamescene6(string gameName)
    {
        SceneManager.LoadSceneAsync("GameScene");//6. bölümü tekrardan ekrana yükler
    }
}
