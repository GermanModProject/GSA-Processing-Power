using System;
using System.Collections.Generic;
using UnityEngine;

namespace ProcessingPower
{
	class Display : MonoBehaviour
    {
        private static Rect windowposition = new Rect(100, 100, 200, 200);
        private static GUIStyle windowStyle = null;

        public override void OnAwake()
        {
            if(this.vessel == FlightGlobals.ActiveVessel)
            {
                
            }
            base.OnAwake();
        }


        void OnWindow(int WindowID)
        {
            GUILayout.BeginHorizontal();
            GUILayout.Label("Hallo Welt");
            GUILayout.EndHorizontal();
        }

        void OnDraw()
        {
            windowposition = GUI.Window(66, windowposition, OnWindow,"ProcessingPower", windowStyle);
        }
    }
}
