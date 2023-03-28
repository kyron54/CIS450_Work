using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    Sword sword;
    Axe axe;
    Enemy enemyScript;
    GameObject enemy;

    int whichWeapon = 1;

    // Start is called before the first frame update
    void Start()
    {
        sword = new Sword();
        axe = new Axe();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy == null)
        {
            enemy = GameObject.FindGameObjectWithTag("Enemy");
            enemyScript = enemy.GetComponent<Enemy>();
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            whichWeapon = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            whichWeapon = 2;
        }

        if(whichWeapon == 1)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                sword.Scope(enemyScript.maxHealth);
                sword.SetStats(2f, 1.5f, 1.3f);
                sword.Stats();
                enemyScript.ReduceHealth(sword.Attack());
            }
        }

        if (whichWeapon == 2)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                axe.Scope(enemyScript.maxHealth);
                axe.SetStats(4f, 0.8f, 1.7f);
                axe.Stats();
                enemyScript.ReduceHealth(axe.Attack());
            }
        }


    }
}
