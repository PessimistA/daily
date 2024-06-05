using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ps3 : MonoBehaviour
{
    public void buttonpush()
    {
        SceneManager.LoadSceneAsync("before 3rd page 2");
    }
    public float targetTime = 5.0f;
    public void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f)
        {
            timerended();
        }
    }
    void timerended()
    {
        SceneManager.LoadScene("Level3");
    }
}