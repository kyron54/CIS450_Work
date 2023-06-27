using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    ObjectPool objectPool;

    public float health = 50f;
    public GameObject bullet;

    private void Start()
    {
        objectPool = ObjectPool.Instance;
    }

    public void TakeDamage(float amount)
    {
        
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
        
    }

    void Die()
    {
        Destroy(gameObject);
    }

    public void SpawnBullet(Vector3 spawnPos, Quaternion rot)
    {
        objectPool.SpawnFromPool("Bullet", spawnPos, rot);
    }

}
