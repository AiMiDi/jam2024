using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card10")]
public class Card10 : Buff
{
    private int max_damage;
    private int damage;
    public override void BuffUpdate(Entity entity)
    {
        max_damage = entity.status.max_damage;
        damage = max_damage / 10 + max_damage / 100 * 5;

        if (entity.attackedEntity.status.defense >= damage)
            entity.attackedEntity.status.defense -= damage;
        else
        {
            damage -= entity.attackedEntity.status.defense;
            entity.attackedEntity.status.defense = 0;
            entity.attackedEntity.status.health -= damage;
        }
        if (entity.attackedEntity.status.mark > 0)
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

