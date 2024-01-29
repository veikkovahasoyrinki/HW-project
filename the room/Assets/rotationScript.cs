using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class rotationScript : MonoBehaviour
{
    // Start is called before the first frame update
   // public GameObject lens;
    public Camera lensCamera;
    //public GameObject point;
    public Transform target;
    //public Camera mainCamera;

    void Start()
    {
        lensCamera = GetComponent<Camera>();
    //    mainCamera = GetComponent<Camera>();
    //   point = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        // lensCamera.transform.rotation = mainCamera.transform.rotation;
        //    Quaternion target = mainCamera.transform.rotation;
        lensCamera.transform.LookAt(target);
    }
}
