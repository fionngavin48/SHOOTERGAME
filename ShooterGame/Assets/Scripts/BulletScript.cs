using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class BulletScript : MonoBehaviour
{
    public float life = 3;
 
    void Awake()
    {
        Destroy(gameObject, life);
    }
 
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
    
} 