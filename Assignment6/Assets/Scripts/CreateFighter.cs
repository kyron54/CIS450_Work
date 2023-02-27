using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CreateFighter
{
    // CreateFighter is the class that Players 1 and 2 use to create their respective fighters.

    public abstract Fighter CreateNewFighter(string player);

    public Fighter SpawnFighter(string player)
    {
        Fighter fighter;

        fighter = CreateNewFighter(player);

        // Fighters will list their stats here.
        fighter.AnnounceStats();

        return fighter;
    }

}
