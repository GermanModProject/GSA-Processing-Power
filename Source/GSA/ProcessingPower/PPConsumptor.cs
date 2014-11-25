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
    class PPConsumptor:PartModule
    {
        [KSPField(isPersistant = false, guiActive = true)]
        public double Consumption;

        private double lasttime;

        /// <summary>
        /// initialization of the Module
        /// </summary>
        /// <param name="node"></param>
        public override void OnLoad(ConfigNode node)
        {
            base.OnLoad(node);
            if (node.HasValue("Consumption"))
            {
                double.TryParse(node.GetValue("Consumption"), out this.Consumption);
            }
            else
            {
                Debug.Log("no correct value for the PCConsumtor Value");
                Consumption = 0;
            }
        }
        /// <summary>
        /// Called every frame and consumps the amount of ProcPower
        /// </summary>
        public override void OnFixedUpdate()
        {
            base.OnFixedUpdate();

           if(Time.time-lasttime > 1&&part.enabled)
           {
               lasttime = Time.time;
               part.RequestResource("ProcessingPower", Consumption);
           }
        }
    }
}
