using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class sorting : MonoBehaviour
{
    public TextMeshProUGUI textBox1;
    public TextMeshProUGUI textBox2;
    public TextMeshProUGUI textBox3;
    public TextMeshProUGUI textBox4;


    //public void name1()// this is not working because it is a method and not active when game is on
    //{
    //    textBox1.text = string.Format("");
    //}
    float[] times= new float[20];//
    public TextMeshProUGUI timer1;
    public TextMeshProUGUI timer2;
    public TextMeshProUGUI timer3;
    public TextMeshProUGUI timer4;
    public UnityEngine.UI.Button buttonstabil1;
    public UnityEngine.UI.Button buttonstabil2;
    public UnityEngine.UI.Button button2;
    public UnityEngine.UI.Button button3;
    public UnityEngine.UI.Button buttonforward;
    

    private void Update()// this works when game is on make changes on here and the letters will change
    {
        textBox1.text = string.Format("");
        textBox2.text = string.Format("");
        textBox3.text = string.Format("");
        textBox4.text = string.Format("");
  
        // for timers
        timer1.text = string.Format("");//
        timer2.text = string.Format("");
        timer3.text = string.Format("");
        timer4.text = string.Format("");

         
        button2.onClick.RemoveAllListeners();
        button2.onClick.AddListener(forward2ndpage);
        buttonforward.onClick.RemoveAllListeners();
        buttonforward.onClick.AddListener(forward2ndpage);
        button3.onClick.RemoveAllListeners();   
        button3.onClick.AddListener(forward3ndpage);
        
    }
    public void forward2ndpage()
    {
        SceneManager.LoadSceneAsync("2.nd");
        
    }
    public void forward3ndpage()
    {
        SceneManager.LoadSceneAsync("3.rd");

    }
    public void stabil()
    {
        this.buttonstabil1.enabled = false;
        this.buttonstabil2.enabled = false;
    }


}
