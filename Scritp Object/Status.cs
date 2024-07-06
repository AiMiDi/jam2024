using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    [CreateAssetMenu(menuName = "EntityStatus")]
    public class Status : ScriptableObject
    {
        // �ȼ�
        public int level = 1;
        // �������ֵ
        public int max_health = 10;
        // ��ǰ����ֵ
        public int health = 10;
        // ��󹥻���
        public int max_damage = 1;
        // ��С������
        public int min_damage = 1;
        // ������, ��Ѫ
        public int defense = 0;
        // ӡ����
        public int mark = 0;
        // ���
        public int coin = 0;
        // �����ٶ�
        public float attack_speed = 2f;
        // �ƶ��ٶ�
        public float move_speed = 10f;
        // ��ͣ����
        public bool is_stop = true;
        // ӵ�е�buff
        public List<Buff> hasBuffs = new();
        // ��Ӹ����˵�buff
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
