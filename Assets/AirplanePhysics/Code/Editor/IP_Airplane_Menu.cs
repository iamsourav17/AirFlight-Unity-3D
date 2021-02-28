using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace s1
{

    public class IP_Airplane_Menu
    {

        [MenuItem("Airplane Tools/Create New Airplane")]
        
        public static void CreateAirPlane()
        {
            GameObject currentSelected = Selection.activeGameObject;
            if(currentSelected)
            {
               IP_Airplane_Controller currentController = currentSelected.AddComponent<IP_Airplane_Controller>();
                GameObject currentCOG = new GameObject("COG");
                currentCOG.transform.SetParent(currentSelected.transform);
                currentController.centerOfGravity = currentCOG.transform;
            }

        }

    }
}


