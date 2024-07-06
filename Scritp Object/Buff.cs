using UnityEngine;

namespace Assets.Script
{
    public class Buff : ScriptableObject
    {
        protected float duration ;

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

    
}