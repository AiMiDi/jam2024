using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "�ж�")]
public class Poison : Buff
{
    public int poisonLayer;

    public override void BuffUpdate(Entity entity)
    {
        base.BuffUpdate(entity);
        if(poisonLayer >0)
        {
            entity.status.health -= entity.status.health/10;
            poisonLayer--;
        }
        
        
    }
}
