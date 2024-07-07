using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card40")]
public class Card40 : Buff
{
    private int health;
    public override void BuffUpdate(Entity entity)
    {
        health = entity.status.max_health;
        foreach(var buff in entity.status.hasBuffs)
        {
            buff.isInvalid = true;
        }
        entity.status.health += health / 10 + health / 100 * 8;
        isInvalid = true;
    }
}
