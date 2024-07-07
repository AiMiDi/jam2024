using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card25")]
public class Card25 : Buff
{
    private int damage;
    public override void BuffUpdate(Entity entity)
    {
        damage = entity.attackedEntity.status.max_health/10;
        entity.attackedEntity.status.health = damage;
        isInvalid = true;
    }
}
