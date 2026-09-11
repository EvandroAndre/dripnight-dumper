using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class GameModeStatsRankManager : SingletonModule<GameModeStatsRankManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<CSVBaseData, GameModeStatsRank> _003C_003E9__2_0;

		internal GameModeStatsRank _003COnInit_003Eb__2_0(CSVBaseData input)
		{
			return null;
		}
	}

	private List<GameModeStatsRank> m_GameModeStatsRankList;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public GameModeStatsRank GetGameModeStatsRankDataByPoint(uint point)
	{
		return null;
	}

	public List<GameModeStatsRank> GetGameModeStatsRankList()
	{
		return null;
	}
}
