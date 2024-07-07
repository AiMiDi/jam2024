using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card05")]
public class Card05 : Buff
{
    private int damage;
    public override void BuffUpdate(Entity entity)
    {
        damage = entity.status.min_damage + 2;
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
