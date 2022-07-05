/*
    Builds a stand alone game (exe - requires cooking your content)
*/

using UnrealBuildTool;
using System.Collections.Generic;

//This target tells unreal what module to use in order to build the game, which all code is currently stored within a bgz_core module (Think unreal expects 1 main 'game' module to house whatever code/submodules you have in your gaem)
public class bgz_gameTarget: TargetRules
{
    public bgz_gameTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V2; 
        ExtraModuleNames.AddRange(new string[] {"bgz_core"});
    }
}