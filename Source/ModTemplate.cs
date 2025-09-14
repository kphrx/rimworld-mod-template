using RimWorld;
using Verse;
#if (useHarmony)
using HarmonyLib;
#endif

namespace ModTemplate
{
    [StaticConstructorOnStartup]
    public class ModTemplate
    {
        static ModTemplate()
        {
#if (useHarmony)
            var harmony = new Harmony("AuthorName.ModTemplate");
            harmony.PatchAll();
#endif
            Log.Message("ModTemplate loaded successfully!");
        }
    }
}
