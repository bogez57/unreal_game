using UnrealBuildTool;
using System.Collections.Generic;

//This tells unreal how to build our project by specifying what other modules my module depends on and needs to be available for use for developing my game 
public class bgz_core : ModuleRules
{
    public bgz_core(ReadOnlyTargetRules Target) : base(Target)
    {

        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        bEnforceIWYU = true;

        PublicDependencyModuleNames.AddRange(new string [] { "Core", "CoreUObject", "Engine" });
        PrivateDependencyModuleNames.AddRange(new string [] {});
    }
}