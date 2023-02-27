using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTwoRogue : Fighter
{
    public PTwoRogue()
    {
        this.playerNum = "Player Two";
        this.FighterClass = FighterType.ROGUE;
        this.Weapon = "Dagger";
        this.Damage = 2;
        this.Speed = 1.9f;
    }
}