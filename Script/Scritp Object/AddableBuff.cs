using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script
{
    [CreateAssetMenu(menuName = "AddableBuff")]
    public class addableBuff : ScriptableObject
    {
        public Buff buff;
        public int probability;
    }
}