using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card38")]
public class Card38 : Buff
{
    private int damage;
    private int max_demage;
    private int defense;
    public override void BuffUpdate(Entity entity)
    {
        max_demage = entity.status.max_damage;
        damage = max_demage + max_demage / 10 * 2;
        entity.status.defense += entity.status.max_health / 10 * 2;
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