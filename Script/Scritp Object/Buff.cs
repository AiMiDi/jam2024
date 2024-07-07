using UnityEngine;

namespace Assets.Script
{
    public class Buff : ScriptableObject
    {
        public virtual void BuffUpdate(Entity entity) => Debug.Log("Not Buff");
    }

}