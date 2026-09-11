using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelHippoCrisisLadderMatch : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public uint rankGroup;

		internal bool _003CGetLevelDataByRankGroup_003Eb__0(LadderLevelData l)
		{
			return false;
		}
	}

	public const uint PropID_HCRankInfoRefreshed = 2u;

	public const uint PropID_HCSeasonInfoRefreshed = 4u;

	public const uint PropID_HCSeasonStatsRefresh = 8u;

	private Dictionary<uint, LadderLevelData> m_HCLadderLevelDataDic;

	private List<LadderLevelData> m_HCLadderLevelDataList;

	private List<LadderLevelData> m_HCExhibitLevelDataList;

	private CSPlayerHippoRankingInfoRes m_CurrentRankInfo;

	public CSPlayerHippoRankingSeasonStatsRes CurSelfHippoRankingSeasonStats;

	public uint MaxHCRank;

	private CSGetCurrentOrRecentHippoRankingSeasonConfigRes m_CurrentOrRecentHippoRankingSeasonConfig;

	private uint m_CurOwnTotalValue;

	private bool m_CanRequestCurTotalValue;

	private bool m_CanRequestHippoRankingSeasonStats;

	public List<LadderLevelData> RankUpRewardList;

	private CDTimeData m_CdRankInfoTimeData;

	private int m_CdOfReqRankInfo;

	public List<LadderLevelData> HCLadderLevelDataList => null;

	public List<LadderLevelData> HCExhibitLevelDataList => null;

	public CSPlayerHippoRankingInfoRes CurrentRankInfo => null;

	public uint CurOwnTotalValue => 0u;

	public bool ShowRankUpReward => false;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void ProcessSeasonInfoConfig(CSGetCurrentOrRecentHippoRankingSeasonConfigRes seasonConfig)
	{
	}

	public bool IsCurrentSeasonOpen()
	{
		return false;
	}

	public HippoCrisisSeasonInfoDesc GetCurrentSeasonInfo()
	{
		return null;
	}

	public void SetCurSeasonHippoCrisisLevelData(uint seasonId)
	{
	}

	public void SetSeasonAwardConfig(CSGetCurrentOrRecentHippoRankingSeasonConfigRes seasonConfig)
	{
	}

	public void InitRankUpRewardData(uint rank_before, uint rank_after)
	{
	}

	public void AfterHippoCrisisLadderMatch(MatchIncome incomeData)
	{
	}

	public void RequestGetHCRankingsInfo(bool immediately = false)
	{
	}

	public void RequestGetPlayerRankingSeasonStats(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	public void RequestHippoCrisisInventoryTotalValue()
	{
	}

	public uint GetHCLadderMatchNextShowRank(uint curRank)
	{
		return 0u;
	}

	public ResourceID GetHCRankIcon(int rank, LadderRankIconType iconType = LadderRankIconType.SmallIcon)
	{
		return default(ResourceID);
	}

	public List<LadderLevelData> GetLevelDataByRankGroup(uint rankGroup)
	{
		return null;
	}

	public int GetUnlockLevel(bool isMember = false, bool isMemberGuest = false)
	{
		return 0;
	}

	private void _003CRequestGetHCRankingsInfo_003Eb__36_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetPlayerRankingSeasonStats_003Eb__37_0(HttpErrorCode errodCode, object res)
	{
	}

	private void _003CRequestHippoCrisisInventoryTotalValue_003Eb__38_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
