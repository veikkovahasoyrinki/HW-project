using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountLosses : MonoBehaviour
{
    void OnTriggerEnter(Collider objectName)
    {
        
        if (objectName.name == "Goblin_test Variant Variant 1(Clone)")
        {
            Debug.Log("Hit!");
        }
    }
}
