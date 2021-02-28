using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace s1
{

    public class IP_Airplane_Engine : MonoBehaviour
    {
        #region Varibales
        [Header("Engine Properties")]
        public float maxForce = 5000f;
        public float maxRPM = 2550f;

        public AnimationCurve powerCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);

        [Header("Propeller")]
        public IP_Airplane_Propeller propeller;
        #endregion

        #region BuiltinMethods
        #endregion

        #region CustomMethods
        public Vector3 CalculateForce(float throttle)
        {
            //Calculate Power
            float finalThrottle = Mathf.Clamp01(throttle);
            finalThrottle = powerCurve.Evaluate(finalThrottle);

            //Claculate RPM
            float currentRPM = finalThrottle * maxRPM;
            if(propeller)
            {
                propeller.HandlePropeller(currentRPM);
            }

            //Create Force
            float finalPower = finalThrottle * maxForce;
            Vector3 finalForce = transform.TransformDirection(transform.forward) * finalPower;    

            return finalForce;
        }

        #endregion
    }
}