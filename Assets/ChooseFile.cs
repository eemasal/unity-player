using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Crosstales.FB;



public class ChooseFile : MonoBehaviour {
    public string path;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void apply()
    {

        string extensions = "";

        path = FileBrowser.OpenSingleFile("Open File", "", extensions);
        Debug.Log("Selected file: " + path);

    }
    
}
