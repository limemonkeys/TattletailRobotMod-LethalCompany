using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattleTailAnimatedItemReplacement.AssetManagement;
using TattleTailAnimatedItemReplacement.Patches;

namespace TattleTailAnimatedItemReplacement
{
    // Declaring this as a BepInEx plugin
    [BepInPlugin(modGUID, modName, modVersion)]

    // Class name can be anything
    public class TattleTailAnimatedItemReplacementBase : BaseUnityPlugin
    {
        // Must be unique
        private const string modGUID = "Limemonkeys.TattletailRobotReplacement";
        private const string modName = "Tattletail Robot Replacement";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static TattleTailAnimatedItemReplacementBase Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            // To access variables if you make patches in other files. May not be required for all mods
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            Assets.PopulateAssets();

            mls.LogInfo("Me Tattletail, me love mods!");

            harmony.PatchAll(typeof(TattleTailAnimatedItemReplacementBase));
            harmony.PatchAll(typeof(PlayerControllerBPatch));
            harmony.PatchAll(typeof(AnimatedItemPatch));
        }
    }
}
