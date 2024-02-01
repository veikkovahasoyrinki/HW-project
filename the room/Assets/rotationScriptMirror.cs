using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class rotationScriptMirror : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera lensCamera;


   //public Transform target;
    public Camera mainCamera;
    public Vector3 vector;
    public Vector3 final_vector;
    public GameObject glass;

    void Start()
    {
        ///lensCamera = GetComponent<Camera>();
        //mainCamera = GetComponent<Camera>();
    //   point = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        vector = lensCamera.transform.position - mainCamera.transform.position;
        //final_vector = mainCamera.transform.position;
        final_vector = (lensCamera.transform.position + vector)*-1;

        // lensCamera.transform.rotation = mainCamera.transform.rotation;
        //    Quaternion target = mainCamera.transform.rotation;
        lensCamera.transform.LookAt(final_vector);
    }
}
