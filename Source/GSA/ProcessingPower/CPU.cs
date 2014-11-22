using System;
using System.Collections.Generic;
using UnityEngine;

namespace ProcessingPower
{
    public class CPU : PartModule
    {
        public int Processingpower;
        public override void OnStart(StartState state)
        {
            base.OnStart(state);

            Debug.Log("Plugin started correctly");
        }

        public override void OnLoad(ConfigNode node)
        {
            if (node.HasValue("MHZ"))
            {
                Processingpower = node.GetValue;
            }
        }

        public void GenericresourceCreator()
        {

        }
    }
}
