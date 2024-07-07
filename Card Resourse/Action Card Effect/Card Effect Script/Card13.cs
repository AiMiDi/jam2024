using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card13")]
public class Card13 : Buff
{
    private int damage;
    private int min_damage;
    private int mark;
    public override void BuffUpdate(Entity entity)
    {
        
        mark = entity.attackedEntity.status.mark;

        entity.attackedEntity.status.mark = 0;
        min_damage = entity.status.min_damage;
        damage = min_damage/10 + min_damage/100*4 + mark;

        entity.attackedEntity.status.health -= damage;

        isInvalid = true;
    }
}
