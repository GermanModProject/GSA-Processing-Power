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
    class CPU : PartModule
    {
        #region KSPFields

        [KSPField(isPersistant = false, guiActive = true)]
        public string Enabled;

        [KSPField(isPersistant=true)]
        public bool isOperating;

        [KSPField]
        public int Tier;

        [KSPField(guiActive = true, guiActiveEditor = true)]
        public int Output=3;

        [KSPField(guiActive = true)]
        public double Consumption;
        #endregion

        #region KSPEvents
        [KSPEvent(guiActiveUnfocused = true, guiActive = true, unfocusedRange = 4f, guiName = "Toggle CPU")]
        public void Toggle()
        {
            isOperating = !isOperating;
        }
        #endregion

        #region override voids
        public override void OnStart(StartState state)
        {
            base.OnStart(state);
            Debug.Log("Tier1CPU Started now");
            isOperating = true;
        }

        public override void OnLoad(ConfigNode node)
        {
            base.OnLoad(node);
            try
            {
                if (node.HasValue("OutputValue"))
                {
                    int.TryParse(node.GetValue("OutputValue"), out Output);
                }
                if (node.HasValue("´Tier"))
                {
                    int.TryParse(node.GetValue("Tier"), out Output);
                }
            }
            catch { }
           
        }

        public override void OnFixedUpdate()
        {
            base.OnFixedUpdate();

            ResourceConverter();

            if (isOperating)
            {
                Enabled = "Enabled";
            }
            else
            {
                Enabled = "Disabled";
            }

            Consumption = Output / 10 ^ Tier;
        }
        #endregion

        #region selfmade
        public void ResourceConverter()
        {
            if (isOperating)
            {
                part.RequestResource("ElectricCharge", Output/10^Tier);
                part.RequestResource("ProcessingPower", -Output);
            }

        }
        #endregion
    }
}
