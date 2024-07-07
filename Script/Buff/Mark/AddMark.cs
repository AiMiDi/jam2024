using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AddMark")]
public class AddMark : Buff
{
    public int addMarkLayer;

    public override void BuffUpdate(Entity entity)
    {
        entity.status.mark += addMarkLayer;
        isInvalid = true;
    }
}

