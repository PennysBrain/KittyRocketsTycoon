using System.Collections.Generic;
using UnityEngine;

namespace WARMachine.Elements
{ 
    [CreateAssetMenu]
public class AttackElement : ScriptableObject
    {
        [Tooltip("The Elements that are defeated by this element")]
        public List<AttackElement> DefeatedElements = new List<AttackElement>();
    }
}