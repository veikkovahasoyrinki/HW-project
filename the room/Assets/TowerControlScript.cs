using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerControlScript : MonoBehaviour
{

    private float rotateValue, tiltValue;
    private float turnSpeed = 100f;
    private float tiltSpeed = 90f;
    private Rigidbody towerRigidbody;
    public GameObject cannon;

    // Start is called before the first frame update
    void Start()
    {
         towerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rotate();
        Tilt();
    }

    public void rotateTowerLever(float rotation) => rotateValue = rotation;

    public void tiltCannonLever(float tilt) => tiltValue = tilt;

    private void Rotate()
    {
        float turn = rotateValue * turnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        towerRigidbody.MoveRotation(towerRigidbody.rotation * turnRotation);

    }

    private void Tilt()
    {
        float tilt = rotateValue * turnSpeed * Time.deltaTime;
        Vector3 vector = new Vector3(tilt, 0, 0);
        cannon.transform.Rotate(vector);
    }
}