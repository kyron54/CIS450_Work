using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTwoArcher : Fighter
{
    public PTwoArcher()
    {
        this.playerNum = "Player Two";
        this.FighterClass = FighterType.ARCHER;
        this.Weapon = "Bow";
        this.Damage = 5;
        this.Speed = 1.3f;
    }
}