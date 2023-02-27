using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POneArcher : Fighter
{
    public POneArcher()
    {
        this.playerNum = "Player One";
        this.FighterClass = FighterType.ARCHER;
        this.Weapon = "Bow";
        this.Damage = 5;
        this.Speed = 1.3f;
    }
}