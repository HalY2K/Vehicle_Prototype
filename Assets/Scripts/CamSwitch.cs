using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject playerVehicle;
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject MainCamera;
   
    // Update is called once per frame
    void LateUpdate()
    {

        if (Input.GetButtonDown("1Key"))
        {
            Cam1.SetActive(true);
            Cam2.SetActive(false);
            MainCamera.SetActive(false);
        }
        if (Input.GetButtonDown("2Key"))
        {
            Cam1.SetActive(false);
            Cam2.SetActive(true);
            MainCamera.SetActive(false);
        }
        if (Input.GetButtonDown("3Key"))
        {
            Cam1.SetActive(false);
            Cam2.SetActive(false);
            MainCamera.SetActive(true);
        }
    }
}
