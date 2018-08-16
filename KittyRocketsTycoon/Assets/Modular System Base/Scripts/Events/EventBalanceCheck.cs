using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WARMachine.Variables;

namespace WARMachine.Events
{
    public class EventBalanceCheck : MonoBehaviour
    {
        [Tooltip("Event To Raise If A > B")]
        public GameEvent Event;

        public bool ActivateEvent = false;

        public FloatReference A;
        public FloatReference B;


        // Use this for initialization
       public void Activate()
        {
            if (A.Value >= B.Value)
                Event.Raise();
            else
            {
                Debug.Log("not enough " + A.Value.ToString() +" >= "+ B.Value.ToString());
            }
        }
    }
}
