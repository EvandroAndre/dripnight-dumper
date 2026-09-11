using System;
using System.Collections.Generic;
using GCommon;
using message;
using proto;
using tcp;

namespace COW;

public class UIModelHuntingGround : UIBaseModel
{
	public class HgSnowLeaderboardBubble
	{
		public LeaderBoardInfo Info;

		public int deltaRank;
	}

	public enum EAwardState
	{
		Lock,
		Claimable,
		Claimed
	}

	private class PVEGameModeInfo
	{
		public uint SelectedMapDifficulty;

		public uint GameMode;

		public uint[] UnlockedDifficulty;

		public List<HuntingGroundMissionData> HgMissionDataList;
	}

	public class HuntingGroundMissionData
	{
		public bool IsLimitedTime;

		public uint SortId;

		public uint PassCount;

		public uint GameMode;

		public long Duration;

		public uint Damage;

		public uint Difficulty;

		public string WorkshopCode;

		public bool IsUnlock;

		public string DifficultyName;

		public string DifficultyCdn;

		public string DifficultyLockCdn;

		public string[] DifficultyDataType;

		public AwardDesc Award;

		public void SetIsUnlockByDifficulty(uint[] UnlockedDifficyltyArray)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<HuntingGroundMissionData> _003C_003E9__106_0;

		public static Converter<Item, CommonRewardItemInfo> _003C_003E9__138_1;

		public static Converter<Item, CommonRewardItemInfo> _003C_003E9__140_1;

		internal int _003CGetPveMissionDataListByHGRecord_003Eb__106_0(HuntingGroundMissionData a, HuntingGroundMissionData b)
		{
			return 0;
		}

