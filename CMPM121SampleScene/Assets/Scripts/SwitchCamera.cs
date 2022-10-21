using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SwitchCamera : MonoBehaviour
{
    void Start() {
        foreach (Transform child in transform) {
            print(child.name);
        }
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            EnableCamera("1P Camera");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            EnableCamera("3P Camera");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            EnableCamera("Orthographic Camera");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4)) {
            EnableCamera("Rotate Camera");
        }
    }

    void EnableCamera(string e_cam) {
        foreach (Transform cam in transform) {
            //Camera camera = cam.GetComponent<Camera>();
            if (cam.name != e_cam) {
                //print($"disable {camera.name}");
                cam.gameObject.SetActive(false);
            }
            else
                //print($"enable {cam.name}");
                //camera.enabled = true;
                cam.gameObject.SetActive(true);

        }
    }
}
