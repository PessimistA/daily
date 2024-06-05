using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class srclevels : MonoBehaviour
{

    
    public void level1()
    {
        SceneManager.LoadSceneAsync("before 1st page");
    }
    public void level2()
    {
        SceneManager.LoadSceneAsync("before 2nd page 1");
    }
    public void level3()
    {
        SceneManager.LoadSceneAsync("before 3rd page 2");
    }
    public void level4()
    {
        SceneManager.LoadSceneAsync("before 4th page 3");
    }
    public void level5()
    {
        SceneManager.LoadSceneAsync("before 5th page 4");
    }
    public void level6()
    {
        SceneManager.LoadSceneAsync("before 6th page 5");
    }
    public void back()
    {
        SceneManager.LoadSceneAsync("mainMenu");
    }

}