using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyComponent : MonoBehaviour
{
    public enum EnemyType
    {
        Enemy,
        Slime,
        Zombie,
        Skeleton
    }
    public EnemyType enemyType;
    public GameObject model;
    public string description;
    public GameObject spawn1, spawn2, spawn3;

    public abstract EnemyType GetEnemyType();
    public abstract GameObject GetModel();
    public abstract void PrintDescription();

    public virtual void SpawnEnemy()
    {
        throw new System.NotSupportedException("SpawnEnemy is not supported for " + this.GetType().Name);
    }
    public virtual void DespawnEnemy()
    {
        throw new System.NotSupportedException("DespawnEnemy is not supported for " + this.GetType().Name);
    }
    public virtual EnemyComponent GetChildEnemy(int i)
    {
        throw new System.NotSupportedException("GetChildItem() is not supported for " + this.GetType().Name);
    }
    public virtual void Add(EnemyComponent enemyComponent)
    {
        throw new System.NotSupportedException("Add() is not supported for " + this.GetType().Name);
    }
    public virtual void Remove(EnemyComponent enemyComponent)
    {
        throw new System.NotSupportedException("Remove() is not supported for " + this.GetType().Name);
    }

    public virtual int GetAmount()
    {
        throw new System.NotSupportedException("GetAmount() is not supported for " + this.GetType().Name);
    }

}
