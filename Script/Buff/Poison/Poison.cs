using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Poison")]
public class Poison : Buff
{
    public int poisonLayer;

    public override void BuffUpdate(Entity entity)
    {
        if(poisonLayer >0)
        {
            //中毒减少10%血量
            entity.status.health -= entity.status.health/10;
            //中毒层数减少1层
            poisonLayer--;
        }
    }
}
