using WARMachine.Variables;
using UnityEngine;

namespace WARMachine.Events
{
    public class EventTimer : MonoBehaviour
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif

        [Tooltip("Event To Raise")]
        public GameEvent Event;

        public bool ActivateEventOnStart;

        [Header("Timers Variables")]
        public FloatReference ResetTimer;
        public float currentTime;
        public bool saveCurrentTime = false;
        public FloatReference CurrentTimerSave;
        // Use this for initialization
        void Awake()
        {
            currentTime = ResetTimer;//We Where forgetting to reset timer
            if (saveCurrentTime)
            {
                CurrentTimerSave.Variable.SetValue(currentTime);
            }
        }

        //Used For Talking With Componets
        private void Start()
        {
            if (ActivateEventOnStart)
            {
                ActivateEvent();
            }
        }

        void Update()
        {
            currentTime -= Time.deltaTime;

            if (saveCurrentTime)
            {
                CurrentTimerSave.Variable.Value = currentTime;
            }

            if (currentTime <= 0)
            {
                ActivateEvent();
            }
        }

        void ActivateEvent()
        {
            Event.Raise();
            currentTime = ResetTimer;

        }
    }
}
