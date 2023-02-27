using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POneMage : Fighter
{
    public POneMage()
    {
        this.playerNum = "Player One";
        this.FighterClass = FighterType.MAGE;
        this.Weapon = "Staff";
        this.Damage = 4;
        this.Speed = 1.6f;
    }
}