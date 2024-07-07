using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card28")]
public class Card28: Buff
{
    private float dizzinessTime = 2f;
    private float stopTimeCount = -1f;
    public override void BuffUpdate(Entity entity)
    {
       if(entity.status.health>= entity.attackedEntity.status.health)
        {
            if(!entity.attackedEntity.status.is_stop)
            {
                if (stopTimeCount < 0f)
                {
                    stopTimeCount = dizzinessTime;
                    entity.attackedEntity.status.is_stop = true;
                }
            }
            if (stopTimeCount > 0 || entity.attackedEntity.status.is_stop)
            {
                stopTimeCount -= Time.deltaTime;
                return;
            }
            entity.attackedEntity.status.is_stop = false;
            isInvalid = true;
        }
    }
}

