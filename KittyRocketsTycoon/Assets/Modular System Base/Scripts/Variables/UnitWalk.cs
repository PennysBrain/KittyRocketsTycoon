using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
namespace WARMachine.Variables
{
    public class UnitWalk : MonoBehaviour
    {
        public FloatReference Destination;
        public FloatReference CurrentLocation;
        public UnityEvent StartLaunch;
        public UnityEvent ReachDestination;

       // public bool pingPong;
       public bool flip;
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
            Vector3 current = new Vector3(CurrentLocation.Value, transform.position.y, transform.position.z);
            Vector3 destination = new Vector3( Destination.Value, transform.position.y, transform.position.z);
            slider = Timer.Value /SavedTimer; //Slider lerp 
            if (!flip)
            {
                transform.position = Vector3.Lerp(destination, current, slider);


            }
            if(flip)
            {
               
                    transform.position = Vector3.Lerp(current, destination, slider);
                
            }
            //CurrentLocation.Variable.SetValue( transform.position.y);
        }
        // Update is called once per frame
        public void Walk()
        {
            StartLaunch.Invoke();
        }

        public void Flip()
        {
            flip = !flip; 
        }
    }
}
