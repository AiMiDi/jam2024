using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "CardEfftct/Card35")]
public class Card35 : Buff
{
    private int damage;
    private int defense;
    private int health;
    public override void BuffUpdate(Entity entity)
    {
        damage = entity.status.max_damage/10*7;
        health = entity.status.max_health;
        defense = health / 10 + health / 10 * 5;
        entity.status.defense += defense;
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

