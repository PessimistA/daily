using System.Collections;
using System.Collections.Generic;
using UnityEngine;//scrSignİn 
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scrSignİn : MonoBehaviour
{
    public void Back(string gameName)
    {
        SceneManager.LoadSceneAsync("openingScene");
    }
    public void ToMenu(string gameName)
    {
        SceneManager.LoadSceneAsync("mainMenu");
    }


}