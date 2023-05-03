using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDriver : MonoBehaviour
{
    public ContainerComposite enemies;
    public EnemyComponent zombie;
    public EnemyComponent skeleton;
    public EnemyComponent slime;

    // Start is called before the first frame update
    void Start()
    {
        enemies.PrintDescription();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            enemies.Add(slime);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            enemies.Add(zombie);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            enemies.Add(skeleton);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            enemies.Remove(slime);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            enemies.Remove(zombie);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            enemies.Remove(skeleton);
        }
    }
}
