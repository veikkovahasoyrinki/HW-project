using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject goblin;
    public float spawnTime = 3f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        var newGoblin = GameObject.Instantiate(goblin);
    }
}