using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StunBuff")]
public class StanBuff : Buff
{
    public override void BuffUpdate(Entity entity)
    {
        base.BuffUpdate(entity);
        entity.status.is_stop = duration >= 0;
    }
}
