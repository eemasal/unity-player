using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class CameraMove : MonoBehaviour {
    

    // Use this for initialization
    void Start () {
		
	}

   

    // Update is called once per frame
    void Update () {

        Camera camera = GetComponentInChildren<Camera>();

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 5, 0) * transform.localRotation;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localRotation = Quaternion.Euler(0, -5, 0) * transform.localRotation;

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            camera.transform.localRotation = Quaternion.Euler(-5, 0, 0) *camera.transform.localRotation;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            camera.transform.localRotation = Quaternion.Euler(5, 0, 0) * camera.transform.localRotation;

        }

        float mouseX = Input.GetAxis("Mouse X")*5f;
        float mouseY = Input.GetAxis("Mouse Y")*5f;
        camera.transform.localRotation = Quaternion.Euler(-mouseY, 0, 0) * camera.transform.localRotation;
        transform.localRotation = Quaternion.Euler(0, mouseX, 0) * transform.localRotation;




    }


}

