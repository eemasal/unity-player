using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Crosstales.FB;



public class ChooseFile : MonoBehaviour {
    public string path;
    static public string path1;
    static public string path2;
    static public string path3;


    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void apply()
    {

        string extensions = "";

        path = FileBrowser.OpenSingleFile("Open File", "", extensions);

    }

    public void apply1()
    {

        string extensions = "";

        path1 = FileBrowser.OpenSingleFile("Open File", "", extensions);

    }

    public void apply2()
    {

        string extensions = "";

        path2 = FileBrowser.OpenSingleFile("Open File", "", extensions);

    }
    public void apply3()
    {

        string extensions = "";

        path3 = FileBrowser.OpenSingleFile("Open File", "", extensions);

    }


}
