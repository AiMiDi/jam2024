using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Poison")]
public class Poison : Buff
{
    public int poisonLayer;

    public override void BuffUpdate(Entity entity)
    {
        if(poisonLayer >0)
        {
            //�ж�����10%Ѫ��
            entity.status.health -= entity.status.health/10;
            //�ж���������1��
            poisonLayer--;
        }
    }
}
