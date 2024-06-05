using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class resumescr : MonoBehaviour
{
    public GameObject backingameGameObject;
    public static bool ispaused;
    void Start()
    {
        backingameGameObject.SetActive(true);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
            {
                resumegame();
            }
            else
            {
                pausegame();
            }
        }
    }
    public void resumegame()
    {
        backingameGameObject.SetActive(false);
        Time.timeScale = 1f;
        ispaused = true;
    }
    public void pausegame()
    {
        backingameGameObject.SetActive(true);
        Time.timeScale = 0f;
        ispaused = false;
    }
}
