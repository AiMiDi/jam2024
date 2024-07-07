using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card15")]
public class Card15 : Buff
{
    private int oldDefence = -1;
    public override void BuffUpdate(Entity entity)
    {
        if (entity.attackedEntity.status.mark <= 0 && oldDefence < 0)
            return;
        entity.attackedEntity.status.mark--;
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


