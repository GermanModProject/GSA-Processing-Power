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
/*
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ProcessingPower
{
    public class Tier1CPU : PartModule
    {

        [KSPField(isPersistant = false, guiActive=true)] 
        public int Processingpower;

        [KSPField(isPersistant=true, guiActive=true)]
        public string Enabled;

        public bool isOperating;

        public override void OnStart(StartState state)
        {
            base.OnStart(state);
            Debug.Log("Tier1CPU Started now");
        }

        public override void OnLoad(ConfigNode node)
        {
            Processingpower = 1;
            isOperating = true;
        }

        public void ResourceConverter()
        {
            if (isOperating)
            {
                part.RequestResource("ElectricCharge", 5);
                part.RequestResource("ProcessingPower", -1);
            }
            
        }

        public override void OnUpdate()
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
        }


        [KSPEvent(guiActiveUnfocused = true, guiActive = true, unfocusedRange = 4f, guiName="Toggle CPU")]
        public void Toggle()
        {
            isOperating = !isOperating;
        }
    }
}*/
