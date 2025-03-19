using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading.Tasks;
 
public class GunScript : MonoBehaviour
{
   
    public Transform bulletSpawnPoint;
    public Transform bulletRotation;
    public Transform flashRotation;
    
    public GameObject bulletPrefab;
    public GameObject flashPrefab;

    public Animation gunReload;

    public float bulletSpeed = 50;
    public int delay = 100;
    

    bool allowFire = true;
 
   


    void Update()
    {
        if((Input.GetMouseButtonDown(0)) && allowFire)
        {
            Fire();
        }

    }

    

    public async void Fire()
    {
        allowFire = false;

        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletRotation.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        var flash = Instantiate(flashPrefab, bulletSpawnPoint.position, flashRotation.rotation);

        await Task.Delay(delay);
        allowFire = true;
    }

}