using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }// bir cisim atanýp onu alma script ekleyip true olduðunda bu alt kýsým aktif olabilir

    public float targetTime = 5.0f;
    void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f)
        {
            timerended();
        }
    }
    void timerended()
    {
        SceneManager.LoadScene("1stwinscene");
    }
}
