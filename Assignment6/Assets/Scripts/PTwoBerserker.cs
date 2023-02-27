using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTwoBerserker : Fighter
{
    public PTwoBerserker()
    {
        this.playerNum = "Player Two";
        this.FighterClass = FighterType.BERSERKER;
        this.Weapon = "Mace";
        this.Damage = 9;
        this.Speed = 1.0f;
    }
}