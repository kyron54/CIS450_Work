using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTwoWarrior : Fighter
{
    public PTwoWarrior()
    {
        this.playerNum = "Player Two";
        this.FighterClass = FighterType.WARRIOR;
        this.Weapon = "Sword";
        this.Damage = 6;
        this.Speed = 1.3f;
    }
}