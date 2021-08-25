using HarmonyLib;
using NeosModLoader;
using FrooxEngine;
namespace KillLogSpam
{
    public class KillLogSpam : NeosMod
    {
        public override string Name => "KillLogSpam";
        public override string Author => "eia485";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/EIA485/NeosKillLogSpam/";
        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("net.eia485.KillLogSpam");
            harmony.PatchAll();

        }
        [HarmonyPatch(typeof(WorldConfiguration), "FieldChanged")]
        class KillLogSpamPatch
        {
            public static bool Prefix(IChangeable obj)
            {
                return false;
            }
        }
    }
}