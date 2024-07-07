using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEfftct/Card39")]
public class Card39 : Buff
{
    private int defense;
    private int health;
    public override void BuffUpdate(Entity entity)
    {
        health = entity.status.max_health;
        defense = health / 10 * 2 + health / 100 * 5;
        if (defense < 10)
            defense += health / 10;
        entity.status.defense += defense;
        isInvalid = true;
    }
}
