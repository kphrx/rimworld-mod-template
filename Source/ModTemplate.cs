using RimWorld;
using Verse;
#if (UseHarmony)
using HarmonyLib;
#endif

namespace ModTemplate
{
    [StaticConstructorOnStartup]
    public class ModTemplate
    {
        static ModTemplate()
        {
#if (UseHarmony)
            var harmony = new Harmony("AuthorName.ModTemplate");
            harmony.PatchAll();
#endif
            Log.Message("ModTemplate loaded successfully!");
        }
    }
}
