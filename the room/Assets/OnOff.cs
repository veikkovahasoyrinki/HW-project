using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OnOff : MonoBehaviour
{
    // Start is called before the first frame update
    public Light light;
    public InputActionReference action;
    void Start()
    {
        light = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (light.enabled == true)
            {
                light.enabled = false;
            }
            else
            {
                light.enabled = true;
            }
        };
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
