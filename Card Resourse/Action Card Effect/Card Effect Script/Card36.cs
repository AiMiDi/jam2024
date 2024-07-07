using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card36")]
public class Card36 : Buff
{
    private int oldDefence;
    
    public override void BuffUpdate(Entity entity)
    {
        if (entity.status.defense > 0)
        {
            if (oldDefence < 0)
            {
                oldDefence = entity.status.defense;
            }
            entity.status.defense = 9999;
            if (entity.status.defense == 9999)
                return;
            entity.status.defense = oldDefence;
            isInvalid = true;
        }
    }
}
