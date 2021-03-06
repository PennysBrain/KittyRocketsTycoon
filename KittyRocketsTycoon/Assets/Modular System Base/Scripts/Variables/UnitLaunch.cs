﻿using System.Collections;
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
        public bool flip;
        Vector3 current;
        Vector3 destination;

        private void Start()
        {
            CurrentLocation.Variable.SetValue(this.transform.position.x);
            SavedLocation = CurrentLocation.Value;
            SavedTimer = Timer.Variable.Value;

             current = new Vector3(transform.position.x, CurrentLocation.Value, transform.position.z);
             destination = new Vector3(transform.position.x, Destination.Value, transform.position.z);
        }

        private void Update()
        {
            //CurrentLocation.Variable.SetValue(this.transform.position.x);

            
           

            if (!flip)
            {
                transform.position = Vector3.Lerp(destination, current, slider);
            }
            if (flip)
            {
                transform.position = Vector3.Lerp(current, destination, slider);
            }
            slider = Timer.Value / SavedTimer; //Slider lerp 
            //CurrentLocation.Variable.SetValue( transform.position.y);
        }
        // Update is called once per frame
        public void Lauch()
        {
            StartLaunch.Invoke();
            ReachDestination.Invoke();
        }

        public void Flip()
        {
            flip = !flip;
        }
    }
}
