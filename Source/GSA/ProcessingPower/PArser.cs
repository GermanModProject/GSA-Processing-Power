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
    static class Parser
    {
        public static int GetintValue(this ConfigNode node, string name)
        {
            int value;
            if (node.HasValue(name))
            {
                int.TryParse(node.GetValue(name), out value);
                return value;
            }
            else
            {
                return 0;
            }
        }
    }
}
