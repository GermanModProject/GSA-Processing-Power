using System;
using System.Collections.Generic;
using UnityEngine;

namespace ProcessingPower
{
    public class ProcessorModule : PartModule
    {
        public override void OnStart(StartState state)
        {
            base.OnStart(state);

            Debug.Log("Plugin started correctly");
        }
    }
}
