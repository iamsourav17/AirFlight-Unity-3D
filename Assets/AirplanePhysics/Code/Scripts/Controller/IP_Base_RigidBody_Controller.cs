using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace s1
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(AudioSource))]
    public class IP_Base_RigidBody_Controller : MonoBehaviour
    {
        #region Variables
        protected Rigidbody rb;
        protected AudioSource aSource;
        #endregion
        #region BuildIn Methods
        protected virtual void Start()
        {
            rb = GetComponent<Rigidbody>();
            aSource = GetComponent<AudioSource>();

            if(aSource)
            {
                aSource.playOnAwake = false;

            }

        }

        private void FixedUpdate()
        {
            if(rb)
            {
                HandlePhysics();
            }
        }
        #endregion

        #region Custom Methods

        protected virtual void HandlePhysics()
        {

        }
        #endregion
    }
}
