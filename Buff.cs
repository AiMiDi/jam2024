using UnityEngine;

namespace Assets.Script
{
    public class Buff : ScriptableObject
    {
        private float duration ;

        protected Buff(float duration= 0.0f)
        {
            this.duration = duration;
        }

        public virtual void BuffUpdate(Entity entity)
        {
            if(duration < 0)
                return;

            duration -= Time.deltaTime;
        }
    }

    [CreateAssetMenu(menuName = "StunBuff")]
    public class StunBuff : Buff
    {
        public override void BuffUpdate(Entity entity)
        {
            base.BuffUpdate(entity);
            entity.status.attack_speed = 0;
        }
    }
}