using GCommon;

namespace COW;

internal class PCMatchResultScoreConfigDataManager : SingletonModule<PCMatchResultScoreConfigDataManager>
{
	private const string overrideFileName = "scorelist.json";

	private MatchResultScoreListConfig m_ScoreListConfig;

	public MatchResultScoreListConfig ScoreList => null;

	protected override void OnInit()
	{
	}

	public uint GetScorePerKillByGroup(uint group)
	{
		return 0u;
	}

	public uint GetScoreByRankAndGroup(uint group, uint rank)
	{
		return 0u;
	}

	protected override void OnCleanup()
	{
	}
}
