using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pass : MonoBehaviour
{
    public InputField passwordInputField;
    public Button toggleButton;

    private bool isPasswordVisible = false;

    void Start()
    {
        if (passwordInputField == null)
        {
            Debug.LogError("Password Input Field is not assigned in the Inspector.");
            return; 
        }

        if (toggleButton == null)
        {
            Debug.LogError("Toggle Button is not assigned in the Inspector.");
            return;
        }
        passwordInputField.contentType = InputField.ContentType.Password;
        passwordInputField.ForceLabelUpdate();


        toggleButton.onClick.AddListener(TogglePasswordVisibility);
    }

    void TogglePasswordVisibility()
    {

        isPasswordVisible = !isPasswordVisible;

        if (isPasswordVisible)
        {

            passwordInputField.contentType = InputField.ContentType.Standard;
        }
        else
        {

            passwordInputField.contentType = InputField.ContentType.Password;
        }


        passwordInputField.ForceLabelUpdate();
    }
}
