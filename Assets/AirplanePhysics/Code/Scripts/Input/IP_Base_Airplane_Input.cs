using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace s1
{

    public class IP_Base_Airplane_Input : MonoBehaviour
    {

        #region variables
        protected float pitch = 0f;
        protected float roll = 0f;
        protected float yaw = 0f;
        protected float throttle = 0f;
        protected int flaps = 0;
        protected  int maxFlapIncrement = 2;
        protected float brake = 0f;

        protected float stickyThrottle;
        public float StickyThrottle
        {
            get { return stickyThrottle; }
        }
        #endregion

        #region properties
        public float Pitch
        {
            get { return pitch; }
        }
        public float Roll
        {
            get { return roll; }
        }
        public float Yaw
        {
            get { return yaw; }
        }
        public float Throttle
        {
            get { return throttle; }
        }
        public int Flaps
        {
            get { return flaps; }
        }
        public float Brake
        {
            get { return brake; }
        }
        #endregion

        #region BuiltinMethod
        
        void Start()
        {

        }

       
        void Update()
        {
            HandleInput();

        }

        #endregion

        #region CustomMethods

        protected virtual void HandleInput()
        {   
            //MainInput
            pitch = Input.GetAxis("Vertical");
            roll = Input.GetAxis("Horizontal");

            //CustomInput
            yaw = Input.GetAxis("Yaw");
            throttle = Input.GetAxis("Throttle");

            //BrakeInput
            brake = Input.GetKey(KeyCode.Space)? 1f:0f;

            //FlapsInput
            if(Input.GetKeyDown(KeyCode.F))
            {
                flaps += 1;
            }
            if(Input.GetKeyDown(KeyCode.G))
            {
                flaps -= 1;
            }
            flaps = Mathf.Clamp(flaps, 0, maxFlapIncrement);


            


        }
        #endregion
    }

}
