using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPath : MonoBehaviour {
    public InputField firstInputField;
    public InputField secondInputField;
    public InputField thirdInputField;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void ShowPath1() {
        ChooseFile oldPath1 = FindObjectOfType<ChooseFile>();
        
        firstInputField.text = ChooseFile.path1;
    }

    public void ShowPath2()
    {
        secondInputField.text = ChooseFile.path2;
    }
    public void ShowPath3()
    {
        thirdInputField.text = ChooseFile.path3;
    }
}
