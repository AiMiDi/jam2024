using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card07")]
public class Card07 : Buff
{
    private int max_health;
    public override void BuffUpdate(Entity entity)
    {
        max_health = entity.status.health;
        entity.status.health +=max_health / 10 + max_health / 100 * 2;
        isInvalid = true;
    }
}
