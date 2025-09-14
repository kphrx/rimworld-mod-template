namespace ModTemplate

open RimWorld;
open Verse;
open Poet.Lib;
#if (useHarmony)
open HarmonyLib;
#endif

[<StaticConstructorOnStartup>]
type StartupConstructor() =
  static do
#if (useHarmony)
    let harmony = Harmony "AuthorName.ModTemplate"
    do harmony.PatchAll()
#endif
    log "ModTemplate loaded successfully!"
