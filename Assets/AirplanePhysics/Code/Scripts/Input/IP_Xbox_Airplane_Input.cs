using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 namespace s1
{
    public class IP_Xbox_Airplane_Input : IP_Base_Airplane_Input
    {
        #region Variables
        public float throttleSpeed = 0.1f;
       

        #endregion

        #region Custom Methods
        protected override void HandleInput()
        {

            //MainInput
            pitch = Input.GetAxis("Vertical");
            roll = Input.GetAxis("Horizontal");

            //CustomInput
            yaw = Input.GetAxis("X_RH_Stick");
            throttle = Input.GetAxis("X_RV_Stick");
            stickyThrottleControl();

            //BrakeInput
            brake = Input.GetAxis("Fire1");

            //FlapsInput
            if (Input.GetButtonDown("X_R_Bumper"))
            {
                flaps += 1;
            }
            if (Input.GetButtonDown("X_L_Bumper"))
            {
                flaps -= 1;
            }
            flaps = Mathf.Clamp(flaps, 0, maxFlapIncrement);

        }

        void stickyThrottleControl()
        {
            stickyThrottle = stickyThrottle + (-throttle * throttleSpeed * Time.deltaTime);
            stickyThrottle = Mathf.Clamp01(stickyThrottle);
            Debug.Log(stickyThrottle);

        }
        #endregion



    }

}
