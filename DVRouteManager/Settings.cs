using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityModManagerNet;

namespace DVRouteManager
{
    public class Settings : UnityModManager.ModSettings, IDrawable
    {
        [Header("Routing")]
        public ReversingStrategy ReversingStrategy = ReversingStrategy.ChooseBest;
        [Header("Auto Switch")]
        public bool EnableAutoSwitch = true;
        public float AutoSwitchLookaheadDistance = 200f;
        [Header("Auto Signal")]
        public bool EnableAutoSignal = false;
        public float AutoSignalLookaheadDistance = 1000f;
        [Header("Experimental")]
        public bool EnableExperimentalMultiUnitAI = false;
        [Header("Keys")]
        public KeyBinding TrainEndAlarm = new KeyBinding() { keyCode = KeyCode.N };
        public void OnChange()
        {
            //Main.ApplySettings(Preset);
        }

        public override void Save(UnityModManager.ModEntry modEntry)
        {
            Save(this, modEntry);
        }
    }
}
