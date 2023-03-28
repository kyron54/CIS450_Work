using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : WeaponDamage
{
    float baseDamage;
    float speed;
    float weight;

    Enemy enemy;

    public override float Attack()
    {
        float attack = baseDamage * speed * weight;

        Debug.Log("You did: " + attack + " damage!");

        return attack;
    }

    public override void Stats()
    {
        Debug.Log("Sword Stats: \n" +
            "Base Damage: " + baseDamage + "\n" +
            "Weapon Speed: " + speed + "\n" +
            "Weapon Weight: " + weight);
    }

    public override void SetStats(float _baseDamage, float _speed, float _weight)
    {
        baseDamage = _baseDamage;
        speed = _speed;
        weight = _weight;
    }
}
