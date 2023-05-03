using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLeaf : EnemyComponent
{
    public int amount;
    GameObject clone;

    public override EnemyType GetEnemyType()
    {
        return enemyType;
    }

    public override GameObject GetModel()
    {
        return model;
    }

    public override void PrintDescription()
    {
        //print item amount and name (set up as an EnemyType enum)
        Debug.Log(GetEnemyType());

        if (!string.IsNullOrEmpty(description))
        {
            Debug.Log(description);
        }
    }

    public override void SpawnEnemy()
    {
        if (GetEnemyType() == EnemyType.Slime)
        {
            clone = Instantiate(GetModel(), transform.parent);
        }

        if (GetEnemyType() == EnemyType.Zombie)
        {
            clone = Instantiate(GetModel(), transform.parent);
        }

        if (GetEnemyType() == EnemyType.Skeleton)
        {
            clone = Instantiate(GetModel(), transform.parent);
        }
    }

    public override void DespawnEnemy()
    {
        Destroy(clone);
    }
}
