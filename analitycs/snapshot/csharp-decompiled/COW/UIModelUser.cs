using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using proto;
using proto.Login;
using tcp;

namespace COW;

internal class UIModelUser : UIBaseModel
{
	public enum RegisterFlowBit
	{
		RegisterComplete,
		IsClassicBROpen,
		IsTutorialBROpen,
		IsTutorialCSOpen,
		BRClassicFinish,
		BRTutorialFinish,
		EnteredCSTutorialMode,
		EnteredCSMode,
		CSPopUpFinishedByAfterBR,
		CSPopUpFinishedByModelChoice,
		IsSinglePlayerForceTutorialOpen,
		SinglePlayerForceTutorialFinish,
		CSTutorialABTest,
		CSTutorialSelectModeABTest,
		TutorialSound,
		ForceTutorialBasicPopUp,
		BRTutorialSafeZonePopUp,
		BRTutorialABTest,
		CSRankSelect,
		IsCSFirst
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<string, int> _003C_003E9__87_0;

		public static TCPParameters.KickByServerMsgDeserializer _003C_003E9__157_0;

		public static Converter<uint, string> _003C_003E9__206_0;

		public static Converter<uint, string> _003C_003E9__207_0;

		internal int _003CDoneSinglePlayerForceTutorialGame_003Eb__87_0(string s)
		{
			return 0;
		}

		internal tcp.EAccount.Proto _003CLogin_003Eb__157_0(TCPMsgPacket packet)
		{
			return tcp.EAccount.Proto.Proto_NONE;
		}

		internal string _003CRequestSetGuideShowedFlag_003Eb__206_0(uint id)
		{
			return null;
		}

