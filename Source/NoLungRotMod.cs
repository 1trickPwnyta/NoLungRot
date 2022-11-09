using HarmonyLib;
using Verse;

namespace NoLungRot
{
    public class NoLungRotMod : Mod
    {
        public const string PACKAGE_ID = "nolungrot.1trickPwnyta";
        public const string PACKAGE_NAME = "No Lung Rot";

        public NoLungRotMod(ModContentPack content) : base(content)
        {
            var harmony = new Harmony(PACKAGE_ID);
            harmony.PatchAll();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }
    }
}
