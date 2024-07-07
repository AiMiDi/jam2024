using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DecreaseMark")]
public class DecreaseMark : Buff
{
    public int decreaseMarkLayer;

    public override void BuffUpdate(Entity entity)
    {
        if(entity.status.mark>0)
        {
            entity.status.mark -= decreaseMarkLayer;
            isInvalid = true;
        }
    }
}
