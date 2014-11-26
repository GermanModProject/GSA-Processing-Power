///////////////////////////////////////////////////////////////////////////////
//
//    ProcessingPower a plugin for Kerbal Space Program from SQUAD
//    (https://www.kerbalspaceprogram.com/)
//    and part of GSA Mod
//    (http://www.kerbalspaceprogram.de)
//
//    Author: SpaceMaster
//    Copyright (c) 2014 SpaceMaster
//
//    This program, coding and graphics are provided under the following Creative Commons license.
//    Attribution-NonCommercial 3.0 Unported
//    https://creativecommons.org/licenses/by-nc/3.0/
//
//    Special Thanks to the whole KerbalSpaceProgram.de Community.
//    Special Thanks to Quazar501 for the Models and the Textures.
//
//    In Addition I want to thank the English Modding Community for the Code which I studied
//    long, long times. 
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using UnityEngine;

namespace ProcessingPower
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    class Overview : MonoBehaviour
    {
        private Rect windowposition = new Rect(100,100,300,500);
        private bool running = false;

        public GUIStyle windowstyle = new GUIStyle();
        public GUIStyle labelstyle = new GUIStyle();

        public void Start()
        {
            windowstyle = new GUIStyle(HighLogic.Skin.window);
            labelstyle = new GUIStyle(HighLogic.Skin.label);
        }
        
        public void OnDraw()
        {
            if (running)
            {
                windowposition = GUI.Window(1, windowposition, OnGUI, "Processors Overview", windowstyle);
            }
        }

        public void OnGUI(int windowId)
        {
            foreach (Part part in FlightGlobals.ActiveVessel.parts)
            {
                if (part.Resources.Contains("ProcessingPower"))
                {
                    GUILayout.BeginHorizontal();

                    GUILayout.BeginVertical();
                    GUILayout.Label(part.name,labelstyle);
                    GUILayout.EndVertical();

                    GUILayout.BeginVertical();
                    GUILayout.Label(part.Resources["ProcessingPower"].maxAmount.ToString(),labelstyle);
                    GUILayout.EndVertical();

                    GUILayout.BeginVertical();
                    GUILayout.Label(part.Resources["ProcessingPower"].amount.ToString(),labelstyle);
                    GUILayout.EndVertical();

                    GUILayout.EndHorizontal();
                }
            }

            GUI.DragWindow();
        }
    }
}
