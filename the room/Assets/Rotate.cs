using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rotate : MonoBehaviour
{

    public GameObject sphere;
    public float degreesPerSec = 2.0f;
    void Start()
    {
        sphere = GetComponent<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, degreesPerSec * Time.deltaTime, 0);
    }
}
