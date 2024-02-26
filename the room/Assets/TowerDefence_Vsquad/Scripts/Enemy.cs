using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public float Speed;

    public GameObject point;
    public Transform waypoints;
    public GameObject explPrefab;
    int curWaypointIndex = 0;
    public float previous_Speed;
    public Animator anim;



    void Start()
    {
        anim = GetComponent<Animator>();

        previous_Speed = Speed;
}



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





    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, point.transform.position, Time.deltaTime * Speed);

        transform.LookAt(point.transform.position);


    }
}

