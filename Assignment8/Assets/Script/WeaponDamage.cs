using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponDamage 
{

    public void Interact()
    {
        Stats();
        
        Attack();
    }

    public void Scope(float health)
    {
        Debug.Log("Enemy Max Health is: " + health);
    }

    public abstract void Stats();

    public abstract float Attack();

    public abstract void SetStats(float baseDamage, float speed, float weight);
}
