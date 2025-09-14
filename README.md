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
   dotnet new rimworld --output <Mod Directory> [--name <Mod Name>] [--mod-author <Mod Author>] [--description <Mod Description>] [--game-version <Game Version>]
   ```
2. First build, generate `v<Game Version>/Assemblies/<mod name>.dll`
   ```sh
   cd <Mod Directory>
   dotnet build
   ```

## Supported RimWorld Versions
| RimWorld | Supported          | Unity       | C#  | .NET               | Harmony |
|----------|:------------------:|-------------|-----|--------------------|---------|
| 1.6      | :white_check_mark: | 2022.3.35f1 | 9.0 | .NET Standard 2.1  | 2.4.1   |
| 1.5      | :white_check_mark: | 2019.4.30f1 | 7.3 | .NET Standard 2.0  | 2.3.3   |
| 1.4      | :white_check_mark: | 2019.4.30f1 | 7.3 | .NET Standard 2.0  | 2.2.2   |
| 1.3      | :white_check_mark: | 2019.4.30f1 | 7.3 | .NET Standard 2.0  | 2.2.2   |
| 1.2      | :white_check_mark: | 2019.2.17f1 | 7.3 | .NET Standard 2.0  | 2.2.2   |
| 1.1      | :white_check_mark: | 2019.2.17f1 | 7.3 | .NET Standard 2.0  | -       |
| 1.0      | :x:                | 5.6.5f1     | 4.0 | .NET Framework 3.5 | -       |

## Technical Details
Based on `dotnet new classlib -f netstandard2.1`, added RimWorld's `Assembly-CSharp` and `UnityEngine.CoreModule` references.
