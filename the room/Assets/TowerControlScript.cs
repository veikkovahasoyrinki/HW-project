using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerControlScript : MonoBehaviour
{

    private float rotateValue, tiltValue;
    private float turnSpeed = 100f;
    private float tiltSpeed = 90f;
    private Rigidbody towerRigidbody;
    private GameObject cannonCopy;
    public GameObject cannon;

    // Start is called before the first frame update
    void Start()
    {
        towerRigidbody = GetComponent<Rigidbody>();
        cannonCopy = new GameObject();
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
        if (rotateValue < .2f && rotateValue > -.2f) return;
        float turn = rotateValue * turnSpeed * Time.deltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        towerRigidbody.MoveRotation(towerRigidbody.rotation * turnRotation);

    }

    private void Tilt()
    {
        if (tiltValue < .2f && tiltValue > -.2f) return;

        float tilt = tiltValue * tiltSpeed * Time.deltaTime;
        Vector3 vector = new Vector3(tilt, 0, 0);

        cannonCopy.transform.rotation = cannon.transform.rotation;
        cannonCopy.transform.Rotate(vector);
        Debug.Log("Proposed rotation" + cannonCopy.transform.rotation);
        if (cannonCopy.transform.rotation.x > -0.40f && cannonCopy.transform.rotation.x < 0.40f)
        { 
            cannon.transform.Rotate(vector);
        }
    }
}