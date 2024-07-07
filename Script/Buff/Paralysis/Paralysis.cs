using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Paralysis")]
public class Paralysis : Buff
{
    public int paralysisLayer;
    private float oldAttack_speed = -1f;
    public override void BuffUpdate(Entity entity)
    { 
        if (oldAttack_speed < 0f)
        {
            oldAttack_speed = entity.status.attack_speed;
            entity.status.attack_speed += 0.2f * paralysisLayer;
        }
        
        paralysisLayer --;
        if (paralysisLayer == 0 )
        {
            entity.status.attack_speed = oldAttack_speed;
            isInvalid = true;
        }
    }
}
