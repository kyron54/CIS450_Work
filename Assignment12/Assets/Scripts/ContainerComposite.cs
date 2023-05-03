using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerComposite : EnemyComponent
{
    //This list of InventoryComponents holds the items (and containers) in this container
    public List<EnemyComponent> enemyComponents = new List<EnemyComponent>();

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

        Debug.Log(GetEnemyType());
        if (!string.IsNullOrEmpty(description))
        {
            Debug.Log(description);
        }

        Debug.Log("-----Contents of " + GetEnemyType() + "-----");

        IterateWithIEnumerator(enemyComponents);

        Debug.Log("---End of Contents of " + GetEnemyType() + "---");

    }

    private void IterateWithIEnumerator(IEnumerable<EnemyComponent> enemyComponents)
    {
        IEnumerator<EnemyComponent> enumerator = enemyComponents.GetEnumerator();

        while (enumerator.MoveNext())
        {
            EnemyComponent component = enumerator.Current;

            component.PrintDescription();
        }

    }

    public override EnemyComponent GetChildEnemy(int i)
    {
        return enemyComponents[i];
    }
    public override void Add(EnemyComponent enemyComponent)
    {
        enemyComponents.Add(enemyComponent);
        enemyComponent.SpawnEnemy();
    }
    public override void Remove(EnemyComponent enemyComponent)
    {
        enemyComponent.DespawnEnemy();
        enemyComponents.Remove(enemyComponent);
    }
}
