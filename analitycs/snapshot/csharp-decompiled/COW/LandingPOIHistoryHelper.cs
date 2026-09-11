using System;
using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW;

public static class LandingPOIHistoryHelper
{
	[Serializable]
	public class LandingPOIEntry
	{
		public string poiId;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<GILFNHENLJF> _003C_003E9__16_0;

		internal bool _003CGetPOIWorldPosition_003Eb__16_0(GILFNHENLJF e)
		{
			return false;
		}
	}

	private const string HistoryKeyFormat = "LandingPOI_History_{0}_{1}_{2}";

	private const string LastMatchKeyFormat = "LandingPOI_LastMatch_{0}_{1}_{2}";

	private static Dictionary<string, List<LandingPOIEntry>> m_HistoryCache;

	private static Dictionary<string, string> m_LastMatchCache;

	private static List<GILFNHENLJF> m_AirPlaceNameConfigCache;

	private static Dictionary<uint, List<DLOGLJCCJPJ>> m_PlaceNameDataCache;

	public static int HistoryCountLimit => 0;

	private static string GetHistoryKey(ulong accountId, uint gameMode, uint mapId)
	{
		return null;
	}

	private static string GetLastMatchKey(ulong accountId, uint gameMode, uint mapId)
	{
		return null;
	}

	public static List<LandingPOIEntry> GetHistory(ulong accountId, uint gameMode, uint mapId)
	{
		return null;
	}

	public static string GetLastMatchPOI(ulong accountId, uint gameMode, uint mapId)
	{
		return null;
	}

	public static void RecordLanding(ulong accountId, uint gameMode, uint mapId, string poiId)
	{
	}

	private static void SaveHistoryToLocal(string key, List<LandingPOIEntry> list)
	{
	}

	public static string GetFrequentPOI(List<LandingPOIEntry> history, float thresholdPercent)
	{
		return null;
	}

	public static Vector3 GetPOIWorldPosition(string poiId)
	{
		return default(Vector3);
	}
}
