using Harmony;
using System;
using System.Reflection;
using Verse;

namespace BetterCopyBuilding
{
    [HarmonyPatch(typeof(ThingFilter), "RecalculateDisplayRootCategory", new Type[0])]
    static class ThingFilter_RecalculateDisplayRootCategory_Fix
    {
        public static bool Prefix(ThingFilter __instance)
        {
            __instance.DisplayRootCategory = ThingCategoryNodeDatabase.RootNode;
            return false;
        }
    }
}
