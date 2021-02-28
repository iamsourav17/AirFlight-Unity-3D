using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace s1
{

    [RequireComponent(typeof(WheelCollider))]
    public class IP_Airplane_Wheel : MonoBehaviour
    {
        #region Variable
        private WheelCollider wheelCol;
        #endregion

        #region BuiltIn method
         void Start()
        {
            wheelCol = GetComponent<WheelCollider>();
            
        }
        #endregion


        #region Custom Method

        public void InitWheel()
        {
            if(wheelCol)
            { 
            wheelCol.motorTorque = 0.0000000001f;
            }
        }
        #endregion
    }
}
