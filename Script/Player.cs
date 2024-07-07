using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : Entity
{
    bool isMove = false;

    bool isMoveToAttacked = false;
    bool isMoveToAttack = false;

    // Start is called before the first frame update
    private new void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    private new void Update()
    {
        base.Update();

        if (isMoveToAttack)
        {
            MoveToAttackedEntity();
            return;
        }

        if (isMove)
        {
            Move(true);
        }

        Move(false);

    }

    public override void BeginBattle()
    {
        base.BeginBattle();
        isMoveToAttack = true;
    }

    public override void EndBattle()
    {
        isMoveToAttack = false;
        battle.EndBattle(true);
        Destroy(this);
    }

    private void MoveToAttackedEntity()
    {
        if (!CanAttack() && !isMoveToAttacked)
        {
            Move(true);
        }
        else
        {
            Move(false);
        }
    }

    private void Move(bool isMove)
    {
        anim.SetBool("IsRun", isMove);
        battle.endlessParallaxBackground.isBackgroundMove = isMove;
    }
}
