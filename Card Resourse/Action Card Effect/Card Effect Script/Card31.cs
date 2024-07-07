using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card31")]
public class Card31 : Buff
{
    private int damage;
    public override void BuffUpdate(Entity entity)
    {
        damage = (entity.status.max_damage+entity.status.min_damage)/2;
        foreach(var buff in entity.attackedEntity.status.hasBuffs)
        {
            buff.isInvalid = true;
            if (entity.attackedEntity.status.defense >= damage)
                entity.attackedEntity.status.defense -= damage;
            else
            {
                damage -= entity.attackedEntity.status.defense;
                entity.attackedEntity.status.defense = 0;
                entity.attackedEntity.status.health -= damage;
            }
        }
        

        isInvalid = true;
    }
}
