using System.Collections.Generic;

namespace COW.Gameplay.UGC.BlockEdit;

public static class BlockEditVersionConfig
{
	public const int CurrentGraphVersion = 1;

	public const int LowestSupportedGraphVersion = 1;

	private static readonly List<int> VersionMapping;

	public static int GetGraphVersion(int editorVersion)
	{
		return 0;
	}
}
