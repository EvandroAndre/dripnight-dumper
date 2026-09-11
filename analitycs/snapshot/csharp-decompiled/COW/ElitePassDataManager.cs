using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class ElitePassDataManager : SingletonModule<ElitePassDataManager>, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public uint expIncrement;

		internal void _003COnDataChanged_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public uint challengeID;

		internal bool _003CRefreshAwardDataByOriginalChallengeID_003Eb__0(ChallengeDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public uint challengeID;

		internal bool _003CGetWeekByChallengeID_003Eb__0(ChallengeDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public uint newChallengeID;

		public uint curChallengeID;

		internal bool _003CReplaceEPWeeklyQuestDicFromPool_003Eb__0(ChallengeDesc x)
		{
			return false;
		}

		internal bool _003CReplaceEPWeeklyQuestDicFromPool_003Eb__1(ChallengeDesc x)
		{
			return false;
		}

		internal bool _003CReplaceEPWeeklyQuestDicFromPool_003Eb__2(EPWeeklyQuestInfo x)
		{
			return false;
		}
	}

	public const int EPDebrisExchangeRate = 10000;

	public Dictionary<byte, List<EPChallengeInfo>> ChallengeList;

	public Dictionary<byte, List<EPChallengeInfo>> SpecialChallengeList;

	public Dictionary<uint, ChallengeStatus> ChallengeStatusChache;

	public Dictionary<byte, List<uint>> newUnlockedSpecialChallengeIds;

	public List<EPDailyQuestInfo> EPDailyQuestLst;

	public Dictionary<uint, List<EPWeeklyQuestInfo>> EPWeeklyQuestDic;

	public Dictionary<int, int> EPWeeklyQuestTipsCntDic;

	private Dictionary<uint, uint> EPDailyTaskFinishCntCache;

	private UIModelInventory m_ModelInventory;

	private UIModelCollection m_ModelCollection;

	private UIModelBooyahPass m_ModelBooyahPass;

	private uint LastClaimedRewardID;

	public string SHOW_NEWEP_GUIDE;

	public const string NEW_EP_CHALLENGE_TAB_REDDOT = "NEW_EP_CHALLENGE_TAB_REDDOT";

	private Dictionary<uint, List<EPWeeklyRewardInfo>> EPWeeklyRewardDic;

	private Dictionary<uint, bool> EPWeeklyTablockDic;

	private List<ResourceID> m_resourceIDList;

	private string HAS_AUTO_SHOW_SUBSCRIBEWINDOW;

	private uint m_CacheRewardCnt;

	public Dictionary<uint, uint> EPDailyTaskLastGameFinishCntCache;

	protected override void OnInit()
	{
	}

	private void LoadCSVData()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void UpdateEPWeeklyQuestStatus()
	{
	}

	public void UpdateEpWeekTaskLock()
	{
	}

	private int EPChallengeSortFunc(EPWeeklyQuestInfo x, EPWeeklyQuestInfo y)
	{
		return 0;
	}

	private void UpdateEpWeeklyFromPool()
	{
	}

	private void RefreshAwardDataByOriginalChallengeID(EPWeeklyQuestInfo info, uint challengeID)
	{
	}

	private uint GetWeekByChallengeID(uint challengeID)
	{
		return 0u;
	}

	public void ReplaceEPWeeklyQuestDicFromPool(uint week, uint newChallengeID, uint curChallengeID)
	{
	}

	public void UpdateEPWeeklyQuestlockStatus()
	{
	}

	public bool HasWeekChallengeAward(int week)
	{
		return false;
	}

	public EPWeeklyQuestInfo CreateWeeklyQuestInfo(EPWeeklyQuestData data)
	{
		return null;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public bool HasChallengeToAwardByType(ChallengeType type)
	{
		return false;
	}

	private bool CheckAwardForChallengeList(List<EPChallengeInfo> infoList)
	{
		return false;
	}

	public bool HasNewTipsChallenge()
	{
		return false;
	}

	public bool HasNewUnlockedTipsChallenge()
	{
		return false;
	}

	public bool HasNewUnlockedTipsChallengeForType(ChallengeType cType)
	{
		return false;
	}

	public void GetEPWeekTabLockState(ref bool w1, ref bool w2, ref bool w3, ref bool w4)
	{
	}

	private uint GetEPWeekTabGuideId(uint weekId)
	{
		return 0u;
	}

	public EEPTaskTab GetShouldShowGuideEPWeekTab()
	{
		return EEPTaskTab.Daily;
	}

	public void SetEPWeekTabGuide(int weekId)
	{
	}
}
