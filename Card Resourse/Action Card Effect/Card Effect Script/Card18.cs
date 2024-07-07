using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card18")]
public class Card18 : Buff
{
    private float oldAttack_speed = -1f;
    public override void BuffUpdate(Entity entity)
    {
        if (oldAttack_speed > 0)
        {
            entity.status.attack_speed =oldAttack_speed;
            isInvalid = true;
            return;
        }

        oldAttack_speed = entity.status.attack_speed;
        if (oldAttack_speed < 0f)
        {
            oldAttack_speed = entity.status.attack_speed;
            entity.status.attack_speed -= 0.2f ;
            if (entity.status.attack_speed < 0f)
                entity.status.attack_speed = 0f;
        }
    }
}

