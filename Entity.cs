using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.Script;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static UnityEngine.EventSystems.EventTrigger;
using Random = UnityEngine.Random;
using Slider = UnityEngine.UI.Slider;

public class Entity : MonoBehaviour
{
    public Status status;

    [SerializeField] protected float attackCheckRadius = 1.0f;
    private float attackTimer = 0.0f;
    public Entity attackedEntity;
    public Animator anim { get; private set; }
    public Slider healthBar;

    // Start is called before the first frame update
    protected void Start()
    {
        status = status == null ? new Status(1) : new Status(status);
        anim = GetComponent<Animator>();
        InitHealthBar();
    }

    private void InitHealthBar()
    {
        var canvas = GetComponentInChildren<Canvas>();
        if (canvas)
        {
            healthBar = canvas.GetComponentInChildren<Slider>();
        }
    }

    // Update is called once per frame
    protected void Update()
    {
        UpdateBuff();
        Attack(attackedEntity);
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        if(healthBar != null)
            healthBar.value = (float)status.health / status.max_health;
    }

    private void UpdateBuff()
    {
        foreach (var addBuff in status.addBuffs)
        {
            if(Random.Range(0, 100) < addBuff.probability)
            {
                attackedEntity.status.hasBuffs.Add(addBuff.buff);
            }
        }

        foreach (var buff in status.hasBuffs)
        {
            buff.BuffUpdate(this);
        }
    }

    public void Attack(Entity attackedEntity)
    {
        if (!CanAttack()) return;

        attackTimer -= Time.deltaTime;
        if (attackTimer >= 0) return;

        attackTimer = status.attack_speed;
        var damage = status.GetDamage();
        attackedEntity.status.health -= damage;
        Debug.Log(name + " attack " + attackedEntity.name + " damage " + damage);
    }

    protected bool CanAttack()
    {
        Collider2D [] colliders = Physics2D.OverlapCircleAll(transform.position, attackCheckRadius);
        return colliders.Select(hit => hit.GetComponent<Entity>()).Any(entity => entity && entity == attackedEntity);
    }

    public virtual void BeginBattle()
    {
        attackTimer = status.attack_speed;
    }

    public virtual void EndBattle()
    {
    }

    protected virtual void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, attackCheckRadius);
    }
}
