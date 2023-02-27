using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    // Fighter is the Main Product class that every fighter type inherits from.

    public string playerNum;
    public enum FighterType { BERSERKER, WARRIOR, MAGE, ARCHER, ROGUE }
    public FighterType FighterClass;
    public string Weapon;
    public int Damage;
    public float Speed;

    public void AnnounceStats()
    {
        Debug.Log("You are: " + this.playerNum + "\n");
        Debug.Log("Your class: " + this.FighterClass + "\n");
        Debug.Log("Damage: " + this.Damage + "\n");
        Debug.Log("Speed: " + this.Speed + "\n");
        Debug.Log("Weapon of choice: " + this.Weapon + "\n");
    }
}
