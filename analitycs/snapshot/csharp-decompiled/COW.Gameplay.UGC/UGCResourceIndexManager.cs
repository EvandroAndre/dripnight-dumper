using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public static class UGCResourceIndexManager
{
	private const string RESOURCE_DATA = "ResourceIndex.bytes";

	private const string RESOURCE_JSON = "ResourceIndex.json";

	private static readonly Dictionary<string, UGCResourceIndexEntry> s_Index;

	private static bool s_Loaded;

	private static bool s_HasResourceIndex;

	public static bool TryGet(string uuidWithVersion, out UGCResourceIndexEntry entry)
	{
		entry = null;
		return false;
	}

	public static void Upsert(UGCResourceShopMetaData metaData)
	{
	}

	public static bool IsResourceIndexReady()
	{
		return false;
	}

	public static void MarkResourceIndexReady()
	{
	}

	public static void Remove(string uuidWithVersion)
	{
	}

	private static void EnsureLoaded()
	{
	}

	private static void Save()
	{
	}

	private static string GetResourceDataPath()
	{
		return null;
	}

	private static string GetResourceJsonPath()
	{
		return null;
	}

	private static string BuildUUIDWithVersion(ulong resourceId, int version)
	{
		return null;
	}
}
