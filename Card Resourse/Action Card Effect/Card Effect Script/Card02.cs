using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card02")]
public class Card02 : Buff
{

    public override void BuffUpdate(Entity entity)
    {
        entity.status.defense += entity.status.max_health / 10;
        isInvalid = true;
    }
}

