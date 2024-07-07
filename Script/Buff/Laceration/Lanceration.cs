using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Lanceration")]
public class Lanceration : Buff
{
    public int lancerationLayer;

    public override void BuffUpdate(Entity entity)
    {
        if(lancerationLayer > 0)
        {
            entity.status.defense -= 10;
            lancerationLayer--;
            return;
        }
        isInvalid = true;
    }
}
