using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TattleTailAnimatedItemReplacement.Patches
{
    // Pointing to file in Lethal Company containing code we wish to modify
    [HarmonyPatch(typeof(PlayerControllerB))]
    //[HarmonyPatch(typeof(AnimatedItem))]
    internal class PlayerControllerBPatch
    {
        //Use the following if possible (issues referencing if private)[HarmonyPatch(nameof(PlayerControllerB.Update))]
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        static void infiniteSprintPatch(ref float ___sprintMeter)
        {
            ___sprintMeter = 1f;
        }
    }
}
