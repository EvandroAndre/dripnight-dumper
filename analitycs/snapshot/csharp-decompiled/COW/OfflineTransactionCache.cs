using System.Collections.Generic;
using SimpleJSON;

namespace COW;

public static class OfflineTransactionCache
{
	private const string KEY_V1 = "OfflineTransactions";

	private const string KEY_V2_FORMAT = "OfflineTransactions_{0}";

	private const string KEY_V3_FORMAT = "OfflineTransactionsV3_{0}";

	private static string GetOpenID()
	{
		return null;
	}

	private static string GetV2Key()
	{
		return null;
	}

	private static string GetV3Key()
	{
		return null;
	}

	private static bool ShouldLog()
	{
		return false;
	}

	private static string NormalizeProductId(string productIdentifier)
	{
		return null;
	}

	private static long GetServerTimestamp()
	{
		return 0L;
	}

	private static JSONNode ParseJson(string raw)
	{
		return null;
	}

	private static JSONNode ReadV1()
	{
		return null;
	}

	private static JSONNode ReadV2()
	{
		return null;
	}

	private static JSONNode ReadV3()
	{
		return null;
	}

	private static bool HasValue(JSONNode json, string productId)
	{
		return false;
	}

	private static void ClearFromKey(string key, string productId, string version)
	{
	}

	private static void CollectProductIds(JSONNode json, HashSet<string> productIds)
	{
	}

	public static void Cache(string productIdentifier)
	{
	}

	public static void Clear(string productIdentifier)
	{
	}

	public static bool Contains(string productIdentifier)
	{
		return false;
	}

	public static List<string> FilterPending(IEnumerable<string> productIds)
	{
		return null;
	}

	public static long GetCachedTimestamp(string productIdentifier)
	{
		return 0L;
	}
}
