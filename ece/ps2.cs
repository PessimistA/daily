
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ps2 : MonoBehaviour
{
    public void buttonpush()
    {
        SceneManager.LoadSceneAsync("before 2nd page 1");
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
        SceneManager.LoadScene("Level2");
    }
}