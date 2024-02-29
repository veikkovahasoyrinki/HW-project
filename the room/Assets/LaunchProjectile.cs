using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject projectile;
    public Transform AimPoint;
    public float launchVel = 50f;
    public GameObject explPrefab;
    public void Shoot()

    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;
        GameObject.Instantiate(explPrefab, pos, rot);
        var _projectile = Instantiate(projectile, launchPoint.position, launchPoint.rotation);
        _projectile.GetComponent<Rigidbody>().velocity = (launchPoint.position - AimPoint.position) * launchVel;
    }
}
