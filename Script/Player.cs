using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : Entity
{
    bool isMoved = false;

    // Start is called before the first frame update
    private new void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    private new void Update()
    {
        base.Update();
        MoveToAttackedEntity();
    }

    public override void BeginBattle()
    {
        base.BeginBattle();
    }

    private void MoveToAttackedEntity()
    {
        anim.SetBool("IsRun", true);
        battle.endlessParallaxBackground.isBackgroundMove = true;
        return;
        if (!CanAttack() && !isMoved)
        {
            transform.position = Vector3.MoveTowards(transform.position, attackedEntity.transform.position, status.move_speed * Time.deltaTime);
        }
        else
        {
            isMoved = true;
        }
    }
}
