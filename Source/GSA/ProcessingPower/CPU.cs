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

        [KSPField(guiActive=true, guiName="isOperating")]
        public bool isOperating;

        [KSPField(guiActive=true)]
        public int Tier;

        [KSPField(guiActive = true, guiActiveEditor = true)]
        public int Output;

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

            isOperating = true;
           
        }

        public override void OnUpdate()
        {
            base.OnFixedUpdate();

            ResourceConverter();

            Consumption = Output / 10 ^ Tier;
        }
        #endregion

        #region selfmade
        public void ResourceConverter()
        {
            if (isOperating)
            {
                part.RequestResource("ElectricCharge", 0.5);
                part.RequestResource("ProcesingPower", -5);
            }

        }
        #endregion
    }
}
