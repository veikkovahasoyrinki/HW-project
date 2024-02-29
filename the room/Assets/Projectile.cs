using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float life = 5f;

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnTriggerEnter(Collider objectName)
    {

        if (objectName.name == "Goblin_test Variant Variant 1(Clone)")
        {
            Destroy(gameObject);
        }
    }

}
