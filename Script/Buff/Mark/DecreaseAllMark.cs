using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "DecreaseAllMark")]

public class DecreaseAllMark : Buff
{

    public override void BuffUpdate(Entity entity)
    {
        entity.status.mark = 0;
    }
}