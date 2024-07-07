using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dizziness")]
public class Dizziness : Buff
{
    public float dizzinessTime;
    private float stopTimeCount;
    public override void BuffUpdate(Entity entity)
    {
        if (!entity.status.is_stop)
        {
            stopTimeCount = dizzinessTime;
            if (stopTimeCount > 0)
                return;
            entity.status.is_stop = true;
        }
    }
}
