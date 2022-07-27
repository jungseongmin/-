using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileLord : MonoBehaviour
{
    public Text[] textGUI;

    public string[] path;
    
    void Start()
    {
        for(int i = 0; i < textGUI.Length; i++)
        {
            textGUI[1].text = System.IO.File.ReadAllText(path[i]);
        }
    }
}