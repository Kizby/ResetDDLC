
using BepInEx;
using HarmonyLib;
using RenpyLauncher;

namespace TestDDLCMod
{
    [BepInPlugin("org.kizbyspark.plugins.resetDDLC", "Reset DDLC", "0.1.0.0")]
    [BepInProcess("Doki Doki Literature Club Plus.exe")]
    public class ResetDDLC : BaseUnityPlugin
    {
        void Awake()
        {
            Harmony harmony = new Harmony("org.kizbyspark.plugins.resetDDLC");
            harmony.PatchAll();
        }
    }


    public static class DoReset
    {
        [HarmonyPatch(typeof(LauncherMain), "Start")]
        static void Postfix()
        {
            LauncherParameters.ResetDDLC = true;
        }
    }
}
