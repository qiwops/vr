using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public GameObject Bullet;
    public Transform firePoint;
    public float bulletForce = 10f;

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            GameObject bullet = Instantiate(Bullet, firePoint.position, firePoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(firePoint.forward * bulletForce, ForceMode.Impulse);
            Destroy(bullet, 5f);
        }
        
    }
}
