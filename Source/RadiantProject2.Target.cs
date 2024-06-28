

using UnrealBuildTool;
using System.Collections.Generic;

public class RadiantProject2Target : TargetRules
{
	public RadiantProject2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "RadiantProject2" } );
	}
}
