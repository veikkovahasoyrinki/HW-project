using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialGoblin : MonoBehaviour
{
    public GameObject explPrefab;
    void OnTriggerEnter(Collider objectName)
    {
        if (objectName.name == "Cannonball(Clone)")
        {
            Vector3 pos = transform.position;
            Quaternion rot = transform.rotation;
            GameObject.Instantiate(explPrefab, pos, rot);
            Destroy(gameObject);
        }
    }
}
