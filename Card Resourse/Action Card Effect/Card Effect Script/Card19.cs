using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card19")]
public class Card19 : Buff
{
    private int damage;
    private int defense;
    public override void BuffUpdate(Entity entity)
    {
        damage = entity.status.max_damage*3;
        defense = entity.status.defense;
        if (entity.attackedEntity.status.defense >= damage)
            entity.attackedEntity.status.defense -= damage;
        else
        {
            damage -= entity.attackedEntity.status.defense;
            entity.attackedEntity.status.defense = 0;
            entity.attackedEntity.status.health -= damage;
        }
        entity.status.defense += defense / 10 * 3;
        isInvalid = true;
    }
}