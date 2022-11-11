using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager instace;
    public string userName;

    public void Awake()
    {
        if (instace != null)
        {
            Destroy(gameObject);
            return;
        }
        instace = this;
        DontDestroyOnLoad(instace);
    }


}
