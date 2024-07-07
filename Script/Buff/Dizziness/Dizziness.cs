using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Dizziness")]
public class Dizziness : Buff
{
    public float dizzinessTime;
    private float stopTimeCount = -1f;
    public override void BuffUpdate(Entity entity)
    {
        if (!entity.status.is_stop)
        {
            if (stopTimeCount < 0f)
            {
                stopTimeCount = dizzinessTime;
                entity.status.is_stop = true;
                isInvalid = true;
            }
            
        }
        if (stopTimeCount > 0 || entity.status.is_stop)
        {
            stopTimeCount -= Time.deltaTime;
            return;
        }
        entity.status.is_stop = false;
    }
}
