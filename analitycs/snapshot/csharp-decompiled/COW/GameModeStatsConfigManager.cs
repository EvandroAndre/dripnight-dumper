using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class GameModeStatsConfigManager : SingletonModule<GameModeStatsConfigManager>
{
	public enum ESortOrder
	{
		None,
		KillAsc,
		KillDesc
	}

	public class GameModeStatsConfig
	{
		public uint SeasonID;

		public uint GameMode;

		public bool CSRankDisplay;

		public bool BrRankDisplay;

		public bool KillDisplay;

		public bool DeathDisplay;

		public bool AssistDisplay;

		public bool KDADisplay;

		public bool MatchDisplay;

		public uint GoPos;

		public string SubGopos;

		public ESortOrder Order;

		public long StartTime;

		public long EndTime;

		public bool OpenLimitedTimeRankLeaderboard;

		public int LeaderboardMainType;

		public static implicit operator GameModeStatsConfig(ModeStatsConfigDesc data)
		{
			return null;
		}
	}

	private Dictionary<uint, GameModeStatsConfig> m_GameModeToGameModeStatsConfigDic;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public GameModeStatsConfig FindGameModeStatsConfigByModeID(uint mode)
	{
		return null;
	}

	public List<uint> GetAllOpenLeaderboardGameMode()
	{
		return null;
	}

	public bool IsGameModeStatsEnabled(uint mode)
	{
		return false;
	}

	public void OnGameModeStatsGet(CSGetModeStatsConfigRes data)
	{
	}
}