		internal CommonRewardItemInfo _003CRequestGetPVEAward_003Eb__138_1(Item item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003CRequestGetPVETalentReward_003Eb__140_1(Item item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass136_0
	{
		public UIModelHuntingGround _003C_003E4__this;

		public bool isGroupChange;

		public uint gamemode;

		public uint difficulty;

		internal void _003CRequestPVEInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass138_0
	{
		public UIModelHuntingGround _003C_003E4__this;

		public uint gamemode;

		public uint difficulty;

		public uint round;

		internal void _003CRequestGetPVEAward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass139_0
	{
		public uint talentId;

		public UIModelHuntingGround _003C_003E4__this;

		internal void _003CRequestUpdateTalent_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass65_0
	{
		public LeaderBoardInfo data;

		internal bool _003CGetRankChangeBubbleAccountList_003Eb__0(ulong value)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass90_0
	{
		public uint gameMode;

		public Predicate<tcp.HuntingGroundLikePVEInfo> _003C_003E9__0;

		internal bool _003CCheckIsGroupDifficultyUnlock_003Eb__0(tcp.HuntingGroundLikePVEInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public uint gameMode;

		public Predicate<tcp.HuntingGroundLikePVEInfo> _003C_003E9__0;

		internal bool _003CGetGroupHighestUnlockDifficulty_003Eb__0(tcp.HuntingGroundLikePVEInfo x)
		{
			return false;
		}
	}

	public const uint PropID_TalentUpdate = 2u;

	public const uint PropID_TokenUpdate = 4u;

	public const uint PropID_AllInfoReceived = 8u;

	public const uint PropID_PVELeaderBoardSetting = 16u;

	public const uint PropID_TalentAward = 32u;

	public const uint PropID_DifficultyAward = 64u;

	public const uint PropID_GetPveRankResult = 128u;

	private bool m_HasPveInfo;

	private bool m_HasLeaderBoardSetting;

	private bool m_HasPveSetting;

	private bool m_IsRequestingPveSetting;

	public const uint PVE_Infinite_Difficulty = 99u;

	private bool _003CIsShowLobbyRedTips_003Ek__BackingField;

	private bool _003CIsShowTalentRedTips_003Ek__BackingField;

	private readonly uint[] PVE_MODE;

	private List<PVEDifficultyAttributeRuleDesc> m_PVEDifficultyAttributeRules;

	private List<PVELeaderboardRewardDesc> m_PVELeaderboardRewardDescList;

	private Dictionary<uint, List<PVELobbyInfoDesc>> m_PVELobbySettingDic;

	private Dictionary<uint, PVEChapterInfoDesc> m_PVEChapterSettings;

	private Dictionary<uint, PVEGameModeInfo> m_PveGameModeInfoDic;

	private HashSet<uint> m_UnlockTalentSet;

	private HashSet<uint> m_HighestLevelUnlockTalentSet;

	private uint m_PVEInfiniteClaimedAwardRound;

	private HashSet<uint> m_HGSnowRewardHistorySet;

	private Dictionary<uint, uint> m_HGSnowDifficultyMaxRound;

	private bool m_HasTalentDailyReward;

	private uint m_CurPveTimeLimitDifficulty;

	private uint m_CurPveTimeLimitGameMode;

	private CSGetPVELeaderboardPositionsRes m_LastSeasonRankData;

	private uint m_CurGroupDifficulty;

	private MapModeData _003CSelectedMapMode_003Ek__BackingField;

	private CSGetAccountAllPVEInfoRes m_AllPveInfo;

	public static readonly string PlayerPresKey_MyRank;

	public static readonly string PlayerPresKey_HigherRankFriends;

	public static readonly string PlayerPresKey_IsPlayUnlockDifficultyAnim;

	public static readonly string PlayerPresKey_PVENewbie;

	private const uint MapDifficultyStep = 1000u;

	public uint SelectedChapterId;

	private EMapDifficulty _003CUnlockDifficulty_003Ek__BackingField;

	private int m_tokenNum;

	private uint _003CTokenId_003Ek__BackingField;

	private int m_ShopTokenNum;

	public const uint CurShopTokenId = 801044016u;

	public const uint PreShopTokenId = 801039001u;

	private ResourceID[] m_HGSnowLobbyUIResourceIds;

	public bool IsShowLobbyRedTips
	{
		get
		{
			return _003CIsShowLobbyRedTips_003Ek__BackingField;
		}
		private set
		{
			_003CIsShowLobbyRedTips_003Ek__BackingField = value;
		}
	}

	public bool IsShowTalentRedTips
	{
		get
		{
			return _003CIsShowTalentRedTips_003Ek__BackingField;
		}
		private set
		{
			_003CIsShowTalentRedTips_003Ek__BackingField = value;
		}
	}

	private bool HasAllInfoAndSetting => false;

	public uint CurPveTimeLimitDifficulty => 0u;

	public uint CurPveTimeLimitGameMode => 0u;

	public CSGetPVELeaderboardPositionsRes LastSeasonRankData => null;

	public MapModeData SelectedMapMode
	{
		get
		{
			return _003CSelectedMapMode_003Ek__BackingField;
		}
		set
		{
			_003CSelectedMapMode_003Ek__BackingField = value;
		}
	}

	public EMapDifficulty UnlockDifficulty
	{
		get
		{
			return _003CUnlockDifficulty_003Ek__BackingField;
		}
		private set
		{
			_003CUnlockDifficulty_003Ek__BackingField = value;
		}
	}

	public bool CanChooseDifficulty => false;

	public uint TokenId
	{
		get
		{
			return _003CTokenId_003Ek__BackingField;
		}
		private set
		{
			_003CTokenId_003Ek__BackingField = value;
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public MapModeData GetChapterDefaultMapModeData(uint chapterId)
	{
		return null;
	}

	public MapModeData GetPVEMapModeDataByGameModeAndDifficulty(uint gamemode, uint difficulty = 0u)
	{
		return null;
	}

	public List<HuntingGroundMissionData> GetHuntingGroundMissionDatasListByGameMode(uint gameMode)
	{
		return null;
	}

	public HuntingGroundMissionData GetHuntingGroundMissionDataByModeAndDifficuty(uint gameMode, uint difficuty)
	{
		return null;
	}

	public EAwardState GetAwardState(HuntingGroundMissionData missionData)
	{
		return EAwardState.Lock;
	}

	public List<HgSnowLeaderboardBubble> GetRankChangeBubbleAccountList(out bool isContainsLocalPlayer)
	{
		isContainsLocalPlayer = default(bool);
		return null;
	}

	public bool CheckIsPlayUnlockDifficultyAnim(uint gamemode, uint difficulty)
	{
		return false;
	}

	public void RecordPlayUnlockDifficultyAnim(uint gamemode, uint difficulty)
	{
	}

	private bool HasTalentItemAbleToUnlock()
	{
		return false;
	}

	public int GetNextUnlockTalentGroupIndex()
	{
		return 0;
	}

	public bool CheckIsTalentGroupAbleToUnlock(uint talentGroup)
	{
		return false;
	}

	private void RefreshRedTips()
	{
	}

	public void SetPveNewbie()
	{
	}

	public uint GetMapDifficultyByGameMode(uint gameMode)
	{
		return 0u;
	}

	private void CloseMainUI()
	{
	}

	public void ResetCurGroupDifficulty()
	{
	}

	public void SetMapDifficultyByGameModeAndDiff(uint gameMode, uint difficulty, bool isGroupInfoUpdate)
	{
	}

	public int GetTreeNodeCountByIndex(int index)
	{
		return 0;
	}

	public List<uint> GetTalentListByGroup(uint talentGroup)
	{
		return null;
	}

	public List<uint> GetTalentGroupList()
	{
		return null;
	}

	public uint GetCurUnlockTalentCount()
	{
		return 0u;
	}

	public PVETalentConifgData GetTalentConfigById(uint talentId)
	{
		return null;
	}

	private List<PVELobbyInfoDesc> GetPVELobbyInfoDescListByGameMode(uint gameMode)
	{
		return null;
	}

	public bool CheckIsPveGameMode(uint gameMode)
	{
		return false;
	}

	public bool CheckIsPveNormalOrTimeLimitMode(uint gameMode)
	{
		return false;
	}

	public void ClearAllPveMapDifficulty()
	{
	}

	public bool CheckIsGroupDifficultyUnlock(uint difficulty)
	{
		return false;
	}

	public uint GetGroupHighestUnlockDifficulty()
	{
		return 0u;
	}

	public PVELobbyInfoDesc GetPveLobbyDescByGameModeAndDifficulty(uint gameMode, uint difficulty)
	{
		return null;
	}

	public uint GetRealDifficulty(uint difficulty)
	{
		return 0u;
	}

	public bool IsPveTimeLimitDifficulty(uint difficulty)
	{
		return false;
	}

	public PVEChapterInfoDesc GetChapterDescById(uint id)
	{
		return null;
	}

	public List<uint> GetGetChapterIds()
	{
		return null;
	}

	public void RefreshHgSnowTimeLimitDifficulty()
	{
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public bool IsTalentUnlock(uint talentId)
	{
		return false;
	}

	public List<uint> GetHighestLevelUnlockTalentList()
	{
		return null;
	}

	private void UpdateTalentData(CSGetAccountAllPVEInfoRes data)
	{
	}

	private int CompareHighestLevelUnlockTalent(uint id1, uint id2)
	{
		return 0;
	}

	private List<HuntingGroundMissionData> GetPveMissionDataListByHGRecord(List<proto.HuntingGroundLikePVERecords> hgRecords, uint[] unlockedDifficulty, uint gameMode)
	{
		return null;
	}

	private void InitMissionDataDesc(HuntingGroundMissionData missionData, PVELobbyInfoDesc pveLobbyInfoDesc)
	{
	}

	private void UpdatePVEModeInfo()
	{
	}

	private void UpdateAwardHistory(CSGetAccountAllPVEInfoRes data)
	{
	}

	private PVEGameModeInfo GetPVEGameModeInfoByMode(uint gameMode, bool needInitIfEmpty = false)
	{
		return null;
	}

	public void UpdateLocalPlayerMissionData(GroupMemberInfo myInfo)
	{
	}

	public int GetTokenCount()
	{
		return 0;
	}

	public int GetShopTokenCount()
	{
		return 0;
	}

	public void OnBackpackChanged()
	{
	}

	public bool NeedDownloadHGSnowLobbyUIResource()
	{
		return false;
	}

	public bool CanChangeAutoMatch()
	{
		return false;
	}

	public PVEDifficultyAttributeConfigData GetTopSpeedBuff()
	{
		return null;
	}

	public uint GetLeaderBoardMainType(PVEDifficultyAttributeRuleDesc desc)
	{
		return 0u;
	}

	public PVEDifficultyAttributeRuleDesc GetTopSpeedRuleByCurrentTime(NIKKALKPIBO mode, uint difficulty)
	{
		return null;
	}

	public List<PVELeaderboardRewardDesc> GetPVELeaderboardRewardListById(uint leaderboardId)
	{
		return null;
	}

	public PVELeaderboardRewardDesc GetPVELeaderboardRewardByIdAndRank(uint leaderboardId, uint rank)
	{
		return null;
	}

	private void OnGroupDifficultyUpdated(uint gamemode, uint difficulty)
	{
	}

	public void ResetLastSeasonRankData()
	{
	}

	public void RequestGetPVESetting()
	{
	}

	public void RequestAllPVEMessage(uint httpOption = 0u, bool isGroupChange = false, uint gamemode = 0u, uint difficulty = 0u)
	{
	}

	public void GetPVELeaderboardSettingRes(uint httpOption = 0u)
	{
	}

	private void RequestPVEInfo(uint httpOption, bool isGroupChange = false, uint gamemode = 0u, uint difficulty = 0u)
	{
	}

	public void RequestLastSeasonPVELeaderboardRank()
	{
	}

	public void RequestGetPVEAward(uint gamemode, uint difficulty, uint round)
	{
	}

	public void RequestUpdateTalent(uint talentId)
	{
	}

	public void RequestGetPVETalentReward()
	{
	}

	private bool _003CCanChangeAutoMatch_003Eb__125_0(HuntingGroundMissionData value)
	{
		return false;
	}

	private void _003CRequestGetPVESetting_003Eb__133_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CGetPVELeaderboardSettingRes_003Eb__135_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestLastSeasonPVELeaderboardRank_003Eb__137_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetPVETalentReward_003Eb__140_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
