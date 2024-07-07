using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card12")]
public class Card12 : Buff
{
    private int damage;
    private int defense;
    public override void BuffUpdate(Entity entity)
    {
        defense = entity.status.max_health / 10;
        entity.status.defense += defense;
        damage = entity.status.max_damage;
        if (entity.attackedEntity.status.defense >= damage)
            entity.attackedEntity.status.defense -= damage;
        else
        {
            damage -= entity.attackedEntity.status.defense;
            entity.attackedEntity.status.defense = 0;
            entity.attackedEntity.status.health -= damage;
        }
        if (entity.attackedEntity.status.mark > 0)
        {
            entity.attackedEntity.status.mark--;
            entity.status.defense += defense;
        }
            
            
        isInvalid = true;
    }
}
