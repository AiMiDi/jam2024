using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card09")]
public class Card09: Buff
{

    public override void BuffUpdate(Entity entity)
    {
        entity.attackedEntity.status.mark += 2;
        isInvalid = true;
    }
}

