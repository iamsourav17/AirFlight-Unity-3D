using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace s1
{
    [CustomEditor(typeof(IP_Base_Airplane_Input))]
    public class IP_Base_Airplane_Input_Editor : Editor
    {
        #region Variables
        private IP_Base_Airplane_Input targetInput;
        #endregion

        #region BuiltInMethod
        void OnEnable()
        {
            targetInput = (IP_Base_Airplane_Input)target;
        }
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            string debugInfo = "";

            debugInfo += "Pitch: " + targetInput.Pitch + "\n";
            debugInfo += "Roll: " + targetInput.Roll + "\n";
            debugInfo += "Yaw: " + targetInput.Yaw + "\n";
            debugInfo += "Throttle: " + targetInput.Throttle + "\n";
            debugInfo += "Brake: " + targetInput.Brake + "\n";
            debugInfo += "Flaps: " + targetInput.Flaps + "\n";

            GUILayout.Space(20);

            EditorGUILayout.TextArea(debugInfo, GUILayout.Height(100));

            Repaint();
        }
        #endregion
        // Start is called before the first frame update

    }
}
