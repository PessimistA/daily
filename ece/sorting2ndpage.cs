using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sorting2ndpage : MonoBehaviour
{
    public TextMeshProUGUI textBox5;
    public TextMeshProUGUI textBox6;
    public TextMeshProUGUI textBox7;
    public TextMeshProUGUI textBox8;
    public TextMeshProUGUI textBox9;
    public TextMeshProUGUI textBox10;
    public TextMeshProUGUI textBox11;
    public TextMeshProUGUI textBox12;

    public TextMeshProUGUI timer5;
    public TextMeshProUGUI timer6;
    public TextMeshProUGUI timer7;
    public TextMeshProUGUI timer8;
    public TextMeshProUGUI timer9;
    public TextMeshProUGUI timer10;
    public TextMeshProUGUI timer11;
    public TextMeshProUGUI timer12;

    public UnityEngine.UI.Button buttonstabil1;
    public UnityEngine.UI.Button buttonback;
    public UnityEngine.UI.Button button1;
    public UnityEngine.UI.Button button3;
    public UnityEngine.UI.Button buttonforward;
    void Update()
    {
        textBox5.text = string.Format("");
        textBox6.text = string.Format("");
        textBox7.text = string.Format("");
        textBox8.text = string.Format("");
        textBox9.text = string.Format("");
        textBox10.text = string.Format("");
        textBox11.text = string.Format("");
        textBox12.text = string.Format("");

        timer5.text = string.Format("");
        timer6.text = string.Format("");
        timer7.text = string.Format("");
        timer8.text = string.Format("");
        timer9.text = string.Format("");
        timer10.text = string.Format("");
        timer11.text = string.Format("");
        timer12.text = string.Format("");

        buttonstabil1.onClick.RemoveAllListeners();
        buttonstabil1.onClick.AddListener(stabil);
        buttonforward.onClick.RemoveAllListeners();
        buttonforward.onClick.AddListener(forward3ndpage);
        button3.onClick.RemoveAllListeners();
        button3.onClick.AddListener(forward3ndpage);
        button1.onClick.RemoveAllListeners();
        button1.onClick.AddListener(forward1stpage);
        buttonback.onClick.RemoveAllListeners();
        buttonback.onClick.AddListener(forward1stpage);
    }
    public void forward1stpage()
    {
        SceneManager.LoadSceneAsync("sort_bestTOworst");

    }
    public void forward3ndpage()
    {
        SceneManager.LoadSceneAsync("3.rd");
    }
    public void stabil()
    {
        this.buttonstabil1.enabled = false;
    }
}
