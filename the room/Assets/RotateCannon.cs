using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class RotateCannon : MonoBehaviour
{

    private List<InputDevice> rightHands = new List<InputDevice>();

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
        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, rightHands);
    }



    private void Locomotion()
    {
        if (rightHands.Count == 0)
            return;

        if (!rightHands[0].isValid)
            return;

        Vector2 movementVector;
        if (rightHands[0].TryGetFeatureValue(CommonUsages.primary2DAxis, out movementVector))
        {
            // Shows that value is always zero
            print($"Left Joystick Values: {movementVector}");

            if (Mathf.Abs(movementVector.x) >= 0.2f || Mathf.Abs(movementVector.y) >= 0.2f)
            {
                Vector3 vector = new Vector3(movementVector.y, 0, 0);
                gameObject.transform.Rotate(vector);
            }
        }
    }
}