using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ѣ��")]
public class Dizziness : Buff
{
    public float DizzinessTime;
    
    public override void BuffUpdate(Entity entity)
    {
        base.BuffUpdate(entity);
        
    }
}
