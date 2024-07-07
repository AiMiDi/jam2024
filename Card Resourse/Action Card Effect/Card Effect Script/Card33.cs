using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card33")]
public class Card33 : Buff
{
    private int defense;
    public override void BuffUpdate(Entity entity)
    {
        defense = entity.status.max_health - entity.status.health;
        entity.status.defense += defense;

        isInvalid = true;
    }
}
