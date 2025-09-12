# RimWorld Mod Template

## Installation
```sh
git clone https://github.com/kphrx/rimworld-mod-template.git
dotnet new install ./rimworld-mod-template
```

## Usage
1. Create project.
   ```sh
   cd /path/to/Mods

   # output to `<Mod Directory>/` and set mod name to <Mod Directory> or <Mod Name>
   dotnet new rimworld --output <Mod Directory> [--name <Mod Name>] [--mod-author <Mod Author>] [--description <Mod Description>]
   ```
2. First build, generate `Assemblies/<mod name>.dll`
   ```sh
   cd <Mod Directory>
   dotnet build
   ```

## Technical Details
Based on `dotnet new classlib -f netstandard2.1`, added RimWorld's `Assembly-CSharp` and `UnityEngine` references.

Currently version (v1.6) used Unity 2022.3.35. This version supports .NET Standard 2.1 and C# 9.0.
