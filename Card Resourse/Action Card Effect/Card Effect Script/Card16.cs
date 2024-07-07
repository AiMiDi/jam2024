using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card16")]
public class Card16 : Buff
{
    private int damage;
    private int health;
    public override void BuffUpdate(Entity entity)
    {
        damage = entity.status.max_damage+1;
        health = entity.status.max_health;
        if (entity.attackedEntity.status.defense >= damage)
            entity.attackedEntity.status.defense -= damage;
        else
        {
            damage -= entity.attackedEntity.status.defense;
            entity.attackedEntity.status.defense = 0;
            entity.attackedEntity.status.health -= damage;
        }
        entity.status.defense += health / 10 + health / 100 * 5;

        isInvalid = true;
    }
}


