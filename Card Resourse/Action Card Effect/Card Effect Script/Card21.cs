using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card21")]
public class Card21 : Buff
{
    private float timeCount = 6f;
    private float oldAttackSpeed = -1f;
    public override void BuffUpdate(Entity entity)
    {
        timeCount -= Time.deltaTime;
        if(oldAttackSpeed < 0f)
        {
            oldAttackSpeed = entity.status.attack_speed;
            entity.status.attack_speed -= 0.6f;
            if (entity.status.attack_speed < 0f)
                entity.status.attack_speed = 0f;
        }
        if (timeCount > 0)
            return;
        entity.status.attack_speed = oldAttackSpeed;
        isInvalid = true;
    }
}
