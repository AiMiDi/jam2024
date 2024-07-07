using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card27")]
public class Card27 : Buff
{
    private float oldAttack_speed = -1f;
    public override void BuffUpdate(Entity entity)
    {
        if (oldAttack_speed < 0f)
        {
            oldAttack_speed = entity.attackedEntity.status.attack_speed;
            entity.attackedEntity.status.attack_speed += 0.2f ;
        }
        else
        {
            entity.attackedEntity.status.attack_speed -= 0.2f;
        }
        
    }
}

