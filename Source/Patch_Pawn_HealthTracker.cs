using HarmonyLib;
using RimWorld;
using Verse;

namespace NoLungRot
{
    [HarmonyPatch(typeof(Pawn_HealthTracker))]
    [HarmonyPatch(nameof(Pawn_HealthTracker.AddHediff))]
    [HarmonyPatch(new[] { typeof(Hediff), typeof(BodyPartRecord), typeof(DamageInfo), typeof(DamageWorker.DamageResult) })]
    public static class Patch_Pawn_HealthTracker_AddHediff
    {
        public static bool Prefix(Hediff hediff)
        {
            return hediff.def != HediffDefOf.LungRotExposure;
        }
    }
}
