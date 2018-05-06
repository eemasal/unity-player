using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathAbsorber : MonoBehaviour {
    public string path;
    public string path1;
	// Use this for initialization
	void Start () {
        ChooseFile oldPath = FindObjectOfType<ChooseFile>();
        path = "Aya";
        if (oldPath)
        {
            path = oldPath.path;
            Destroy(oldPath.gameObject);
        }

       


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
