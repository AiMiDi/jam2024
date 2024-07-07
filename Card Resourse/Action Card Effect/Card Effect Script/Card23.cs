using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card23")]
public class Card23 : Buff
{
    private int oldDefense = -1;
    private float timeCount = 5f;
    public override void BuffUpdate(Entity entity)
    {
        if (oldDefense < 0)
        {
            oldDefense = entity.attackedEntity.status.defense;
            entity.attackedEntity.status.defense = 0;
        }
        timeCount -= Time.deltaTime;
        if (timeCount > 0)
            return;
        entity.attackedEntity.status.defense = oldDefense;
        isInvalid = true;
    }
}