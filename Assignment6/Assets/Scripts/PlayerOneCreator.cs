using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneCreator : CreateFighter
{
    public override Fighter CreateNewFighter(string player)
    {
        Fighter playerOne = null;

        if(player.Equals("Berserker"))
        {
            playerOne = new POneBerserker();
        } 
        else if (player.Equals("Warrior"))
        {
            playerOne = new POneWarrior();
        }
        else if (player.Equals("Mage"))
        {
            playerOne = new POneMage();
        }
        else if (player.Equals("Archer"))
        {
            playerOne = new POneArcher();
        }
        else if (player.Equals("Rogue"))
        {
            playerOne = new POneRogue();
        }

        return playerOne;
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
