using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTwoMage : Fighter
{
    public PTwoMage()
    {
        this.playerNum = "Player Two";
        this.FighterClass = FighterType.MAGE;
        this.Weapon = "Staff";
        this.Damage = 4;
        this.Speed = 1.6f;
    }
}