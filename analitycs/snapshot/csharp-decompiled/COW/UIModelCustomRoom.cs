using System;
using System.Collections.Generic;
using System.IO;
using GCommon;
using message;
using proto;
using tcp;

namespace COW;

public class UIModelCustomRoom : UIBaseModel
{
	private class RoomPlayerCustomPresetDetail
	{
		public RoomCreateReq presetReq;

		public bool isDirty;

		public void RefreshSettingDetail(RoomCreateReq preset, bool isDirty = true)
		{
		}
	}

	public enum ECustomRoomGameSetting
	{
		None,
		Revive,
		HP,
		EP,
		MoveSpeed,
		JumpHeight,
		Weather,
		UnLimitedAmmo,
		NoFallDamage,
		NoLoadOut,
		NoAirDrop,
		NoSkill,
		NoVehicles,
		NoPowerGun,
		NoUAV,
		NoBomb,
		NoZeppelin,
		HideEnemyCloth,
		NoHud,
		FriendDmg,
		CSRound,
		CSInitEco,
		FightClubRound,
		ShopFlow,
		UseRandomMap,
		NoAuxAim,
		InGameChat,
		AutoRevival,
		SaveZoneSpeed,
		SaveZoneDamage,
		GameMission,
		SpecialCSEnv,
		GlobalMission,
		AirdropType,
		AFKPunish,
		HeadShotOnly,
		SoloActiveSkill,
		BRWeaponBox,
		UnLimitedThrowables,
		PrivilegeVoice,
		PrivilegeScoreBoard,
		ItemGenerator,
		GameAffix,
		BanPick
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<string, int> _003C_003E9__426_0;

		public static Converter<string, int> _003C_003E9__428_0;

		internal int _003CInitDefaultCSSettingFromConfig_003Eb__426_0(string s)
		{
			return 0;
		}

