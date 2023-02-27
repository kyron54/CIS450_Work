using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POneWarrior : Fighter
{
    public POneWarrior()
    {
        this.playerNum = "Player One";
        this.FighterClass = FighterType.WARRIOR;
        this.Weapon = "Sword";
        this.Damage = 6;
        this.Speed = 1.3f;
    }
}