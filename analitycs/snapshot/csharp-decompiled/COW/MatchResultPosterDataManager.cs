using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class MatchResultPosterDataManager : SingletonModule<MatchResultPosterDataManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MatchResultShareDataConfig> _003C_003E9__7_0;

		internal int _003CGetShareDataNeedShow_003Eb__7_0(MatchResultShareDataConfig a, MatchResultShareDataConfig b)
		{
			return 0;
		}
	}

	private CSVAsyncDataMap<uint, MatchResultCommentsData> m_MatchResultCommentsDataMap;

	private CSVAsyncDataMap<uint, MatchResultShareDataConfig> m_MatchResultShareDataConfigMap;

	private int MaxShowDataCount;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void InitConfigAfterLogin()
	{
	}

	public MatchResultCommentsData GetMatchResultCommentsData(uint id)
	{
		return null;
	}

	public List<MatchResultShareShowData> GetShareDataNeedShow(uint gamemode, MatchStats matchStats)
	{
		return null;
	}

	private bool CheckAndGetCurShareDataShowData(MatchResultShareDataConfig data, MatchStats matchStats, ref float value, ref bool isHighLight, ref uint level)
	{
		return false;
	}

	private void GetDataShowLevel(MatchResultShareDataConfig data, float value, ref uint level, ref bool isHighLight)
	{
	}

	public List<MatchResultShareDataConfig> GetShareDataByGameMode(uint gamemode)
	{
		return null;
	}
}
