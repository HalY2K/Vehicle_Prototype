using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject playerVehicle;
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject MainCamera;
    private Vector3 offset = new Vector3(0, 7, -10);
    private Vector3 offsetCam1 = new Vector3(0, 2, 2.95f);
    private Vector3 offsetCam2 = new Vector3(10, 3.5f, -3.5f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

       
            Cam1.transform.position = playerVehicle.transform.position + offsetCam1;
            Cam2.transform.position = playerVehicle.transform.position + offsetCam2;
            MainCamera.transform.position = playerVehicle.transform.position + offset;
        
    }
}
