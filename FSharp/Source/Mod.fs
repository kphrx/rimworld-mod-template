namespace ModTemplate

open RimWorld;
open Verse;
#if (useHarmony)
open HarmonyLib;
#endif

[<StaticConstructorOnStartup>]
type StartupConstructor() =
  static do
#if (useHarmony)
    let harmony = Harmony("AuthorName.ModTemplate")
    do harmony.PatchAll()
#endif
    Log.Message("ModTemplate loaded successfully!")
