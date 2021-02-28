using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace s1
{
    public class IP_Basic_Follow_Camera : MonoBehaviour
    {

        #region Variables
        [Header("Basic Follow Camera Properties")]

        public Transform target;
        public float distance = 10f;
        public float height = 6f;
        public Vector3 smoothVelocity;
        public float smoothSpeed = 0.5f;
        #endregion

        #region Builtin Methods

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (target)
            {
                HandleCamera();
            }

        }
        #endregion

        #region Custom Methods

        protected virtual void HandleCamera()
        {
            //follow target
            Vector3 wantedPosition = target.position +(- target.forward * distance)+ (Vector3.up * height) ;
            transform.position = Vector3.SmoothDamp(transform.position, wantedPosition, ref smoothVelocity, smoothSpeed);
            transform.LookAt(target);


        }

        #endregion
    }
}
