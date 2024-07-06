using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    [CreateAssetMenu(menuName = "EntityStatus")]
    public class Status : ScriptableObject
    {
        // 等级
        public int level = 1;
        // 最大生命值
        public int max_health = 10;
        // 当前生命值
        public int health = 10;
        // 最大攻击力
        public int max_damage = 1;
        // 最小攻击力
        public int min_damage = 1;
        // 防御力, 假血
        public int defense = 0;
        // 印记数
        public int mark = 0;
        // 金币
        public int coin = 0;
        // 攻击速度
        public float attack_speed = 2f;
        // 移动速度
        public float move_speed = 10f;
        // 暂停动作
        public bool is_stop = true;
        // 拥有的buff
        public List<Buff> hasBuffs = new();
        // 添加给别人的buff
        public List<addableBuff> addBuffs = new();

        public Status(int level = 1)
        {
            this.level = level;
            SetFromLevel();
        }

        // copy constructor
        public Status(Status status)
        {
            level = status.level;
            max_health = status.max_health;
            health = status.health;
            max_damage = status.max_damage;
            min_damage = status.min_damage;
            defense = status.defense;
            attack_speed = status.attack_speed;
            mark = status.mark;
            coin = status.coin;
            is_stop = status.is_stop;
            hasBuffs = new List<Buff>(status.hasBuffs);
            addBuffs = new List<addableBuff>(status.addBuffs);
        }

        void SetFromLevel()
        {
            max_health = 50 + level;
            health = max_health;
            max_damage = 5 + level/3;
            min_damage = 3 + level/5;
            defense = 0;
            attack_speed = 2f + level/10.0f;
        }

        public int GetDamage()
        {
            return Random.Range(min_damage, max_damage);
        }
    }
}
