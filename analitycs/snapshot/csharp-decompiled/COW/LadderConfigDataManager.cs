using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class LadderConfigDataManager : SingletonModule<LadderConfigDataManager>
{
	public enum RankEffectInGroup
	{
		Hide,
		Low,
		High
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CSPeakTournamentData, Pair<uint, uint>> _003C_003E9__11_0;

		public static Comparison<LadderLevelData> _003C_003E9__15_0;

		public static Comparison<LadderLevelData> _003C_003E9__16_0;

		public static Comparison<LadderLevelData> _003C_003E9__17_0;

		public static Comparison<LadderLevelData> _003C_003E9__18_0;

		public static Predicate<RankCardData> _003C_003E9__30_0;

		public static Predicate<RankCardData> _003C_003E9__31_0;

		public static Predicate<RankCardData> _003C_003E9__32_0;

		public static Predicate<CSRankingCardData> _003C_003E9__33_0;

		internal Pair<uint, uint> _003COnInit_003Eb__11_0(CSPeakTournamentData data)
		{
			return default(Pair<uint, uint>);
		}

		internal int _003CGetBRLadderLevelDatasBySeasonId_003Eb__15_0(LadderLevelData a, LadderLevelData b)
		{
			return 0;
		}

		internal int _003CGetCSLadderLevelDatasBySeasonId_003Eb__16_0(LadderLevelData a, LadderLevelData b)
		{
			return 0;
		}

		internal int _003CGetHCLadderLevelDatasBySeasonId_003Eb__17_0(LadderLevelData a, LadderLevelData b)
		{
			return 0;
		}

		internal int _003CGetPeriodicLadderLevelDatasBySeasonId_003Eb__18_0(LadderLevelData a, LadderLevelData b)
		{
			return 0;
		}

		internal bool _003CGetRankTimesRpConfigDataList_003Eb__30_0(RankCardData t)
		{
			return false;
		}

		internal bool _003CGetRankNoDeductCardConfigDataList_003Eb__31_0(RankCardData t)
		{
			return false;
		}

		internal bool _003CGetRankDoubleBonusNewCardConfigDataList_003Eb__32_0(RankCardData t)
		{
			return false;
		}

		internal bool _003CGetCSRankDoubleBonusNewCardConfigDataList_003Eb__33_0(CSRankingCardData t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public uint id;

		internal bool _003CGetRankCardDataByID_003Eb__0(RankCardData t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public uint itemID;

		internal bool _003CGetCSRankingCardById_003Eb__0(CSRankingCardData t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public uint itemID;

		internal bool _003CGetRankingCardById_003Eb__0(RankCardData t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public uint itemID;

		internal bool _003CIsCSRankLevelMeetRequirement_003Eb__0(CSRankingCardData t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public uint itemID;

		internal bool _003CIsRankCardLevelMeetRequirement_003Eb__0(RankCardData t)
		{
			return false;
		}
	}

	private Dictionary<int, LadderLevelData> m_LadderLevelDataDict;

	private List<RankCardData> m_RankingCardList;

	private List<RankBRStarScoreData> m_RankBRStarScoreList;

	private CSVAsyncDataMap<uint, RankingSeasonInfoData> m_RankingSeasonInfo;

	private List<CSRankingCardData> m_CsRankingCardDataList;

	private CSVAsyncDataMap<uint, HeroicMarkData> m_HeroicMarkMap;

	private Dictionary<int, PeakRankData> m_BRPeakRankMap;

	private Dictionary<int, PeakRankData> m_CSPeakRankMap;

	private CSVAsyncDataMap<uint, HippoCrisisRankData> m_HCRankDataDict;

	private CSVAsyncDataPairKeyMap<uint, uint, CSPeakTournamentData> m_CSPeakTournamentDataMap;

	public string DefaultRegion;

	public bool IsCSRankAnimationOpen;

	protected override void OnInit()
	{
	}

	public void InitConfigAfterLogin()
	{
	}

	public void CleanupDataOnLogOut()
	{
	}

	protected override void OnCleanup()
	{
	}

	public List<LadderLevelData> GetBRLadderLevelDatasBySeasonId(uint seasonId)
	{
		return null;
	}

	public List<LadderLevelData> GetCSLadderLevelDatasBySeasonId(uint seasonId)
	{
		return null;
	}

	public List<LadderLevelData> GetHCLadderLevelDatasBySeasonId(uint seasonId)
	{
		return null;
	}

	public List<LadderLevelData> GetPeriodicLadderLevelDatasBySeasonId(uint gameMode, uint seasonId)
	{
		return null;
	}

	public string GetBRLevelDataIconNameByRank(int rank)
	{
		return null;
	}

	public string GetCSLevelDataIconNameByRank(int rank)
	{
		return null;
	}

	public string GetRankNameByRank(int rank)
	{
		return null;
	}

	public bool GetRankAnimationSwitchByRank(int rank)
	{
		return false;
	}

	public bool GetCSRankAnimationSwitchByRank(uint rank)
	{
		return false;
	}

	public uint GetIconResourceIDByRank(int rank)
	{
		return 0u;
	}

	public LadderLevelData GetLevelDataByRank(int rank, bool isNeedMapping = false)
	{
		return null;
	}

	public List<BaseItemInfo> DeepCopy(List<BaseItemInfo> achieveAwardItemList)
	{
		return null;
	}

	public RankCardData GetRankCardDataByID(uint id)
	{
		return null;
	}

	public List<RankCardData> GetRankCardDataList()
	{
		return null;
	}

	public List<RankCardData> GetRankTimesRpConfigDataList()
	{
		return null;
	}

	public List<RankCardData> GetRankNoDeductCardConfigDataList()
	{
		return null;
	}

	public List<RankCardData> GetRankDoubleBonusNewCardConfigDataList()
	{
		return null;
	}

	public List<CSRankingCardData> GetCSRankDoubleBonusNewCardConfigDataList()
	{
		return null;
	}

	public List<CSRankingCardData> GetCsRankNodeductCardConfigDataList()
	{
		return null;
	}

	public CSRankingCardData GetCSRankingCardById(uint itemID)
	{
		return null;
	}

	public RankCardData GetRankingCardById(uint itemID)
	{
		return null;
	}

	public bool IsCSRankLevelMeetRequirement(uint itemID)
	{
		return false;
	}

	public bool IsRankCardLevelMeetRequirement(uint itemID)
	{
		return false;
	}

	public PeakRankData GetPeakRankData(DLBMPCCFKKM rankType = DLBMPCCFKKM.EMATCHMODE_RANKING, int rankMasterLevel = 0)
	{
		return null;
	}

	public ERankCardType GetRankCardTypeById(int id)
	{
		return ERankCardType.NONE;
	}

	public bool DoesRankBRHasStar(int rank)
	{
		return false;
	}

	public ResourceID GetRankBRStarColorSprite(int rank, int rankPoint)
	{
		return default(ResourceID);
	}

	private RankBRStarScoreData GetRankBRStarScoreData(int rank, int rankingPoint)
	{
		return null;
	}

	public uint GetRankBRStar(int rank, int rankingPoint)
	{
		return 0u;
	}

	public void GetRankBRStarBound(int rank, int rankingPoint, out int lowerBound, out int upperBound)
	{
		lowerBound = default(int);
		upperBound = default(int);
	}

	public CSRankData GetCSRankDataByRank(int rankLevel, bool isNeedMapping = false)
	{
		return null;
	}

	public PeriodicRankData GetPeriodicRankDataByRank(int rankLevel, uint seasonId = 0u, uint gameMode = 0u)
	{
		return null;
	}

	public void ProcessBRRankCardRankMapping()
	{
	}

	public void ProcessCSRankCardRankMapping()
	{
	}

	public string GetRankCardDesc(CSSharedItemData itemData, bool isBR)
	{
		return null;
	}

	public int GetPeriodicRankStarCount(int rankLevel, int rankPoint)
	{
		return 0;
	}

	public int GetCSRankStarCount(int rankLevel, int rankPoint)
	{
		return 0;
	}

	public RankingSeasonInfoData GetRankingSeasonInfo(int index)
	{
		return null;
	}

	public CSRankingSeasonInfoData GetCSRankingSeasonInfo(int index)
	{
		return null;
	}

	public int GetStarNumByRankAndRankPoint(int rank, int rankpoint)
	{
		return 0;
	}

	public ResourceID GetFullScreenAnimationResIdByRank(int rank, DLBMPCCFKKM matchMode)
	{
		return default(ResourceID);
	}

	public string GetFullScreenAnimationClipNameByRank(int rank, DLBMPCCFKKM matchMode, bool needCrossModeClip = false)
	{
		return null;
	}

	public HippoCrisisRankData GetHippoCrisisRankDataByRank(int rankLevel)
	{
		return null;
	}

	public CSPeakRankData GetCSPeakRankDataByRank(int rankLevel)
	{
		return null;
	}

	public HeroicMarkData GetHeroicMarkData(EHeroicMarkType markType, uint val)
	{
		return null;
	}

	public void SetHeroicMarkNumberLabelState(HeroicMarkData data, EHeroicMarkRankType rankType, ref UILabel number)
	{
	}

	public GameObject SetHeroicEffect(ResourceID resID, Transform trans, int depth)
	{
		return null;
	}

	public CSPeakTournamentData GetCSPeakTournamentDataByPoints(uint points)
	{
		return null;
	}

	public CSPeakTournamentData GetLowestCSPeakTournamentData()
	{
		return null;
	}

	public CSPeakTournamentData GetCSPeakTournamentDataByLowerPoints(uint lowerPoints)
	{
		return null;
	}
}
