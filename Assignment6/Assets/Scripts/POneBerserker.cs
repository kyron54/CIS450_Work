using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POneBerserker : Fighter
{
    public POneBerserker()
    {
        this.playerNum = "Player One";
        this.FighterClass = FighterType.BERSERKER;
        this.Weapon = "Mace";
        this.Damage = 9;
        this.Speed = 1.0f;
    }
}