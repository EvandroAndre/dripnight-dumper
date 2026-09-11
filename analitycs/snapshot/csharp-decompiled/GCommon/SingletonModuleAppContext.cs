using System.Collections.Generic;

namespace GCommon;

public static class SingletonModuleAppContext
{
	private static List<ISingletonModule> Modules;

	internal static void RegisterModule(ISingletonModule module)
	{
	}

	public static void InitModules()
	{
	}

	public static void CleanupModules()
	{
	}

	public static void CleanupWhenRegionChange()
	{
	}
}
