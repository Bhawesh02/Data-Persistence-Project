using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{
    public TextMeshProUGUI userName;
    public void StartGame()
    {
        if (userName.text != "Enter Name:​")
        {
            GameManager.instace.userName = userName.text;

            SceneManager.LoadScene(1);
        }
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    }
}
