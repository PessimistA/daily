using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ps5 : MonoBehaviour
{
    public void buttonpush()
    {
        SceneManager.LoadSceneAsync("before 5th page 4");
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
        SceneManager.LoadScene("Level5");
    }
}
