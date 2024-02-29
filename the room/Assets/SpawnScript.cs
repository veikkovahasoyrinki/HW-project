using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject target;
    public GameObject goblin;
    public GameObject tutorialGoblin;
    public Transform spawnVector;
    public float spawnTime = 3f;
    public bool spawning = false;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (tutorialGoblin == null)
        {
            spawning = true;
        }
    }



    void Spawn()
    {
        if (spawning) {
            var newGoblin = GameObject.Instantiate(goblin, spawnVector.position, spawnVector.rotation);
            newGoblin.GetComponent<Enemy>().point = target;
            newGoblin.transform.Rotate(0, -90, 0);

        }
    }
}