using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sorting3rdpage : MonoBehaviour
{

    public TextMeshProUGUI textBox13;
    public TextMeshProUGUI textBox14;
    public TextMeshProUGUI textBox15;
    public TextMeshProUGUI textBox16;
    public TextMeshProUGUI textBox17;
    public TextMeshProUGUI textBox18;
    public TextMeshProUGUI textBox19;
    public TextMeshProUGUI textBox20;

    public TextMeshProUGUI timer13;
    public TextMeshProUGUI timer14;
    public TextMeshProUGUI timer15;
    public TextMeshProUGUI timer16;
    public TextMeshProUGUI timer17;
    public TextMeshProUGUI timer18;
    public TextMeshProUGUI timer19;
    public TextMeshProUGUI timer20;

    public UnityEngine.UI.Button buttonstabil1;
    public UnityEngine.UI.Button buttonstabil2;
    public UnityEngine.UI.Button button1;
    public UnityEngine.UI.Button button2;
    public UnityEngine.UI.Button buttonback;

    // Update is called once per frame
    void Update()
    {
        textBox13.text = string.Format("");
        textBox14.text = string.Format("");
        textBox15.text = string.Format("");
        textBox16.text = string.Format("");
        textBox17.text = string.Format("");
        textBox18.text = string.Format("");
        textBox19.text = string.Format("");
        textBox20.text = string.Format("");

        timer13.text = string.Format("");
        timer14.text = string.Format("");
        timer15.text = string.Format("");
        timer16.text = string.Format("");
        timer17.text = string.Format("");
        timer18.text = string.Format("");
        timer19.text = string.Format("");
        timer20.text = string.Format("");



        button1.onClick.RemoveAllListeners();
        button2.onClick.RemoveAllListeners();
        buttonback.onClick.RemoveAllListeners();
        buttonstabil1.onClick.RemoveAllListeners();
        buttonstabil2.onClick.RemoveAllListeners();
        button1.onClick.AddListener(forward1stpage);
        button2.onClick.AddListener(forward2ndpage);
        buttonback.onClick.AddListener(forward2ndpage);
        buttonstabil2.onClick.AddListener(stabil);
        buttonstabil1.onClick.AddListener(stabil);
    }
    public void forward1stpage()
    {
        SceneManager.LoadSceneAsync("sort_bestTOworst");

    }
    public void forward2ndpage()
    {
        SceneManager.LoadSceneAsync("2.nd");
    }
    public void stabil()
    {
        this.buttonstabil1.enabled = false;
        this.buttonstabil2.enabled = false;
    }
}
