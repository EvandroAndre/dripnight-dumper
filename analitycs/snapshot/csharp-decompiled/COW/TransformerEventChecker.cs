using System;
using System.Collections.Generic;
using System.Reflection;

namespace COW;

public static class TransformerEventChecker
{
	public static void CheckSkipRenameConsistency()
	{
	}

	private static int CountSkipRenameAttributes(Type type)
	{
		return 0;
	}

	private static bool HasSkipRenameAttribute(MethodInfo method)
	{
		return false;
	}

	public static void LogSkipRenameMethodDifferences()
	{
	}

	private static List<string> GetSkipRenameMethodNames(Type type)
	{
		return null;
	}

	private static void FindMethodDifferences(List<string> transformerMethods, List<string> uiMaleAvatarMethods, List<string> onlyInTransformer, List<string> onlyInUIMaleAvatar)
	{
	}
}
