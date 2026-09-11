using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelAvatarProfile : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__161_0;

		public static Converter<Item, CommonRewardItemInfo> _003C_003E9__175_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__194_1;

		public static Func<KeyValuePair<uint, uint>, uint> _003C_003E9__205_1;

		public static Comparison<AvatarProficiencyRewardDesc> _003C_003E9__246_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__260_1;

		internal void _003CRequestUnlockAvatarHiddenly_003Eb__161_0(HttpErrorCode errorCode, object res)
		{
		}

		internal CommonRewardItemInfo _003COnLimitAvatarChange_003Eb__175_0(Item item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003CRequestClaimAvatarAwaken_003Eb__194_1(BaseItemInfo item)
		{
			return null;
		}

		internal uint _003CAwakenIdToOriId_003Eb__205_1(KeyValuePair<uint, uint> e)
		{
			return 0u;
		}

		internal int _003CProcessAvatarProficiencyInfos_003Eb__246_0(AvatarProficiencyRewardDesc a, AvatarProficiencyRewardDesc b)
		{
			return 0;
		}

		internal CommonRewardItemInfo _003CClaimAvatarProficiencyReward_003Eb__260_1(BaseItemInfo item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass199_0
	{
		public UIModelAvatarProfile _003C_003E4__this;

		public uint origionalID;

		internal void _003CRequestRefreshAvatarAwakenTaskInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass203_0
	{
		public UIModelAvatarProfile _003C_003E4__this;

		public uint origionalID;

		public uint comicID;

		public uint unlockNum;

		internal void _003CRequestUnlockAvatarAwakenComic_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass205_0
	{
		public uint awakenAvatarID;

		internal bool _003CAwakenIdToOriId_003Eb__0(KeyValuePair<uint, uint> e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass221_0
	{
		public bool needShowCommonRewardWnd;

		public UIModelAvatarProfile _003C_003E4__this;

		public List<uint> taskList;

		internal void _003CRequestClaimAwakenTaskReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass237_0
	{
		public UIModelAvatarProfile _003C_003E4__this;

		public List<ulong> reqIds;

		internal void _003CRequestGeAvatarProfileBatch_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass260_0
	{
		public UIModelAvatarProfile _003C_003E4__this;

		public uint avatarId;

		public uint level;

		public bool showRewardWnd;

		internal void _003CClaimAvatarProficiencyReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass261_0
	{
		public UIModelAvatarProfile _003C_003E4__this;

		public bool needNotify;

		internal void _003CRequestAvatarProficiencyInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_AvatarListUpdate = 2u;

	public const uint PropID_ProfileUpdate = 4u;

	public const uint PropID_SkillUpdate = 8u;

	public const uint PropID_UnlockProfile = 16u;

	public const uint PropID_UnlockAvatar = 32u;

	public const uint PropID_SkillSlotChange = 64u;

	public const uint PropID_AvatarSelectionChanged = 128u;

	public const uint PropID_UnLockSkillSlot = 256u;

	public const uint PropID_UpgradeProfile = 512u;

	public const uint PropID_AwakenTaskUpdate = 1024u;

	public const uint PropID_AwakenRewardClaim = 2048u;

	public const uint PropID_ExchangeDebrisSuccess = 4096u;

	public const uint PropID_LimitAvatarInfoChange = 8192u;

	public const uint PropID_LimitAvatarExpire = 16384u;

	public const uint PropID_GetAvatarProfileBatch = 32768u;

	public const uint PropID_AwakenComicUpdate = 65536u;

	public const uint PropID_AvatarAwakenUpdate = 131072u;

	public const uint PropID_SkillSlotChangeFailed = 262144u;

	public const uint PropID_AvatarProficiencyUpdate = 524288u;

	public const uint PropID_AvatarNewFlagUpadte = 1048576u;

	public const uint PropID_AwakenRewardClaimMatchResult = 2097152u;

	public const uint PropID_AvatarListUpdateError = 4194304u;

	public const uint PropID_AvatarAwakenClaimInNewWay = 8388608u;

	public const string UPGRADECARDPREFIX = "UPGRADECARDPREFIX";

	public const string UPGRADECARDREDDOT = "UPGRADECARDREDDOT";

	public const string AWAKENCOMICHASNEW = "AWAKENCOMICHASNEW";

	public const uint AVATARAWAKEN_FINISH = uint.MaxValue;

	private const uint UNIVERSAL_DEBRIS_ID = 817000001u;

	public const uint DEFAULT_SELECT_AVATARID = 102000004u;

	public uint m_CurrentUnlockAvatarID;

	public uint m_MaxAvatarProficiencyLevel;

	private bool m_HasGetNewCanAwakenAvatar;

	private static bool m_AwakeAvatarHide;

	private bool _003CAvatarNewFlagInBuild_003Ek__BackingField;

	private bool m_HaveRequestProficiencyInfo;

	private Dictionary<uint, AvatarProficiencyLevelDesc> m_ProficiencyLevelDescDict;

	private Dictionary<uint, List<AvatarProficiencyRewardDesc>> m_ProficiencyRewardDescDict;

	private Dictionary<uint, AvatarProficiencyInfo> m_ProficiencyInfoDict;

	private Dictionary<uint, AvatarTagData> m_AvatarTagDict;

	private Dictionary<uint, uint> m_AvatarId2PreIdDict;

	private Action accallback;

	private List<uint> m_NewAvatarList;

	private Dictionary<uint, AvatarProfile> m_AvatarProfileMap;

	private List<uint> m_AvailableSkills;

	public Dictionary<uint, AvatarSkill> AvatarSkillDataMap;

	private List<AvatarProfileDataOverrided> m_AvatarProfileDescList;

	private List<uint> m_HideAvatarList;

	private List<uint> m_IpExpiredAvatarList;

	private Dictionary<ulong, proto.AvatarProfile> m_AccountAvatarDict;

	private Dictionary<ulong, List<proto.AccountCollectionCustomItemInfo>> m_AccountCollectionCustomDict;

	private List<AvatarNewDesc> m_AvatarNewDescList;

	private List<uint> m_NewCharacterTipsAvatarIDList;

	private Dictionary<uint, bool> m_AvatarNewDescKeyCheckCacheDict;

	private const string NewCharacterGuideKey = "NEWCHARACTERGUIDEKEY";

	private const string NewCharacterTipsKey = "NEWCHARACTERTIPSKEY";

	private const string NewCharacterTipsLobbyKey = "NEWCHARACTERTIPSLOBBYKEY";

	private const string NewCharacterTipsBuildKey = "NEWCHARACTERBUILDKEY";

	private const string NewCharacterTipsBuildChooseAvatarSkillSideKey = "NEWCHARACTERBUILDCHOOSEAVATARSKILLSIDEKEY";

	private uint m_NewCharacterGuideCacheAvatarID;

	public bool IsNeedShowNewCharacterTipsForLobby;

	public bool IsNeedShowNewCharacterTipsForBuild;

	public bool IsNeedShowNewCharacterTipsForBuildChooseAvatarSkillSide;

	private AvatarProfile m_CurrentAvatar;

	private ulong m_LastClaimAwakenAvatarTime;

	private int m_UniversalDebrisCnt;

	private string Key;

	private bool m_NewBieAvatarGuide;

	private uint m_SuitIdCache;

	private Dictionary<uint, uint> m_OriAvatarIDToAwakenAvatarIdMap;

	private Dictionary<uint, AvatarAwaken> m_OriAvatarIDToAwakenInfoMap;

	private Dictionary<uint, Dictionary<uint, bool>> m_OriAvatarToAwakenTaskInMatchResultTaskMap;

	private Dictionary<uint, List<uint>> m_OriAvatarToFinishAwakenTaskTypeMap;

	private Dictionary<uint, Dictionary<uint, AwakenTask>> m_OriAvatarToAwakenTaskMap;

	private Dictionary<uint, uint> m_OriAvatarToAwakenTaskRefreshCntMap;

	private Dictionary<uint, Dictionary<uint, AwakenComic>> m_OriAvatarToAwakenComicMap;

	private List<ulong> m_RunningRequestProfileAccountIDCache;

	public bool m_AllAvatarsDataReady;

	private Dictionary<uint, List<AvatarJumpDesc>> m_AvatarJumpDescDict;

	private List<MatchResultTaskInfo> m_OriAvatarToAvatarAwakenMatchResultFinishedInfoList;

	private List<MatchResultTaskInfo> m_OriAvatarToAvatarAwakenMatchResultReceivedInfoList;

	private List<MatchResultTaskInfo> m_OriAvatarToAvatarAwakenMatchResultNoProgressInfoList;

	private bool m_HasRequestedMyAvatarList;

	private List<uint> _003CCacheExpireAvatarLst_003Ek__BackingField;

	public const uint COMICUNLOCKCNT_PERCOMIC_MAX = 3u;

	private bool m_HadFetchAwakenComicRes;

	private bool m_IsInRequestGetAvatarAwakenCominInfo;

	private bool m_HadFetchAwakenTaskRes;

	public static bool AwakeAvatarHide => false;

	public uint NewDefaultSelectAvatarID => 0u;

	public uint NewDefaultSelectAvatarSkillId => 0u;

	public bool AvatarNewFlagInBuild
	{
		get
		{
			return _003CAvatarNewFlagInBuild_003Ek__BackingField;
		}
		set
		{
			_003CAvatarNewFlagInBuild_003Ek__BackingField = value;
		}
	}

	public bool HaveRequestProficiencyInfo => false;

	public Dictionary<uint, AvatarProfile> AvatarProfileMap => null;

	public List<uint> AvailableSkills => null;

	public List<AvatarProfileDataOverrided> AvatarProfileDescList => null;

	public uint NewCharacterGuideCacheAvatarID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public AvatarProfile CurrentAvatar
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int UniversalDebrisCnt
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool NewBieAvatarGuide
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public List<MatchResultTaskInfo> AvatarAwakenMatchResultFinishedInfoList => null;

	public List<MatchResultTaskInfo> AvatarAwakenMatchResultReceivedInfoList => null;

	public List<MatchResultTaskInfo> AvatarAwakenMatchResultNoProgressInfoList => null;

	public List<uint> CacheExpireAvatarLst
	{
		get
		{
			return _003CCacheExpireAvatarLst_003Ek__BackingField;
		}
		private set
		{
			_003CCacheExpireAvatarLst_003Ek__BackingField = value;
		}
	}

	public void SetNewAwakenAvatarState(bool awakenSystemHide)
	{
	}

	public void CheckPlayerCanClaimAwakenAvatar()
	{
	}

	public void SetAvatarProfile(AvatarProfile data)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	private void InitData()
	{
	}

	public bool CheckIsOnlyAvatar(uint avatarid)
	{
		return false;
	}

	public bool CheckIsHideAvatar(uint avatarid)
	{
		return false;
	}

	public bool IsIpExpiredAvatar(uint avatarid)
	{
		return false;
	}

	public uint GetAvatarIdBySkillId(uint _skillid)
	{
		return 0u;
	}

	public uint GetInvisibleAvatarId(uint avatarId)
	{
		return 0u;
	}

	public uint GetOriginIdByInvisibleAvatarId(uint avatarId)
	{
		return 0u;
	}

	public uint GetInvisibleAvatarIdBySkillId(uint skillId)
	{
		return 0u;
	}

	public AvatarProfile GetAvatarProfile(uint avatarID)
	{
		return null;
	}

	public AvatarProfileDataOverrided GetAvatarProfileData(uint avatarID)
	{
		return null;
	}

	private void UpdateAvatarInfo(List<proto.AvatarProfile> profiles)
	{
	}

	private bool CheckHasTips(AvatarProfile profile)
	{
		return false;
	}

	private bool CheckHasAwakenTips(AvatarProfile profile)
	{
		return false;
	}

	public void SetVeteranLogs(bool changeCharacter = false)
	{
	}

	public void UpdateTips()
	{
	}

	private void UpdateSkillInfo(uint[] Skills)
	{
	}

	public void UpdateDebrisCnt()
	{
	}

	public void UpdateInfoByInventoryItems()
	{
	}

	public void RequestMyAvatarList(uint httpOp = 0u, bool force = true, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	public void ForceRequestAvatarList()
	{
	}

	public void RequestSkillList(uint httpOp = 0u)
	{
	}

	public void RequestLoginGetProfile(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool sendImmediately = false, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public void ProcessProfileDesc()
	{
	}

	public void ProcessHideAvatars(CSGetHideAvatarRes res, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	public void ProcessNewAvatars(List<AvatarNewDesc> avatarNewDescs)
	{
	}

	private void SetNewCharacterTips()
	{
	}

	public void SetLobbyV2NewCharacterTips()
	{
	}

	public bool CheckIsNeedShowNewCharacterTips(uint avatarID)
	{
		return false;
	}

	public void MarkNewCharacterTips(uint avatarID)
	{
	}

	public void MarkNewCharacterTipsForBuild()
	{
	}

	public void MarkNewCharacterTipsForLobby()
	{
	}

	public void MarkNewCharacterTipsForBuildChooseAvatarSkillSide()
	{
	}

	public uint CheckIsNeedNewCharacterGuide()
	{
		return 0u;
	}

	public void SetNewCharacterGuideKey(uint avatarID)
	{
	}

	private int GetUniversalDebrisCnt()
	{
		return 0;
	}

	public void ChangeSelectedAvatar(uint selectedAvatarID, bool callFromAvatarList = false, uint httpOp = 0u, int planIndex = -1, bool needChangeSkill = false)
	{
	}

	public bool CheckUnlockManually(uint avatarID)
	{
		return false;
	}

	public void RequestUnlockAvatarHiddenly(uint avatarID)
	{
	}

	public void OnUnlockedNewAvatar(proto.AvatarProfile avatar)
	{
	}

	public void OnUnlockedNewSkill(uint newSkillID)
	{
	}

	public bool HasNewAvatar()
	{
		return false;
	}

	public void ClearNewAvatarShowList()
	{
	}

	public void ClearNewAvatarById(uint id)
	{
	}

	public bool CheckAavatarIsNew(uint id)
	{
		return false;
	}

	public void UpdateNewItem(Item[] newInventories)
	{
	}

	public void RequestUseUpgradeCard(uint avatarID, uint upgradeCardID)
	{
	}

	public void UpdateAvatarEquippedSkills(proto.AvatarProfile profileInfo)
	{
	}

	public void OnLimitAvatarChange(proto.AvatarProfile profileRes, List<Item> rewards)
	{
	}

	public void OnLimitAvatarExpire(List<Item> expireItems)
	{
	}

	private void ProcessExpireAvatar(AvatarProfile profile)
	{
	}

	public bool CheckHasAvatarExpire()
	{
		return false;
	}

	public List<uint> GetExpireAvatarLst()
	{
		return null;
	}

	public bool IsOriSkillEmptyAvatar(uint avatarId)
	{
		return false;
	}

	public bool IsAvatarExpire(uint avatarId)
	{
		return false;
	}

	public bool CheckAvatarAvalible(uint avatarId)
	{
		return false;
	}

	public bool IsAwakenAvatar(uint avatarID)
	{
		return false;
	}

	public uint AvatarIDBySkillID(uint skillID)
	{
		return 0u;
	}

	public bool ShouldShowAwakenEntry(uint avatarID)
	{
		return false;
	}

	public bool NeedShowSingleInAvatarList(uint avatarID)
	{
		return false;
	}

	public uint GetAwakenAvatarId(uint avatarid)
	{
		return 0u;
	}

	public void ProcessAvatarAwakenInfo(CSGetAvatarAwakenRes res)
	{
	}

	public AvatarAwaken GetAwakenInfo(uint oriAvatarID)
	{
		return null;
	}

	public AwakenComic GetAwakenComicInfo(uint oriAvatarID, uint comicID)
	{
		return null;
	}

	public uint GetCurrentUnlockAwakenComicCount(uint oriAvatarID)
	{
		return 0u;
	}

	public uint GetCurrentUnlockAwakenComicFragmentsCnt(uint oriAvatarID)
	{
		return 0u;
	}

	public void RequestClaimAvatarAwaken(uint origionalID)
	{
	}

	public void RequestGetAvatarAwakenComicInfo(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	private void UpdateAvatarAwakenComic(List<AwakenComic> ComicList)
	{
	}

	public void RequestRefreshAvatarAwakenTaskInfo(uint origionalID)
	{
	}

	private void UpdateAvatarAwakenRefreshCount(uint origionalID, uint count)
	{
	}

	public uint GetCurrentRefreshCount(uint origionalID)
	{
		return 0u;
	}

	public uint GetCurrentFinishTaskCount(uint origionalID)
	{
		return 0u;
	}

	public void RequestUnlockAvatarAwakenComic(uint origionalID, uint comicID)
	{
	}

	public uint GetExChangeAwakenAvatarID(uint avatarID)
	{
		return 0u;
	}

	public uint AwakenIdToOriId(uint awakenAvatarID)
	{
		return 0u;
	}

	private void UpdateAvatarAwakenTask(List<AwakenTask> taskList)
	{
	}

	private void DeleteAvatarAwakenTask(uint avatarID, uint taskId)
	{
	}

	private void UpdateAvatarAwakenTask(List<AwakenTask> taskList, uint avatarID)
	{
	}

	public bool CanClaimAwakenAvatarAward(uint oriAvatarID)
	{
		return false;
	}

	public bool SetAvatarAwakenRedPointWithEnoughToken(uint avatarId)
	{
		return false;
	}

	public bool CheckHasAwakenTips(uint avatarId)
	{
		return false;
	}

	public bool CheckHasSpeicalAwakenTips(uint avatarId)
	{
		return false;
	}

	public bool CheckAllAwakenAvatarHasEnoughToken()
	{
		return false;
	}

	public uint GetOnlyOriginId(uint avatarid)
	{
		return 0u;
	}

	public bool HasAwakenAvatar(uint avatarID)
	{
		return false;
	}

	public bool HasAvatar(uint id)
	{
		return false;
	}

	public List<AwakenTask> GetAwakenTaskList(uint oriAvatarID)
	{
		return null;
	}

	public void RequestAvatarAwakenTaskDesc(bool force = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	public void OnAwakenTaskStateChange(AwakenTaskChangeNtf res)
	{
	}

	public void RequestClaimAwakenTaskReward(uint avatarID, List<uint> taskList, bool needShowCommonRewardWnd = true)
	{
	}

	public void UpdateAvatarAwakenTaskState(uint avatarID, uint taskId, proto.EProfile.TaskState state, uint process = 0u)
	{
	}

	public void UpdataMatchResultAvatarAwakenTask(List<AwakenTaskChangeInfo> avatarTaskRes)
	{
	}

	public void UpdataMatchResultAvatarAwakenNoProgressTask(uint avatarId)
	{
	}

	public void RequestFinishTaskInMatchResult()
	{
	}

	public MatchResultTaskInfo AvatarTasktoMatchResult(uint avatarID, uint taskId, proto.EProfile.TaskState state, uint process, bool NoProgress)
	{
		return null;
	}

	public void ClearMatchResultAvatarAwakenTask()
	{
	}

	public bool IsShowMatchResultWnd()
	{
		return false;
	}

	private uint GetUnitRatio(uint val, bool needChangeVal)
	{
		return 0u;
	}

	public bool IsAwakenFinished(uint oriAvatarID)
	{
		return false;
	}

	public bool IsOriAvatrLevelSatisfyForAwaken(uint oriAvatarID)
	{
		return false;
	}

	public proto.AvatarProfile GetAccountAvatarProfileById(ulong accountId)
	{
		return null;
	}

	public List<proto.AccountCollectionCustomItemInfo> GetAccountCollectionCustomById(ulong accountId)
	{
		return null;
	}

	public void ClearProfileAccountIDCache()
	{
	}

	public void TryRequestAvatarProfile(List<ulong> accountIDList, uint httpOp = 0u)
	{
	}

	private void BatchRequestAvatarProfileInCache()
	{
	}

	public void RequestGeAvatarProfileBatch(List<ulong> accountIdList, uint httpOp = 0u)
	{
	}

	public List<AvatarProfile> GetOwnedAvatarInfo()
	{
		return null;
	}

	public List<ResourceID> GetOwnedAvatarResourceId()
	{
		return null;
	}

	public uint GetAwakenAvatarIdBySkillId(uint skillId)
	{
		return 0u;
	}

	public void ProcessAvatarJumpData(List<AvatarJumpDesc> AvatarJumpList)
	{
	}

	public string GetSkillJumpUrl(uint avatarId)
	{
		return null;
	}

	public string GetVideoJumpUrl(uint avatarId)
	{
		return null;
	}

	public string GetAvatarUGCTutorialUrl(uint avatarId)
	{
		return null;
	}

	private AvatarJumpDesc GetAvatarJumpDescData(uint avatarId)
	{
		return null;
	}

	public void ProcessAvatarProficiencyInfos(List<AvatarProficiencyLevelDesc> levelDesc, List<AvatarProficiencyRewardDesc> rewardDescs)
	{
	}

	public List<AvatarProficiencyRewardDesc> GetAvatarProficiencyAwards(uint avatarId)
	{
		return null;
	}

	public bool HaveNewProficiencyReward(uint avatar)
	{
		return false;
	}

	public bool ShowProficiencyNewRewardRedTipsInAvatarList(uint avatar)
	{
		return false;
	}

	public void MarkProficiencyNewRewardRedTipsInAvatarList(uint avatar)
	{
	}

	public bool HaveClaimableProficiencyReward(uint avatarId)
	{
		return false;
	}

	public uint[] GetProficiencyLevelRange(uint level)
	{
		return null;
	}

	public uint GetProficiencyLevelByExp(uint exp)
	{
		return 0u;
	}

	public uint GetAvatarProficiencyExp(uint avatarId)
	{
		return 0u;
	}

	public uint GetAvatarProficiencyLevel(uint avatarId)
	{
		return 0u;
	}

	public AvatarProficiencyInfo GetAvatarProficiencyInfo(uint avatarId)
	{
		return null;
	}

	public bool IsProficiencyRewardClaimable(uint avatarId, uint awardLevel)
	{
		return false;
	}

	public bool IsProficiencyRewardClaimed(uint avatarId, uint awardLevel)
	{
		return false;
	}

	public uint GetOriAvatarId(uint avatarId)
	{
		return 0u;
	}

	public void ClaimAvatarProficiencyReward(uint avatarId, uint level, bool showRewardWnd = true)
	{
	}

	public void RequestAvatarProficiencyInfo(uint httpOp = 0u, bool force = true, LoadingType loadingType = LoadingType.CircleLoading, bool needNotify = true)
	{
	}

	public void OnProficiencyInfoChanged(BatchProficiencyChangeNtf changedInfos)
	{
	}

	public void LoadAvatarTagData()
	{
	}

	public AvatarTagData GetAvtarTagData(uint tagId)
	{
		return null;
	}

	public bool IsSameAvtarTag(uint tagId, uint preTagId)
	{
		return false;
	}

	private void _003CCheckPlayerCanClaimAwakenAvatar_003Eb__88_0(HttpErrorCode errorCode, object res)
	{
	}

	private bool _003CUpdateTips_003Eb__137_0(AvatarProfile a)
	{
		return false;
	}

	private void _003CRequestMyAvatarList_003Eb__142_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CForceRequestAvatarList_003Eb__143_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestSkillList_003Eb__144_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestLoginGetProfile_003Eb__145_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestLoginGetProfile_003Eb__145_1()
	{
	}

	private void _003CRequestClaimAvatarAwaken_003Eb__194_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetAvatarAwakenComicInfo_003Eb__197_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestAvatarAwakenTaskDesc_003Eb__219_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
