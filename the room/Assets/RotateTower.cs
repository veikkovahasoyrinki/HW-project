using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class RotateTower : MonoBehaviour
{

    private List<InputDevice> leftHands = new List<InputDevice>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetHands();
        Locomotion();
    }


    private void GetHands()
    {
        InputDevices.GetDevicesAtXRNode(XRNode.LeftHand, leftHands);
    }



    private void Locomotion()
    {
        if (leftHands.Count == 0)
            return;

        if (!leftHands[0].isValid)
            return;

        Vector2 movementVector;
        if (leftHands[0].TryGetFeatureValue(CommonUsages.primary2DAxis, out movementVector))
        {
            // Shows that value is always zero
            print($"Left Joystick Values: {movementVector}");

            if (Mathf.Abs(movementVector.x) >= 0.2f || Mathf.Abs(movementVector.y) >= 0.2f)
            {
                Vector3 vector = new Vector3(0, movementVector.x, 0);
                gameObject.transform.Rotate(vector);
            }
        }
    }
}