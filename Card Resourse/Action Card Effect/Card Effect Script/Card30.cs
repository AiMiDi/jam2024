using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card30")]
public class Card30 : Buff
{
    private int damage;
    public override void BuffUpdate(Entity entity)
    {
        damage = (entity.status.max_damage+entity.status.min_damage)/ 2;
        entity.attackedEntity.status.health -= damage;

        for(int i = 1; i <= entity.status.hasBuffs.Count; i++)
        {
            entity.attackedEntity.status.health -= entity.attackedEntity.status.max_health;
        }
        isInvalid = true;

    }
}
