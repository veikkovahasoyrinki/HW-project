using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public float Speed;

    public Transform waypoints;
    int curWaypointIndex = 0;
    public float previous_Speed;
    public Animator anim;



    void Start()
    {
        anim = GetComponent<Animator>();

        previous_Speed = Speed;
    }









    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, waypoints.position, Time.deltaTime * Speed);

        transform.LookAt(waypoints.position);


    }
}

