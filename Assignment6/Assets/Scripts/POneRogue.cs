using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POneRogue : Fighter
{
    public POneRogue()
    {
        this.playerNum = "Player One";
        this.FighterClass = FighterType.ROGUE;
        this.Weapon = "Dagger";
        this.Damage = 2;
        this.Speed = 1.9f;
    }
}