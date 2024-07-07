using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card34")]
public class Card34 : Buff
{
   
    public override void BuffUpdate(Entity entity)
    {
        entity.status.health += entity.status.defense;
        if (entity.status.health > entity.status.max_health)
            entity.status.health = entity.status.max_health;
        isInvalid = true;
    }
}
