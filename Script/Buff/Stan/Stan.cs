using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StunBuff")]
public class StanBuff : Buff
{
    public float duration;

    public override void BuffUpdate(Entity entity)
    {
        if (duration < 0)
            return;

        duration -= Time.deltaTime;
        entity.status.is_stop = true;
    }
}
