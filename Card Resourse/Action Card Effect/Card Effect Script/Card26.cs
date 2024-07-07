using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card26")]
public class Card26 : Buff
{
    private int damage;
    private int health;
    public override void BuffUpdate(Entity entity)
    {
        health = entity.status.health;
        damage = health+health/10*2;
        if (entity.attackedEntity.status.defense >= damage)
        {
            entity.attackedEntity.status.defense -= damage;
            entity.attackedEntity.status.defense -= 10;
        }
        else
        {
            damage -= entity.attackedEntity.status.defense;
            entity.attackedEntity.status.defense = 0;
            entity.attackedEntity.status.health -= damage;
        }

        isInvalid = true;
    }
}
