using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card06")]
public class Card06 : Buff
{
    private int damage;
    public override void BuffUpdate(Entity entity)
    {
        entity.status.defense += entity.status.max_health / 10 - 1;
        damage = entity.status.max_health / 10 - 1;
        if (entity.attackedEntity.status.defense >= damage)
            entity.attackedEntity.status.defense -= damage;
        else
        {
            damage -= entity.attackedEntity.status.defense;
            entity.attackedEntity.status.defense = 0;
            entity.attackedEntity.status.health -= damage;
        }
        isInvalid = true;
    }
}
