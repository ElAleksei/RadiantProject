

using UnrealBuildTool;
using System.Collections.Generic;

public class RadiantProject2EditorTarget : TargetRules
{
	public RadiantProject2EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "RadiantProject2" } );
	}
}
