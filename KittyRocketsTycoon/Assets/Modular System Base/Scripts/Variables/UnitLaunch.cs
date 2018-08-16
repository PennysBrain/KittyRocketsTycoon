using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace WARMachine.Variables
{
    public class UnitLaunch : MonoBehaviour
    {
        public FloatReference Destination;
        public FloatReference CurrentLocation;
        public UnityEvent StartLaunch;
        public UnityEvent ReachDestination;

        [Range(0,1)]
        public float slider;
        public FloatReference Timer;

        public float SavedTimer;
        public float SavedLocation;

        private void Start()
        {
            CurrentLocation.Variable.SetValue(this.transform.position.y);
            SavedLocation = CurrentLocation.Value;
            SavedTimer = Timer.Variable.Value;
        }

        private void Update()
        {
            Vector3 current = new Vector3(transform.position.x,CurrentLocation.Value, transform.position.z);
            Vector3 destination = new Vector3(transform.position.x, Destination.Value, transform.position.z);
            slider = Timer.Value /SavedTimer; //Slider lerp 
            transform.position = Vector3.Lerp(destination, current, slider);
            //CurrentLocation.Variable.SetValue( transform.position.y);
        }
        // Update is called once per frame
        public void Lauch()
        {
            StartLaunch.Invoke();
        }
    }
}
