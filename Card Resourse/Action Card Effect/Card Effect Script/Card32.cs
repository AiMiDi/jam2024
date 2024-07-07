using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card32")]
public class Card32 : Buff
{
    
    public override void BuffUpdate(Entity entity)
    {
        if(entity.attackedEntity.status.hasBuffs.Count > 0)
        {
            entity.status.health += entity.status.max_health / 10 * 2;
        }
        isInvalid = true;
    }
}