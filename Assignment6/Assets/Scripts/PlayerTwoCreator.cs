using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoCreator : CreateFighter
{
    public override Fighter CreateNewFighter(string player)
    {
        Fighter playerTwo = null;

        if(player.Equals("Berserker"))
        {
            playerTwo = new PTwoBerserker();
        } 
        else if (player.Equals("Warrior"))
        {
            playerTwo = new PTwoWarrior();
        }
        else if (player.Equals("Mage"))
        {
            playerTwo = new PTwoMage();
        }
        else if (player.Equals("Archer"))
        {
            playerTwo = new PTwoArcher();
        }
        else if (player.Equals("Rogue"))
        {
            playerTwo = new PTwoRogue();
        }

        return playerTwo;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