		internal int _003CInitCSShopSettingFromBytes_003Eb__428_0(string s)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass297_0
	{
		public ulong id;

		internal bool _003CBatchJoinRoom_003Eb__0(tcp.RoomInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass306_0
	{
		public RoomSyncPatchOptionalResStatusNtf resData;

		public Predicate<RoomPlayerInfo> _003C_003E9__1;

		internal bool _003CUpdateCurrentOptionalMapResState_003Eb__1(RoomPlayerInfo value)
		{
			return false;
		}

		internal bool _003CUpdateCurrentOptionalMapResState_003Eb__0(RoomPlayerInfo value)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass307_0
	{
		public RoomPlayerInfo player;

		internal bool _003CUpdateCurrentReadyState_003Eb__0(RoomPlayerInfo p)
		{
			return false;
		}

		internal bool _003CUpdateCurrentReadyState_003Eb__1(RoomGroupInfo g)
		{
			return false;
		}

		internal bool _003CUpdateCurrentReadyState_003Eb__2(RoomPlayerInfo p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass394_0
	{
		public ulong id;

		internal bool _003CIsMyBatchRoom_003Eb__0(tcp.RoomInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass395_0
	{
		public ulong roomid;

		internal bool _003CClearBatchData_003Eb__0(tcp.RoomInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass396_0
	{
		public tcp.RoomInfo roomInfo;

		internal bool _003CUpdateBatchRoomInfo_003Eb__0(tcp.RoomInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass397_0
	{
		public RoomStateNtf state;

		internal bool _003CUpdateBatchRoomState_003Eb__0(tcp.RoomInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass398_0
	{
		public ulong roomid;

		internal bool _003CUpdateBatchRoomReadyState_003Eb__0(tcp.RoomInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass400_0
	{
		public RoomChangeAvailableMapsNtf info;

		internal bool _003CUpdateBatchRoomPlayerAvailableMaps_003Eb__0(tcp.RoomInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass429_0
	{
		public byte poiid;

		internal bool _003CInitADCSMapSettingFromBytes_003Eb__0(ADCSMapData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass478_0
	{
		public UIModelCustomRoom _003C_003E4__this;

		public string code;

		internal void _003CRequestRoomParamsData_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass489_0
	{
		public Action onOK;

		public Action onCancel;

		public int retryCount;

		public string key;

		public ulong lastMatchId;

		internal void _003CTryReconnectMatchAfterLogin_003Eb__0()
		{
		}

		internal void _003CTryReconnectMatchAfterLogin_003Eb__1()
		{
		}
	}

	private Dictionary<uint, RoomPlayerCustomPresetDetail> m_RoomSettingDict;

	private bool m_IsPresetDownload;

	public const string LEAGEROOMGROUPACCOUNTLIST = "LEAGEROOMGROUPACCOUNTLIST";

	public const string LEAGEROOMGROUPNAMECACHE = "LEAGEROOMGROUPNAMECACHE";

	public const string LEAGEROOMGROUPNICKNAMECACHE = "LEAGEROOMGROUPNICKNAMECACHE";

	public const string ADVANCED_SETTING = "T_41_LYF_ROOM_NAME_CUSTOMROOM";

	private ECustomRoomRole _003CMyRoomRole_003Ek__BackingField;

	private bool _003CAmIAtPlayerSeat_003Ek__BackingField;

	public ulong LastGetRemindTimeStamp;

	public bool IsJoinFromScanQRCode;

	private tcp.RoomInfo m_CurrentRoomInfo;

	private ulong m_LastReportedSocialHallCustomRoomId;

	private DKPCAEMALDP m_RoomCustomParams;

	private Dictionary<string, string> m_RoomCustomParamLocDict;

	private RoomPlayerInfo m_MyPlayerInfo;

	private RoomGroupInfo m_MyGroupInfo;

	private bool m_IsBPMode;

	public int UIRootWidth;

	public static EGameVoiceListenMode RoomBeforeEnterMicrophoneMode;

	public static EGameVoiceListenMode RoomBeforeEnterSpeakerMode;

	public static uint RoomVoiceRecordStart;

	public static uint RoomVoiceTotal;

	public static uint TeamVoiceRecordStart;

	public static uint TeamVoiceTotal;

	public static List<string> PlayerMuteBeforeEnter;

	public bool IsUGCRoomListOpened;

	public bool HaveQuickJoinRoomRequst;

	public bool HasQuickJoined;

	public bool IsRoomHangup;

	private bool m_IsLobbySwitchRoomHangupPending;

	public bool IsScanQRCodeJoin;

	public uint CurrentRefreshTime;

	private bool m_RoomCreateRulesRequestPending;

	private int m_ModeFilter;

	public bool BackToEsportsWebView;

	public static string HalfWayJoinTimes;

	public static string HalfWayJoinTimesSwitch;

	private Dictionary<ulong, HashSet<ulong>> m_RepeatActiveSkillAccountIds;

	private int m_GroupFilter;

	private int m_StateFilter;

	private string m_SearchFilte;

	private bool m_ShowNickName;

	private bool m_HasPendingRoomMatchRequest;

	public Dictionary<uint, uint> CardTypeItemIdDic;

	public Dictionary<uint, uint> LimitedCardTypeItemIdDic;

	public Dictionary<uint, string> RoomModeNameDict;

	public const string OB35_FREE_ROOM_CARD_GUIDE = "OB35_FREE_ROOM_CARD_GUIDE";

	public Dictionary<uint, string> CustomRoomGameSettingTitle;

	public const uint PropID_RoomListUpdated = 2u;

	public const uint PropID_RoomInfoUpdated = 4u;

	public const uint PropID_RefreshRoomParams = 8u;

	public const uint PropID_OnHttpResRoomParams = 16u;

	public const uint PropID_SendChangeRoomParams = 32u;

	public const uint PropID_StartDownloadRoomParamsLoc = 64u;

	public const uint PropID_PresetUploadSuccess = 128u;

	public const uint PropID_PresetUploadFail = 256u;

	public const uint PropID_PresetDownloadSuccess = 512u;

	public const uint PropID_PresetDownloadFail = 1024u;

	public const uint PropID_HasRepeatActiveSkill = 2048u;

	public const uint PropID_PresetRoomListUpdated = 4096u;

	public const uint PropID_RoomWinRateStatsUpdated = 8192u;

	private UIModelGroup m_ModelGroup;

	private Dictionary<uint, List<tcp.RoomBasicInfo>> m_RoomListDict;

	private Dictionary<uint, List<ulong>> m_FailRoomListDict;

	private Dictionary<uint, List<tcp.RoomBasicInfo>> m_PresetRoomListDict;

	private Dictionary<uint, List<ulong>> m_PresetFailRoomListDict;

	private Queue<uint> m_RoomListRequestPresetIdQueue;

	private MemoryStream m_MemStream;

	private BinaryWriter m_Writer;

	private BinaryReader m_Reader;

	private bool m_HasCountdownFinished;

	private bool m_HasSendTimeoutPack;

	private Action m_MatchNotifySucAction;

	private bool m_IsRequestingRoomStats;

	private bool m_HasRoomStatsCache;

	private bool m_ShowWinSelected;

	private ulong m_LastRoomWinRateChatRoomId;

	private uint m_LastRoomWinRateChatMode;

	private bool m_LastRoomWinRateChatEnabled;

	private PlayerRoomStatsInfo m_PlayerRoomStatsInfo;

	private Dictionary<uint, RoomWinRateModeData> m_RoomWinRateModeDataDict;

	private ulong m_RoomBattleShareWinStatsMatchId;

	private bool m_HasRequestedRoomBattleShareWinStats;

	private Dictionary<uint, ulong> m_CreateRoomCDFinish;

	private Dictionary<uint, int> m_CreateRoomCD;

	private Dictionary<uint, int> m_CreateRoomTypeCD;

	private Dictionary<uint, ulong> m_CreateRoomTypeCDFinish;

	private ulong m_LatestTryConnectMatchId;

	public bool LatestWorkshopRoom;

	public const uint RoomSettingDropType_CheatCode = 13u;

	public const uint RoomSettingDropType_CSEsports = 15u;

	private uint _003CDropIndex_003Ek__BackingField;

	private const string ShowWinTogglePlayerPrefKey = "ROOM_SHOW_WIN_RATE_TOGGLE";

	private const int ShowWinTogglePrefDefault = 0;

	private const int ShowWinTogglePrefOn = 1;

	private const int ShowWinTogglePrefOff = 2;

	private ulong m_ChangeRoomMapCDFinish;

	private EGameVoiceListenMode m_CurrentModel;

	private EGameVoiceListenMode m_PreModel;

	private EGameVoiceListenMode m_CurrentMic;

	private ulong m_ReopenId;

	private int m_SelectedPos;

	private ulong m_ForbiddenTimeStamp;

	private List<tcp.RoomInfo> m_BatchRoomInfoList;

	private const int ADCS_MIN_ROUND = 7;

	private bool m_ADCSDefaultConfigInited;

	private Dictionary<uint, int> m_AdCSShopSettingValueDic;

	private Dictionary<uint, bool> m_AdCSShopSettingCheckDic;

	private Dictionary<int, int> m_AdCSEcoRoundValueDic;

	private Dictionary<int, uint> m_AdCSMapZoneRoundValueDic;

	private Dictionary<uint, CustomCSShopUpgradeGroup> m_CustomCSShopUpgradeGroups;

	private Dictionary<uint, uint> m_CustomCSShopSettingIndexToGroupID;

	private bool _003CADCSEnabled_003Ek__BackingField;

	private int _003CAdCSEcoRound_003Ek__BackingField;

	private bool _003CADCSMapEnabled_003Ek__BackingField;

	private uint _003CADCSMap_003Ek__BackingField;

	public static readonly uint WereWolvesMapConfigID;

	private const int WereWolvesParamBitStep = 8;

	public static readonly uint RushingPetsMapConfigID;

	private const int RushingPetsParamBitStep = 8;

	private int _003CScoreVisible_003Ek__BackingField;

	private int _003COBSwitchSeatEnabled_003Ek__BackingField;

	private bool _003CIsAutoLeaveGroup_003Ek__BackingField;

	public ECustomRoomAutoCreate NoMatchMakingAutoCreateRoom;

	public RoomPlatformDetail m_CachePlatformDetail;

	public bool IsPresetDownload => false;

	public ECustomRoomRole MyRoomRole
	{
		get
		{
			return _003CMyRoomRole_003Ek__BackingField;
		}
		set
		{
			_003CMyRoomRole_003Ek__BackingField = value;
		}
	}

	public bool AmIAtPlayerSeat
	{
		get
		{
			return _003CAmIAtPlayerSeat_003Ek__BackingField;
		}
		private set
		{
			_003CAmIAtPlayerSeat_003Ek__BackingField = value;
		}
	}

	public DKPCAEMALDP RoomParamsData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Dictionary<string, string> RoomCustomParamLocDict => null;

	public bool IsBPMode => false;

	public bool IsMatchMaking => false;

	public Dictionary<ulong, HashSet<ulong>> RepeatActiveSkillAccountIds => null;

	public int ModeFilter
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int GroupFilter
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int StateFilter
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string SearchFilter
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool ShowNickName
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasPendingRoomMatchRequest
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ulong LatestTryConnectMatchId
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public uint DropIndex
	{
		get
		{
			return _003CDropIndex_003Ek__BackingField;
		}
		set
		{
			_003CDropIndex_003Ek__BackingField = value;
		}
	}

	public bool DisableAuthority => false;

	public ulong ChangeRoomMapCDFinish => 0uL;

	public tcp.RoomInfo CurrentRoomInfo => null;

	public RoomPlayerInfo MyPlayerInfo => null;

	public uint MyGroupIndex => 0u;

	public RoomGroupInfo MyGroup => null;

	public uint CurrentGroupMode => 0u;

	public List<RoomPlayerInfo> CurrentSpectators => null;

	public List<RoomGroupInfo> CurrentGroups => null;

	public List<RoomGroupInfo> CurrentGroupsOriginList => null;

	public int CurrentRealGroupCount => 0;

	public int CurrentPlayerCount => 0;

	public int CurrentSpectatorCount => 0;

	public int CurrentGroupCount => 0;

	public EGameVoiceListenMode CurrentSpeakerMode
	{
		get
		{
			return EGameVoiceListenMode.None;
		}
		set
		{
		}
	}

	public EGameVoiceListenMode PreSpeakerMode => EGameVoiceListenMode.None;

	public EGameVoiceListenMode CurrentMicMode
	{
		get
		{
			return EGameVoiceListenMode.None;
		}
		set
		{
		}
	}

	public int PlayerPrefCheatCode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsForbiddenJoinRoom => false;

	public bool ADCSEnabled
	{
		get
		{
			return _003CADCSEnabled_003Ek__BackingField;
		}
		set
		{
			_003CADCSEnabled_003Ek__BackingField = value;
		}
	}

	public int AdCSEcoRound
	{
		get
		{
			return _003CAdCSEcoRound_003Ek__BackingField;
		}
		set
		{
			_003CAdCSEcoRound_003Ek__BackingField = value;
		}
	}

	public bool ADCSMapEnabled
	{
		get
		{
			return _003CADCSMapEnabled_003Ek__BackingField;
		}
		set
		{
			_003CADCSMapEnabled_003Ek__BackingField = value;
		}
	}

	public uint ADCSMap
	{
		get
		{
			return _003CADCSMap_003Ek__BackingField;
		}
		set
		{
			_003CADCSMap_003Ek__BackingField = value;
		}
	}

	public proto.ESocial.Language WereWolvesRoomLanguage => proto.ESocial.Language.Language_NONE;

	public int ScoreVisible
	{
		get
		{
			return _003CScoreVisible_003Ek__BackingField;
		}
		set
		{
			_003CScoreVisible_003Ek__BackingField = value;
		}
	}

	public int OBSwitchSeatEnabled
	{
		get
		{
			return _003COBSwitchSeatEnabled_003Ek__BackingField;
		}
		set
		{
			_003COBSwitchSeatEnabled_003Ek__BackingField = value;
		}
	}

	public bool IsAutoLeaveGroup
	{
		get
		{
			return _003CIsAutoLeaveGroup_003Ek__BackingField;
		}
		set
		{
			_003CIsAutoLeaveGroup_003Ek__BackingField = value;
		}
	}

	private void ProcessRoomSettingDownload(RoomPresetSetting setting)
	{
	}

	public void RequestUploadRoomSetting()
	{
	}

	public void RequestDownloadRoomPreset()
	{
	}

	public RoomCreateReq GetRoomPresetByMode(uint gameMode)
	{
		return null;
	}

	public void SetRoomPresetByMode(uint gameMode, RoomParams param)
	{
	}

	public void CreateRoomByPreset(RoomCreateReq req)
	{
	}

	public void GroupCreateRoomByPreset(RoomCreateReq req)
	{
	}

	private bool PresetCheckBeforeCreate(RoomCreateReq req)
	{
		return false;
	}

	private GroupCreateRoomReq GetGroupRoomReqByRoomReq(RoomCreateReq reqRoom)
	{
		return null;
	}

	public bool HavePreset(uint gameMode)
	{
		return false;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void MarkLobbySwitchRoomHangupPending()
	{
	}

	public bool ConsumeLobbySwitchRoomHangupPending()
	{
		return false;
	}

	public bool InitCreateRoomCD()
	{
		return false;
	}

	public bool InitCreateRoomTypeCD()
	{
		return false;
	}

	public void SetCreateRoomCoolDown(proto.EInventory.ItemSubType subType)
	{
	}

	public void SetCreateRoomTypeCoolDown(tcp.ERoom.Type subType)
	{
	}

	public bool CheckCreateRoomCoolDown(proto.EInventory.ItemSubType subType)
	{
		return false;
	}

	public bool CheckCreateRoomTypeCoolDown(tcp.ERoom.Type subType)
	{
		return false;
	}

	public bool TryGetCreateRoomTypeCoolDownEndTime(tcp.ERoom.Type subType, out ulong endTime)
	{
		endTime = default(ulong);
		return false;
	}

	public ulong GetCoolDown(proto.EInventory.ItemSubType subType)
	{
		return 0uL;
	}

	public ulong GetRoomTypeCoolDown(tcp.ERoom.Type subType)
	{
		return 0uL;
	}

	public static string GetPlayerPrefKeyForDropID(uint dropID, ulong accountID)
	{
		return null;
	}

	private string GetShowWinTogglePlayerPrefKey()
	{
		return null;
	}

	private string GetShowWinRateNewTagKey()
	{
		return null;
	}

	public bool ShouldShowShowWinRateNewTag()
	{
		return false;
	}

	public void MarkShowWinRateNewTagRead()
	{
	}

	public bool IsShowWinRateSupportedMode(uint gameMode)
	{
		return false;
	}

	public bool IsRoomShowWinTagOpen()
	{
		return false;
	}

	public bool CanUseShowWinRateFeature(uint gameMode)
	{
		return false;
	}

	private bool GetShowWinRateUploadValue(uint gameMode, uint roomSetting3)
	{
		return false;
	}

	public void SetShowWinSelected(bool selected, bool savePlayerPref = false)
	{
	}

	public bool GetShowWinSelected()
	{
		return false;
	}

	public bool GetShowWinSelectedByPlayerPref(uint showWinState)
	{
		return false;
	}

	public bool GetInitialShowWinToggleStateByMode(string roomType, uint mapConfigId, uint groupMode, uint gameMode)
	{
		return false;
	}

	public uint GetRoomCreateRuleShowWinStateByMode(string roomType, uint mapConfigId, uint groupMode)
	{
		return 0u;
	}

	public bool TryGetRoomWinRateModeData(uint gameMode, out RoomWinRateModeData data)
	{
		data = null;
		return false;
	}

	public bool HasPlayerRoomStatsCache()
	{
		return false;
	}

	public bool IsRequestingPlayerRoomStats()
	{
		return false;
	}

	public bool HasRequestedRoomBattleShareWinStats(ulong matchId)
	{
		return false;
	}

	public void MarkRoomBattleShareWinStatsRequested(ulong matchId)
	{
	}

	public bool TryGetRoomFriendWinCount(ulong friendId, out uint wins)
	{
		wins = default(uint);
		return false;
	}

	public void ClearPlayerRoomStatsCache()
	{
	}

	public void ResetRoomWinRateChatRecord()
	{
	}

	public bool IsCurrentRoomShowWinEnabled()
	{
		return false;
	}

	public RoomWinRateModeData GetOwnerWinRateModeDataByRoomInfo(uint gameMode)
	{
		return null;
	}

	public string GetCurrentRoomOwnerName()
	{
		return null;
	}

	public bool ShouldPostRoomWinRateChatMessage()
	{
		return false;
	}

	public void ConsumeRoomWinRateChatMessagePosted()
	{
	}

	public void RequestPlayerRoomStats(bool force = false)
	{
	}

	private void UpdatePlayerRoomStatsCache(PlayerRoomStatsInfo statsInfo)
	{
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

	public List<tcp.RoomBasicInfo> GetRoomListByType(tcp.ERoom.TabType roomType)
	{
		return null;
	}

	public List<ulong> GetFaillRoomListByType(tcp.ERoom.TabType roomType)
	{
		return null;
	}

	public List<tcp.RoomBasicInfo> GetPresetRoomListByPresetId(uint presetId)
	{
		return null;
	}

	public List<ulong> GetPresetFaillRoomListByPresetId(uint presetId)
	{
		return null;
	}

	public List<tcp.RoomBasicInfo> GenerateRoomBasicInfoFromBatchRoom()
	{
		return null;
	}

	public void SetChangeRoomMapCoolDown()
	{
	}

	public bool CheckChangeRoomMapCoolDown()
	{
		return false;
	}

	public uint GetGroupIcon()
	{
		return 0u;
	}

	public uint CalPlayerCount(tcp.RoomInfo info)
	{
		return 0u;
	}

	public void RequestSyncOptionalMapResStatus(tcp.ERoom.PlayerPatchOptionalResStatus status)
	{
	}

	public void RequestRoomList(tcp.ERoom.TabType tabType, ulong id = 0uL, List<EMatch.GameMode> gameModes = null, string code = null, ulong esportsId = 0uL)
	{
	}

	public void RequestPresetRoomList(tcp.ERoom.TabType tabType, uint presetId, List<EMatch.GameMode> gameModes = null, uint filterPresetId = 0u)
	{
	}

	private bool IsDefaultRoomName(string name)
	{
		return false;
	}

	public void RequestCreateRoom(RoomParams param, ECustomRoomAutoCreate autoCreate = ECustomRoomAutoCreate.None)
	{
	}

	public void RequestGroupCreateRoom(RoomParams param, ECustomRoomAutoCreate autoCreate = ECustomRoomAutoCreate.None)
	{
	}

	public void RequsetChangeRoomClassToNormal()
	{
	}

	public void RequestChangeRoom(RoomParams param)
	{
	}

	public void RequestJoinRoom(ulong id, string code = "", string name = "", string nameAbbr = "", bool solo = false, bool skipTickCheck = false, ulong inviterid = 0uL, uint roomType = 0u, ECustomRoomJoinType joinType = ECustomRoomJoinType.ECustomRoomJoinType_Normal, ECustomRoomJoinScene joinScene = ECustomRoomJoinScene.ECustomRoomJoinScene_None, EUGCScene ugcScene = EUGCScene.EUGCScene_None, string roomqrcode = "", string recruitCode = "", uint channelType = 1u)
	{
	}

	public void RequestJoinFriendRoom(ulong id, uint roomType, ulong friendId)
	{
	}

	public void RequestJoinRoomDirectly(ulong id, tcp.ERoom.Type roomType)
	{
	}

	public void RequestJoinRoomByQRCode(ulong id, tcp.ERoom.Type roomType, string roomQRCode)
	{
	}

	public void RequestUpdateRoomHostLastActiveTime()
	{
	}

	public void UpdateRoomHostLastInactiveTime(long lastInactiveTime)
	{
	}

	public void RequestRemind()
	{
	}

	public void InvitationRequestJoinRoom(ulong id, bool skipTickCheck, ulong inviterid, uint map, uint mode, uint roomtype)
	{
	}

	public void QRCodeInvitationRequestJoinRoom(ulong id, ulong inviterid, uint roomtype, string qrcode)
	{
	}

	public void RequestSpectateRoom(ulong id, string code = "", bool solo = false, uint roomType = 0u)
	{
	}

	public void RequestSpectateUGCRoom(ulong accountId, ulong roomId)
	{
	}

	public void RequestRoomInfo(ulong id, tcp.ERoom.Type roomType)
	{
	}

	public void CheckWorkshopMapStateOrMatchSuccess()
	{
	}

	public void RequestWorkshopTimeoutOrMatchSuccess(bool request)
	{
	}

	public void RequestWorkshopTimeout()
	{
	}

	public void RequestLeaveRoom()
	{
	}

	public void RequestBatchLeaveRoom(ulong id)
	{
	}

	public void RequestStartGame(ulong id)
	{
	}

	public void ClearMatchSucNotify()
	{
	}

	public void RequsetCountDown(ulong id, uint time)
	{
	}

	public void SetWaitMatchAction(Action match)
	{
	}

	public bool NeewWaitLoadingGame()
	{
		return false;
	}

	public bool IsTimeoutOfUGCRoomMatch()
	{
		return false;
	}

	public void RequestDropMatch()
	{
	}

	public void RequestSetReady(bool ready)
	{
	}

	public void RequestSwitchSeat(ulong account_id, tcp.ERoom.PlayerRole role = tcp.ERoom.PlayerRole.PlayerRole_MEMBER, uint teamIndex = 0u, uint memberIndex = 0u)
	{
	}

	public void RequestSwitchGroup(int from, int to)
	{
	}

	public void RequestInvite(ulong account_id, bool needAutoAcpt = false)
	{
	}

	public void RequestRefuseReq(ulong account_id)
	{
	}

	public void RequestUpdateMaps(List<uint> maps)
	{
	}

	public void RequestRoomCreateRules()
	{
	}

	public void RequestKickPlayer(ulong id)
	{
	}

	public void ClearData(string ctx)
	{
	}

	private void ClearRoomHangupState()
	{
	}

	public void ReportCustomRoomIdToSocialHall(bool force = false)
	{
	}

	public void UpdateRoomList(RoomListRes infos)
	{
	}

	private void UpdatePresetRoomList(uint presetId, RoomListRes infos)
	{
	}

	public void ClearRoomList()
	{
	}

	public void RecordFailJoinRoom(tcp.ERoom.Type type, ulong roomID)
	{
	}

	public void RecordPresetFailJoinRoom(uint presetId, ulong roomID)
	{
	}

	private void UpdateRoomInfo(tcp.RoomInfo info)
	{
	}

	public bool UseTeamVoiceChat()
	{
		return false;
	}

	public bool EnableRoomVoiceChat()
	{
		return false;
	}

	public void UpdateCreateRoomInfo(tcp.RoomInfo info)
	{
	}

	public void UpdateBatchCreateRoomInfo(tcp.RoomInfo info)
	{
	}

	public void BatchJoinRoom(ulong id)
	{
	}

	public bool IsAdvanceRoom()
	{
		return false;
	}

	public bool IsUGCAdvanceRoom()
	{
		return false;
	}

	private string GetChangedParams(tcp.RoomInfo info)
	{
		return null;
	}

	public void IsChangeParams(tcp.RoomInfo resdata)
	{
	}

	public void UpdateCurrentRoomInfo(tcp.RoomInfo info, bool checkSeat = false)
	{
	}

	public void CheckPlayersWhoEquipRepeatActiveSkillInGroup()
	{
	}

	public void CancelCheckRepeatActiveSkill()
	{
	}

	public void CacheGroupNameAndAbbrName()
	{
	}

	public void UpdateCurrentOptionalMapResState(RoomSyncPatchOptionalResStatusNtf resData)
	{
	}

	public void UpdateCurrentReadyState(tcp.RoomInfo roomInfo, List<RoomPlayerInfo> players, bool needNotify)
	{
	}

	public void UpdateRoomState(tcp.RoomInfo roomInfo, RoomStateNtf state, bool needNotify)
	{
	}

	public void UpdateRoomPlayerAvailableMaps(tcp.RoomInfo roomInfo, RoomChangeAvailableMapsNtf info, bool needNotify)
	{
	}

	public void UpdateRoom()
	{
	}

	private RoomPlayerInfo FindMyPlayerInfoFromRoomInfo()
	{
		return null;
	}

	public List<RoomPlayerInfo> GetRoomPlayers(bool includeSpectators = true, bool includeSelf = true)
	{
		return null;
	}

	public bool IsValidLeaguePlayer(uint groupMode)
	{
		return false;
	}

	public bool CheckIsValidUser()
	{
		return false;
	}

	public bool IsRoomMaster()
	{
		return false;
	}

	public bool IsRoomPartner()
	{
		return false;
	}

	public bool IsValidPCUser()
	{
		return false;
	}

	public bool IsMobileRoomMaster()
	{
		return false;
	}

	public bool CheckEmptySeat(out uint teamIndex, out uint memberIndex)
	{
		teamIndex = default(uint);
		memberIndex = default(uint);
		return false;
	}

	public bool IsNeedLeaveNew(List<RoomPlayerInfo> players)
	{
		return false;
	}

	public bool IsSelf(ulong id)
	{
		return false;
	}

	public bool ContainSelf(List<RoomPlayerInfo> infos)
	{
		return false;
	}

	public bool IsCreater()
	{
		return false;
	}

	public bool IsPlayer()
	{
		return false;
	}

	public bool IsSpectator()
	{
		return false;
	}

	public bool IsGroupLeader()
	{
		return false;
	}

	public bool NeedShowReadyBtn()
	{
		return false;
	}

	public bool NeedShowRemindBtn()
	{
		return false;
	}

	public bool IsReadyBtnEnabled()
	{
		return false;
	}

	public bool CurrentReadyState()
	{
		return false;
	}

	public void OnCustomRoomDismissed(tcp.ERoom.DismissReason reason)
	{
	}

	public bool IsInRoom()
	{
		return false;
	}

	public bool IsInUGCRoomMatchMaking()
	{
		return false;
	}

	public bool IsInLeagueRoom()
	{
		return false;
	}

	public bool IsCasualLikeRoom(tcp.ERoom.Type type)
	{
		return false;
	}

	public bool IsOBSwitchSeatEnabled()
	{
		return false;
	}

	public bool CanJoinMyRoom(BaseProfileInfo info)
	{
		return false;
	}

	public bool IsMyRoomFull()
	{
		return false;
	}

	public bool IsClanOrCasualRoom()
	{
		return false;
	}

	public bool IsCasualRoomType(uint type)
	{
		return false;
	}

	public bool IsLeagueRoomType(uint type)
	{
		return false;
	}

	public bool IsCasualRoom()
	{
		return false;
	}

	public bool IsWorkshopRoom(tcp.ERoom.Type type)
	{
		return false;
	}

	public bool IsInWorkshopRoom()
	{
		return false;
	}

	public bool IsInUGCHalfwayJoinRoom()
	{
		return false;
	}

	public bool IsInTournamentRoom()
	{
		return false;
	}

	public bool IsInRushingPetsRoom()
	{
		return false;
	}

	public bool IsInSocialIslandRoom()
	{
		return false;
	}

	public bool IsCheatcodeRoom()
	{
		return false;
	}

	public bool IsLeagueRoom(tcp.ERoom.Type type)
	{
		return false;
	}

	public bool NeedShowQuickStartBtn()
	{
		return false;
	}

	public bool IsInSpectatorSeat()
	{
		return false;
	}

	public bool CheckIsValidSpectatorNumSetting(uint num)
	{
		return false;
	}

	public ulong GetNotReadyMemberId()
	{
		return 0uL;
	}

	public string GetNameById(ulong id)
	{
		return null;
	}

	public RoomPlayerInfo GetCurRoomPlayerInfoById(ulong id)
	{
		return null;
	}

	public bool CheckIsValidPlayerNumSetting(uint num)
	{
		return false;
	}

	public bool IsPlayerNumValid()
	{
		return false;
	}

	private bool CheckBPRoomTeamValid()
	{
		return false;
	}

	public bool IsBPTeamCheckFailed()
	{
		return false;
	}

	public uint GetValidPlayerNum()
	{
		return 0u;
	}

	public bool IsPlayerMapsAllAvailable()
	{
		return false;
	}

	public bool IsObserverMapsAllAvailable()
	{
		return false;
	}

	public void SetReopenId(ulong id)
	{
	}

	public void ResetReopenId()
	{
	}

	public void SaveOpenRoomId(ulong id)
	{
	}

	public void LogRoomId(ulong id)
	{
	}

	public void LogBatchMatchId(ulong id)
	{
	}

	public void SetSelected(int index)
	{
	}

	public int GetSelected()
	{
		return 0;
	}

	public void ClearSelected()
	{
	}

	public bool HasSelected()
	{
		return false;
	}

	public string GetGroupName(int index)
	{
		return null;
	}

	public bool IsEnableVoice()
	{
		return false;
	}

	private bool IsRoomSettingsTrue(uint roomSetting, uint setting)
	{
		return false;
	}

	public uint GetRoomSettingValue(uint roomSetting, uint start, uint end)
	{
		return 0u;
	}

	public uint SetRoomSetting(uint roomSetting, uint setting, bool value)
	{
		return 0u;
	}

	public uint SetRoomSetting(uint roomSetting, uint start, uint end, uint value)
	{
		return 0u;
	}

	public proto.EInventory.ItemSubType GetRoomCardTypeByRoomType()
	{
		return proto.EInventory.ItemSubType.ItemSubType_NONE;
	}

	public bool SwitchValidCheck(int from, int to)
	{
		return false;
	}

	public void OnRoomAfkPunishNtfFromTeam(RoomAfkPunishNtf ntf)
	{
	}

	public void OnRoomAfkPunishNtf(long time)
	{
	}

	public bool IsInBatchRoom()
	{
		return false;
	}

	public bool IsInCurrentBatchRoom(ulong id)
	{
		return false;
	}

	public bool IsMyBatchRoom(ulong id)
	{
		return false;
	}

	public void ClearBatchData(ulong roomid, tcp.ERoom.DismissReason reason)
	{
	}

	public void UpdateBatchRoomInfo(tcp.RoomInfo roomInfo)
	{
	}

	public void UpdateBatchRoomState(RoomStateNtf state)
	{
	}

	public void UpdateBatchRoomReadyState(ulong roomid, List<RoomPlayerInfo> players)
	{
	}

	public int GetBatchRoomCount()
	{
		return 0;
	}

	public void UpdateBatchRoomPlayerAvailableMaps(RoomChangeAvailableMapsNtf info)
	{
	}

	public void ResetAdCSEcoRound()
	{
	}

	public void InitDefaultCSSettingFromConfig(bool initRound = true)
	{
	}

	public void InitMapSetting(bool initRound = true)
	{
	}

	public void InitCSShopSettingFromBytes()
	{
	}

	public void InitADCSMapSettingFromBytes()
	{
	}

	public void InitSpectatorSettingFromBytes()
	{
	}

	public int GetCSShopSettingValueByIndex(uint index)
	{
		return 0;
	}

	public void SetCSShopSettingValueByIndex(uint index, int val)
	{
	}

	public bool GetCSShopSettingCheckByIndex(uint index)
	{
		return false;
	}

	public void SetCSShopSettingCheckByIndex(uint index, bool check)
	{
	}

	public void SetCSShopSettingCheckByIndexWithGroupUpdate(uint index, bool check)
	{
	}

	public int GetCSRoundValueByIndex(int index)
	{
		return 0;
	}

	public void SetCSRoundValueByIndex(int index, int val)
	{
	}

	public uint GetADCSMapZoneRoundValueByIndex(int index)
	{
		return 0u;
	}

	public void SetADCSMapZoneRoundValueByIndex(int index, uint val)
	{
	}

	public int GetSelectedShopItemCnt(bool hideOnlyShowItem = false)
	{
		return 0;
	}

	public static uint GenerateWereWolvesSettingBitFromMap(int settingNum, int paramCount, Dictionary<uint, uint> paramMap)
	{
		return 0u;
	}

	public Dictionary<uint, uint> GenerateWereWolvesSettingMapFromBit()
	{
		return null;
	}

	public static uint GenerateRushingPetsSettingBitFromMap(int settingNum, int paramCount, Dictionary<uint, uint> paramMap)
	{
		return 0u;
	}

	public Dictionary<uint, uint> GenerateRushingPetsSettingMapFromBit()
	{
		return null;
	}

	private byte[] GenerateADCSSettingBytes()
	{
		return null;
	}

	private byte[] GenerateADCSMapZoneSettingBytes()
	{
		return null;
	}

	private byte[] GenerateSpectatorSettingBytes()
	{
		return null;
	}

	public void RequestRoomMatchMakingGame()
	{
	}

	public void RequestStopRoomMatchMakingGame()
	{
	}

	public bool RequestStartLobbyMatchMakingGame()
	{
		return false;
	}

	public static tcp.MatchClientInfo GetMatchClientInfo()
	{
		return null;
	}

	public static bool GetRoomMatchMakingHalfwayjoinEnabled(EMatch.RoomMatchmakingType type)
	{
		return false;
	}

	public bool RequestStopLobbyMatchMakingGame()
	{
		return false;
	}

	public proto.EInventory.ItemSubType GetUGCRoomCardType()
	{
		return proto.EInventory.ItemSubType.ItemSubType_NONE;
	}

	public CSSharedItemData GetCSSharedItemDataByCardType(proto.EInventory.ItemSubType cardType = proto.EInventory.ItemSubType.ItemSubType_NONE)
	{
		return null;
	}

	public void UpdateRoomCustomParams(byte[] res, bool changeMap = true, string workshopCode = "")
	{
	}

	public bool IsTwoCustomParamsEqual(KDPGIMNMLFE a, KDPGIMNMLFE b)
	{
		return false;
	}

	public string GetRoomCustomParamsValueString(KDPGIMNMLFE data)
	{
		return null;
	}

	public void RequestRoomParamsData(string code)
	{
	}

	public void RequestRoomParamsLoc(string url, string workshopCode)
	{
	}

	public string GetRoomParamsLoc(string key, string defaultText = "")
	{
		return null;
	}

	public void RefreshCurrentRoomParamsLoc(byte[] data)
	{
	}

	public DKPCAEMALDP CloneRoomCustomParamsSettingData(DKPCAEMALDP data)
	{
		return null;
	}

	private KDPGIMNMLFE CloneRoomCustomParamData(KDPGIMNMLFE param)
	{
		return null;
	}

	public void CachePlatformDetail(UINavigationUtil.UINavigationFrom from, string from_info)
	{
	}

	public void CachePlatformDetail(EUGCScene scene, SceneEditSlotInfo slotInfo = null)
	{
	}

	public void OnWorkshopHalfwayJoinNtf(RoomWorkshopHalfwayJoinNtf ntf)
	{
	}

	internal RoomPlatformDetail GetCurrentPlatformDetail()
	{
		return null;
	}

	public bool TryReconnectMatchAfterLogin(Action onOK, Action onCancel)
	{
		return false;
	}

	public void OnRevCountdownNtf(RoomCountDownNtf resData)
	{
	}

	private void RecordInCustomCSShopUpgradeGroupsOnInit(RoomCreateCSShopData data)
	{
	}

	private void _003CRequestUploadRoomSetting_003Eb__6_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestDownloadRoomPreset_003Eb__7_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestPlayerRoomStats_003Eb__190_0(HttpErrorCode errorCode, object obj)
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
