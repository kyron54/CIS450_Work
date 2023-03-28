using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public GameObject newEnemy;
    public TextMeshProUGUI tmpro;

    float health;
    public float maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

        tmpro.text = "Health: " + health;

        if(health <= 0)
        {
            Invoke("RespawnEnemy", 0);
            StartCoroutine(RespawnAfterDeath());
        }
    }

    public void ReduceHealth(float decrement)
    {
        health -= decrement;
    }

    void RespawnEnemy()
    {
        Instantiate(newEnemy, gameObject.transform);
    }

    IEnumerator RespawnAfterDeath()
    {
        yield return new WaitForSeconds(0);

        Destroy(gameObject);
    }
}
