// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UEImgui : ModuleRules
{
	public UEImgui(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				"Imgui" ,
			});
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
#if UE_4_26_OR_LATER
				"DeveloperSettings",
#endif
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				"InputCore",
				"ApplicationCore" ,
				"Projects" ,
				"RenderCore" ,
				"RHI" ,
			});

		if (Target.Type == TargetType.Editor)
		{
			PrivateDependencyModuleNames.AddRange(
				new string[]
				{
					"MainFrame"	,
					"LevelEditor" ,
					"UnrealEd" ,
				});
		}
		
		// Enable if use SLua
		// PrivateDefinitions.Add("ENABLE_LUA_BINDING");
		// PrivateDependencyModuleNames.Add("slua_unreal");
	}
}