		internal string _003CRequestSetGuideRedPointFlag_003Eb__207_0(uint id)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass181_0
	{
		public uint tarGetTag;

		internal bool _003CIsTagExist_003Eb__0(uint x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass206_0
	{
		public bool isInGame;

		public UIModelUser _003C_003E4__this;

		public CSUpdateGuideOfNewPlayerReq req;

		internal void _003CRequestSetGuideShowedFlag_003Eb__1(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass207_0
	{
		public CSUpdateGuideOfNewPlayerReq req;

		public UIModelUser _003C_003E4__this;

		internal void _003CRequestSetGuideRedPointFlag_003Eb__1(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private EGLJDBDMENB _003CUserLoginData_003Ek__BackingField;

	private ulong _003CAccountID_003Ek__BackingField;

	private ulong _003CRegisterTime_003Ek__BackingField;

	private string _003CNickname_003Ek__BackingField;

	private uint _003CRole_003Ek__BackingField;

	private bool _003CIsNewVersionPlayer_003Ek__BackingField;

	private ulong _003CClanID_003Ek__BackingField;

	private string _003CClanName_003Ek__BackingField;

	private uint _003CUserCoins_003Ek__BackingField;

	private int m_UserGems;

	private uint m_PaidLevel;

	private proto.EAntiAddiction.AgeState m_AgeState;

	private proto.EAccount.NewbieChoice m_NewbieChoice;

	public bool IsGetShowedGuideIds;

	private HashSet<uint> m_ShowedSystemGuideIdsSet;

	private HashSet<uint> m_ShowedInGameGuideIdsSet;

	private HashSet<uint> m_ShowedGuideRedPointsSet;

	private HashSet<uint> m_NeedUpdateInGameGuideIdsSet;

	private HashSet<uint> m_NeedUpdateInLobbyGuideIdsSet;

	private bool m_IsFakeLevelUpWindowHasShow;

	private const string KeyDoneSinglePlayerForceTutorialGame = "DoneSinglePlayerForceTutorialGame";

	public bool DoneSinglePlayerForceTutorialGameDuringStartup;

	private bool m_NeedShowLevelUpWindow;

	private bool m_CloseLevelUpWindow;

	private List<RegionIDMapping> m_RegionList;

	private bool _003CHasElitePass_003Ek__BackingField;

	private uint _003CBadgeItemId_003Ek__BackingField;

	private uint _003CBadgeItemCount_003Ek__BackingField;

	private uint _003CEmulatorScore_003Ek__BackingField;

	private proto.EPresence.AccountSocialStatus m_SocialStatus;

	private ulong m_LastRequestSetStatusTime;

	public const uint SetStatusCD = 3u;

	private Dictionary<uint, float> m_LastBlockTimeDict;

	private List<uint> m_UserTags;

	private bool m_HasShowLevelUp;

	public const uint PropID_ResourceUpdate = 2u;

	public const uint PropID_UserProfileUpdate = 4u;

	public const uint PropID_UserRenameError = 8u;

	public const uint PropID_UserRenameSuccess = 16u;

	public const uint PropID_UserLevelUp = 32u;

	public const uint PropID_CheckCdKeyError = 64u;

	public const uint PropID_CheckEmailError = 128u;

	public const uint PropID_CheckCdKeySuccess = 256u;

	public const uint PropID_SocialStatusSetSuccess = 512u;

	public const uint PropID_UserLevelUpWndClose = 1024u;

	public const uint PropID_UserLevelUpAfter = 2048u;

	private const string CharacterSet = "a0bcdefg1hjkm2npqrs3tuv456789wxy";

	private const string EncKey = "QDENCRYPTKEY";

	private const string NewPlayerFakeLevelUp = "NewPlayerFakeLevelUpInLevel2";

	private static string RegisterPlayerPrefKey;

	public EGLJDBDMENB UserLoginData
	{
		get
		{
			return _003CUserLoginData_003Ek__BackingField;
		}
		set
		{
			_003CUserLoginData_003Ek__BackingField = value;
		}
	}

	public ulong AccountID
	{
		get
		{
			return _003CAccountID_003Ek__BackingField;
		}
		private set
		{
			_003CAccountID_003Ek__BackingField = value;
		}
	}

	public ulong RegisterTime
	{
		get
		{
			return _003CRegisterTime_003Ek__BackingField;
		}
		private set
		{
			_003CRegisterTime_003Ek__BackingField = value;
		}
	}

	public string Nickname
	{
		get
		{
			return _003CNickname_003Ek__BackingField;
		}
		private set
		{
			_003CNickname_003Ek__BackingField = value;
		}
	}

	public uint Role
	{
		get
		{
			return _003CRole_003Ek__BackingField;
		}
		private set
		{
			_003CRole_003Ek__BackingField = value;
		}
	}

	public bool IsNewVersionPlayer
	{
		get
		{
			return _003CIsNewVersionPlayer_003Ek__BackingField;
		}
		set
		{
			_003CIsNewVersionPlayer_003Ek__BackingField = value;
		}
	}

	public ulong ClanID
	{
		get
		{
			return _003CClanID_003Ek__BackingField;
		}
		private set
		{
			_003CClanID_003Ek__BackingField = value;
		}
	}

	public string ClanName
	{
		get
		{
			return _003CClanName_003Ek__BackingField;
		}
		private set
		{
			_003CClanName_003Ek__BackingField = value;
		}
	}

	public uint UserCoins
	{
		get
		{
			return _003CUserCoins_003Ek__BackingField;
		}
		private set
		{
			_003CUserCoins_003Ek__BackingField = value;
		}
	}

	public int UserGems
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public uint PaidLevel => 0u;

	public uint UserLevel
	{
		get
		{
			return 0u;
		}
		private set
		{
		}
	}

	public proto.EAntiAddiction.AgeState AgeState
	{
		get
		{
			return proto.EAntiAddiction.AgeState.AgeState_NONE;
		}
		set
		{
		}
	}

	public uint UserExp
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public proto.EAccount.NewbieChoice NewbieChoice => proto.EAccount.NewbieChoice.NewbieChoice_NONE;

	public HashSet<uint> ShowedSystemGuideIdsSet
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public HashSet<uint> ShowedInGameGuideIdsSet
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public HashSet<uint> ShowedGuideRedPointsSet
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public HashSet<uint> NeedUpdateInGameGuideIdsSet
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public HashSet<uint> NeedUpdateInLobbyGuideIdsSet
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool NeedShowLevelUpWindow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CloseLevelUpWindow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public List<RegionIDMapping> RegionList => null;

	public bool HasElitePass
	{
		get
		{
			return _003CHasElitePass_003Ek__BackingField;
		}
		private set
		{
			_003CHasElitePass_003Ek__BackingField = value;
		}
	}

	public uint BadgeItemId
	{
		get
		{
			return _003CBadgeItemId_003Ek__BackingField;
		}
		private set
		{
			_003CBadgeItemId_003Ek__BackingField = value;
		}
	}

	public uint BadgeItemCount
	{
		get
		{
			return _003CBadgeItemCount_003Ek__BackingField;
		}
		private set
		{
			_003CBadgeItemCount_003Ek__BackingField = value;
		}
	}

	public uint EmulatorScore
	{
		get
		{
			return _003CEmulatorScore_003Ek__BackingField;
		}
		set
		{
			_003CEmulatorScore_003Ek__BackingField = value;
		}
	}

	public proto.EPresence.AccountSocialStatus SocialStatus
	{
		get
		{
			return proto.EPresence.AccountSocialStatus.AccountSocialStatus_NONE;
		}
		set
		{
		}
	}

	public ulong LastRequestSetStatusTime => 0uL;

	public bool ReadyToSetSocialStatus => false;

	public bool IsAutoAccpetInvitation => false;

	public bool HasShowLevelUp
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void SetNewbieChoice(proto.EAccount.NewbieChoice choice)
	{
	}

	public bool IsNewPlayerOrFPSPlayerAfaterOB46()
	{
		return false;
	}

	public bool IsNewPlayerAfterOB46()
	{
		return false;
	}

	public bool IsLimitQuickNext()
	{
		return false;
	}

	public LevelEntranceDataManager.LockStatusType IsShowEntranceByLevel(uint entrancetype)
	{
		return LevelEntranceDataManager.LockStatusType.NoLock;
	}

	public uint GetShowEntranceUnLockLevelByGoPos(uint gopos, bool IsV2 = true)
	{
		return 0u;
	}

	public bool HaveDoneSinglePlayerForceTutorialGame()
	{
		return false;
	}

	public void DoneSinglePlayerForceTutorialGame()
	{
	}

	public bool IsVeteranNewbieType()
	{
		return false;
	}

	public bool EnableSinglePlayerForceTutorialGame()
	{
		return false;
	}

	public bool EnableForceTutorialSound()
	{
		return false;
	}

	public bool EnableForceTutorialBasicPopUp()
	{
		return false;
	}

	public bool EnableBRTutorialSafeZonePopUp()
	{
		return false;
	}

	public bool IsLastGameSinglePlayerForceTutorialGame()
	{
		return false;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public bool IsLogin()
	{
		return false;
	}

	public byte GetRegionIDByName(string regionName)
	{
		return 0;
	}

	public override void LoginOffline()
	{
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public uint GetNotificationPopUpDuration(ENotificationPopUpType type)
	{
		return 0u;
	}

	public uint GetNotificationPopUpDuration(NotifyIDType type)
	{
		return 0u;
	}

	public bool IsAllowNotificationPopUp(ENotificationPopUpType type)
	{
		return false;
	}

	public bool IsAllowNotificationPopUp(NotifyIDType type)
	{
		return false;
	}

	public void UpdateLevelUpInfo(AccountLevelUpInfo levelUpInfo)
	{
	}

	public void AfterMatch(MatchIncome inData)
	{
	}

	public bool CheckNeedFakeLevelUpInLevel2()
	{
		return false;
	}

	public void BlockLobbyNotificationPopUp(ENotificationPopUpType type)
	{
	}

	public void BlockLobbyNotificationPopUp(NotifyIDType type)
	{
	}

	public void AfterQuestBackpack(AccountWallet wData)
	{
	}

	public void RefreshUserResource(uint coins, int gems)
	{
	}

	public void UpdateUserPaidLevel(uint paidLevel)
	{
	}

	public void CheckWeeklyCoins(uint coinsOutGameWeekly)
	{
	}

	public void RefreshUserResourceByDeltaValue(int deltaCoins, int deltaGem)
	{
	}

	public void SetClanID(ulong clanid)
	{
	}

	public void UserRename(string new_name, bool useCard)
	{
	}

	public void CheckCdKey(string email, string key)
	{
	}

	public void UpdateUserRole(AccountRoleInfo roleInfo)
	{
	}

	public bool IsUGCUser()
	{
		return false;
	}

	public int GetUserGameDays()
	{
		return 0;
	}

	public void RequestSetSocialStatus(proto.EPresence.AccountSocialStatus socialStatus)
	{
	}

	public void RequestUserTags(HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public bool IsTagExist(uint tarGetTag)
	{
		return false;
	}

	private void ResizeResolutionByRegion(string region)
	{
	}

	public string GetAccountIdEnc()
	{
		return null;
	}

	private string GetDynamicKey(int idx)
	{
		return null;
	}

	public string ULongEncryption(ulong ori)
	{
		return null;
	}

	public void SaveLocalNewbieVeteranChoice(proto.EAccount.NewbieChoice registerCheckNewbieVeteran)
	{
	}

	public proto.EAccount.NewbieChoice ReadLocalNewbieVeteranChoice()
	{
		return proto.EAccount.NewbieChoice.NewbieChoice_NONE;
	}

	public bool IsNeedSinglePlayerForceTutorial()
	{
		return false;
	}

	public bool HaveCompleteSinglePlayerForceTutorial()
	{
		return false;
	}

	public bool IsNeedTutorialCS()
	{
		return false;
	}

	public bool IsNeedClassicCS()
	{
		return false;
	}

	public bool IsTutorialCSFirst()
	{
		return false;
	}

	public bool IsNeedTutorialBR()
	{
		return false;
	}

	public bool IsNeedFirstGuideMatch()
	{
		return false;
	}

	public void SaveRegisterFlow(RegisterFlowBit bit, ulong accountId = 0uL)
	{
	}

	public void SetZeroRegisterFlow([Optional][DefaultParameterValue(0uL)] ulong accountId, RegisterFlowBit[] bits)
	{
	}

	public bool ReadRegisterFlow(RegisterFlowBit bit)
	{
		return false;
	}

	public void AddShowedGuideIds(HashSet<uint> showedGuideIdSet, uint[] guideIds)
	{
	}

	public void UpdateInGameGuideIdsEachGame()
	{
	}

	public void SetLobbyGuidesBackendFlagByOldPref()
	{
	}

	public bool GetBackendFlag(uint guideId, bool isInGame)
	{
		return false;
	}

	public bool GetGuideRedPointFlag(uint guideId)
	{
		return false;
	}

	public void RequestGuideShowedFlag(HttpManager.EHttpChannel channel)
	{
	}

	public void RequestSetGuideShowedFlag(bool isInGame, uint[] guideIds)
	{
	}

	public void RequestSetGuideRedPointFlag(uint[] guideIds)
	{
	}

	private void _003CUserRename_003Eb__174_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CCheckCdKey_003Eb__175_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CRequestUserTags_003Eb__180_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CRequestGuideShowedFlag_003Eb__205_0(HttpErrorCode errorCode, object obj)
	{
	}

	public void _003C_003EiFixBaseProxy_LoginOffline()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
