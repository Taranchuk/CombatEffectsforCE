﻿using Verse;

namespace CombatEffectsCE
{
    /// <summary>
    /// Definition of the settings for the mod
    /// </summary>
    internal class CombatEffectsCESettings : ModSettings
    {
        public bool ExtraBlood = true;

        /// <summary>
        /// Saving and loading the values
        /// </summary>
        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref ExtraBlood, "ExtraBlood", true, false);
        }
    }
}