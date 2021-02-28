using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace s1
{
    public class IP_Airplane_Propeller : MonoBehaviour
    {

        #region Variables
        [Header("Propeller Properties")]
        public float minQuadRPM = 300f;
        public float minTextureSwap = 600f;
        public GameObject mainProp;
        public GameObject blurredProp;

        [Header("Material Properties")]
        public Material blurredPropMat;
        public Texture2D blurLevel1;
        public Texture2D blurLevel2;
        #endregion

        #region Builin Methods

        // Start is called before the first frame update
        void Start()
        {
            if (mainProp && blurredProp)
            {
                HandleSwapping(0f);
            }

        }

        // Update is called once per frame
        void Update()
        {

        }

        #endregion

        #region Custom Methods
        public void HandlePropeller(float currentRPM)
        {
            float degreePerSecond = ((currentRPM * 360f) / 60f) * Time.deltaTime;
            transform.Rotate(Vector3.forward, degreePerSecond);


            //Handle Propeller Swapping

            if(mainProp && blurredProp)
            {
                HandleSwapping(currentRPM);
            }

        }

        void HandleSwapping(float currentRPM)
        {
            if(currentRPM > minQuadRPM)
            {
                blurredProp.gameObject.SetActive(true);
                mainProp.gameObject.SetActive(false);
                if(blurredPropMat && blurLevel1 && blurLevel2)
                {
                    if(currentRPM > minTextureSwap)
                    {
                        blurredPropMat.SetTexture("_MainTex", blurLevel2);
                    }
                    else
                    {
                        blurredPropMat.SetTexture("_MainTex", blurLevel1);
                    }
                }
            }
            else
            {
                blurredProp.gameObject.SetActive(false);
                mainProp.gameObject.SetActive(true);
            }

        }
        #endregion
    }
}
