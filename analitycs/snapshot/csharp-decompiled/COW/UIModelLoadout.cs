using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelLoadout : UIBaseModel, IUIModelDataChangeObserver
{
	public enum LOADOUT_PLAN_TYPE
	{
		OFFICIAL = 1,
		KOL = 2,
		PLAYER = 99
	}

	public enum CHANGE_LOADOUT_PLAN_STATUS
	{
		FAILURE,
		SUCCESS
	}

	public enum QUICK_EQUIP_TARGET_DETAIL
	{
		SLOT0,
		SLOT1,
		SLOT2,
		SLOT3,
		PET,
		LOADOUT
	}

	public enum ESkillTag
	{
		All,
		Group,
		Survive,
		Attack,
		Info
	}

	public enum EnumManualModifyFlagReason
	{
		RequestChangePlan,
		ApplyRecommend,
		RequestChangeAvatar,
		RequestChangeAvatarSkill,
		RequestChangeLoadout,
		RequestChangeLoadoutV2,
		RequestChangePet,
		RequestChangePetSkill,
		ManualChangeAvatarSkill,
		ManualChangePetSkill,
		ManualChangeAvatar,
		ManualChangeLoadoutV2,
		ManualChangeLoadout,
		ManualChangeAutoMode,
		Guide
	}

	public enum EnumChangeAvatarSkillReason
	{
		ReplaceExpiredAvatarSkill,
		PlayerManualChangeSkill,
		ChangeAvatar,
		ReplaceInvalidSharedSkill,
		ReplaceDifferentSkillId,
		ReplaceAwakenSkillId,
		ApplyRecommend,
		QuickEquip,
		OtherSlotHasRepeatSkill,
		HasActiveSkillBesidesSlot,
		InitFirstPresetPlan,
		NewbieGuide,
		CSBanPick
	}

	public enum EnumChangeAvatarReason
	{
		ReplaceEmptyAvatar,
		ReplaceExpiredAvatar,
		PlayerManualChange,
		ApplyRecommend,
		QuickEquip,
		RequestChangeAvatar,
		InitFirstPresetPlan
	}

	public enum EnumChangeLoadoutReason
	{
		ReplaceInvalidLoadout,
		PlayerManualChangeLoadout,
		ApplyRecommend,
		RequestChangeLoadout
	}

	public enum ERole
	{
		Newbie = 1,
		Veteren
	}

	public enum ENewbiePresetType : uint
	{
		Newbie = 1u,
		Veteran
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<PlayerPlanItem> _003C_003E9__149_0;

		public static Predicate<proto.PetInfo> _003C_003E9__197_0;

		public static Predicate<proto.PetInfo> _003C_003E9__197_2;

		public static Comparison<IngameBattleStyleLoadoutData> _003C_003E9__210_0;

		public static Comparison<PlayerEditRecPlanItem> _003C_003E9__248_1;

		public static Comparison<LoadoutRecommendTabDesc> _003C_003E9__255_1;

		public static Comparison<NewbiePreset> _003C_003E9__304_0;

		internal int _003CGetAllPlayerPlan_003Eb__149_0(PlayerPlanItem x, PlayerPlanItem y)
		{
			return 0;
		}

		internal bool _003COnSelectPetSuccess_003Eb__197_0(proto.PetInfo temp)
		{
			return false;
		}

		internal bool _003COnSelectPetSuccess_003Eb__197_2(proto.PetInfo temp)
		{
			return false;
		}

		internal int _003CGetLoadoutV2DataListByMode_003Eb__210_0(IngameBattleStyleLoadoutData a, IngameBattleStyleLoadoutData b)
		{
			return 0;
		}

		internal int _003CRequestPlayerEditLoadout_003Eb__248_1(PlayerEditRecPlanItem a, PlayerEditRecPlanItem b)
		{
			return 0;
		}

		internal int _003CRequestRecommendPlan_003Eb__255_1(LoadoutRecommendTabDesc a, LoadoutRecommendTabDesc b)
		{
			return 0;
		}

		internal int _003CGetNewbiePresetsByTypeAtStage2_3_003Eb__304_0(NewbiePreset a, NewbiePreset b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass197_0
	{
		public uint petId;

		internal bool _003COnSelectPetSuccess_003Eb__1(proto.PetInfo temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass243_0
	{
		public UIModelLoadout _003C_003E4__this;

		public RequestPresetParam req;

		internal void _003CSendSelectPresetRequest_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass244_0
	{
		public UIModelLoadout _003C_003E4__this;

		public CSUpdatePresetLoadoutNameReq req;

		internal void _003CRequestChangePlanName_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass246_0
	{
		public UIModelLoadout _003C_003E4__this;

		public List<RecommendPlanItem> matchedActiveSkillPlanList;

		internal void _003CRequestSearchKOLPlan_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass248_0
	{
		public UIModelLoadout _003C_003E4__this;

		public string cmd;

		internal void _003CRequestPlayerEditLoadout_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass249_0
	{
		public UIModelLoadout _003C_003E4__this;

		public string cmd;

		internal void _003CRequestGetRegionKOLPlan_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass250_0
	{
		public UIModelLoadout _003C_003E4__this;

		public string cmd;

		public Action<uint> onSuccess;

		public int publishIndex;

		public List<PlayerEditRecPlanItem> changedPlans;

		internal void _003CRequestUploadLoadoutScheme_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass251_0
	{
		public UIModelLoadout _003C_003E4__this;

		public string cmd;

		public int publishIndex;

		public Action<HttpErrorCode, object> _003C_003E9__1;

		internal void _003CRequestPublishLoadoutScheme_003Eb__0(uint schemeId)
		{
		}

		internal void _003CRequestPublishLoadoutScheme_003Eb__1(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass252_0
	{
		public UIModelLoadout _003C_003E4__this;

		public string cmd;

		public int index;

		public uint schemeId;

		internal void _003CRequestDeleteLoadoutScheme_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass254_0
	{
		public UIModelLoadout _003C_003E4__this;

		public uint schemeId;

		public ulong targetAccountID;

		internal void _003CRequestLikeLoadoutScheme_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass255_0
	{
		public UIModelLoadout _003C_003E4__this;

		public string cmd;

		internal void _003CRequestRecommendPlan_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass290_0
	{
		public int presetID;

		internal bool _003CGetNewbiePresetDataWithEmpty_003Eb__0(NewbiePresetDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass297_0
	{
		public UIModelLoadout _003C_003E4__this;

		public string cmd;

		public bool isNewbie;

		public NewbiePresetDesc newbiePresetData;

		public string prefKey;

		public uint targetIndex;

		public bool isNewbieGuideCall;

		internal void _003CRequestPresetGuideAvatar_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_SlotChange = 2u;

	public const uint PropID_LoadoutChoose = 4u;

	public const uint PropID_PlanNameUpdate = 8u;

	public const uint PropID_RefreshPlan = 16u;

	public const uint PropID_PetSkillUpdate = 32u;

	public const uint PropID_RecommendInfoUpdate = 64u;

	public const uint PropID_ChangePlan = 128u;

	public const uint PropID_PetChange = 256u;

	public const uint PropID_AvatarChange = 512u;

	public const uint PropID_LoadoutChooseV2 = 1024u;

	public const uint PropID_LoadoutBubbleShow = 2048u;

	public const uint PropID_SearchResultUpdate = 4096u;

	public const uint PropID_PlayerEditPlanUpdate = 8192u;

	public const uint PropID_TopRecommenderTabUpdate = 16384u;

	public const uint PropID_PresetGuideAvatarSuccess = 32768u;

	public const uint PropID_AccountFreshStatsInfoReady = 65536u;

	public static int MaxAvatarSkillSlot;

	public const int CSBPPlanIndex = 999;

	private int m_CSBPActiveSkillSlotIndex;

	private List<RecommendPlanItem> m_RecommendPlans;

	public List<RecommendPlanItem> CurRecommendPlans;

	private List<RecommendPlanItem> m_SearchResultList;

	private List<RecommendPlanItem> m_KOLRecommendPlans;

	private List<PlayerEditRecPlanItem> m_PlayerEditPlans;

	private List<PlayerEditRecPlanItem> m_PlayerEditPlansCache;

	public List<LoadoutRecommendTabDesc> RecommendModeTab;

	public List<RecommenderTabDesc> RecommenderTabs;

	public Dictionary<uint, string> AutoModeDict;

	public static uint DefaultAutoMode;

	public string OnlySkillSprite;

	public bool HasRequestPlayerPlan;

	public bool ShowDetailSkillDesc;

	private Dictionary<uint, PetExpCalculateData> m_PetExpCal;

	private Dictionary<int, PlayerPlanItem> m_PlayerPlans;

	private Dictionary<int, PlayerPlanItem> m_PrePlayerPlans;

	private Dictionary<int, bool> m_PlayerManualModify;

	private Dictionary<uint, List<uint>> m_ActiveSkillId2RecSkillList;

	private int m_CurrentApplyPlanIndex;

	private int m_CurrentShowPlanIndex;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelInventory m_ModelInventory;

	private UIModelPet m_ModelPet;

	private UIModelGroup m_ModelGroup;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelMatch m_ModelMatch;

	private UIModelMapOpeningInfo m_ModelMap;

	private int m_MaxBuild;

	private ulong m_LastSendTs;

	private string ShareCodeKey;

	private string ShowDetailSkillDescPrefKey;

	private bool m_IsKOLPlanRequested;

	private bool m_IsPlayerEditPlanRequested;

	private uint m_NumPlayerEditList;

	private bool m_IsShowKOLRec;

	private string m_KOLRegion;

	private Queue<RequestPresetParam> m_RequestSelectPresetQueue;

	private bool m_IsWaitingRequestRes;

	private RequestPresetParam m_LastRequestParam;

	private Dictionary<uint, IngameBattleStyleLoadoutData> m_LoadoutV2DataDict;

	private Dictionary<uint, BattleStyleLoadoutLevelData> m_LoadoutV2AbilityDataDict;

	private Dictionary<uint, LoadoutStyleData> m_LoadoutV2StyleDict;

	private InventorySwitchDesc m_LoadoutV2Switch;

	public const uint DEFAULT_LOADOUTV2ID = 105u;

	private bool m_ShowingLoadoutBubble;

	private bool m_ShouldShowLoadoutEmptyBox;

	private bool m_HasClickedContinuePlayInCurrentSession;

	public static string LOADOUT_BUBBLE_SHOWTODAY;

	public static string LOADOUT_PRESET_EMPTY_SKILL_GUIDE;

	private Dictionary<uint, uint> m_PresetAgentFastMessageClickCount;

	private bool m_IsCurrentPlayerKOL;

	private uint m_ClaimedNewbiePresetId;

	private bool m_AccountFreshStatsInfoReady;

	private static List<NewbiePreset> m_NewbiePresetDataList;

	private Dictionary<uint, string> m_AvatarId2KeywordDict;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private bool m_HasGetPlayerEditLoadout;

	public string RecPresetVersionKey;

	public bool HasRefreshRecTips;

	public const string GUIDE_AVATAR_LOADOUT = "GUIDE_AVATAR_LOADOUT";

	public const string GUIDE_PET_LOADOUT = "GUIDE_PET_LOADOUT";

	public const float GUIDE_TIME = 5f;

	public const int GUIDE_CTRL_PANEL_DEPTH = 100;

	public const int GUIDE_CTRL_PANEL_DEPTH_IN_NAVIGATION = 29;

	public const int GUIDE_CTRL_PANEL_WND_DEPTH = 200;

	public const string GUIDE_STEP1_KEY = "LoadoutV2_GuideStep1";

	public const string GUIDE_STEP2_KEY = "LoadoutV2_GuideStep2";

	public const string GUIDE_STEP3_KEY = "LoadoutV2_GuideStep3";

	public const string GUIDE_STEP4_KEY = "LoadoutV2_GuideStep4";

	private List<uint> GuideSkillIdList;

	private bool m_DisableRequestGuideAvatar;

	public static string RequestPresetGuideAvatarKey;

	public static string NewbieFillSkillsPresetIDKey;

	public const string PresetTitle = "#FF#";

	public const int ParamCount = 8;

	private Dictionary<uint, uint> ModeCorrelationDic;

	public int CSBPActiveSkillSlotIndex => 0;

	public List<RecommendPlanItem> SearchResultList => null;

	public List<RecommendPlanItem> KOLRecommendPlans => null;

	public List<PlayerEditRecPlanItem> PlayerEditRecPlans => null;

	public string KOLRegion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsShowKOLRec
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint NumPlayerEditList
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public int ApplyPlanIndex => 0;

	public int ShowPlanIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MaxBuild => 0;

	public string ExpandStateKey => null;

	public bool ShowLoadoutBubble
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowPresetAgent => false;

	public Dictionary<uint, uint> PresetAgentFastMessageClickCount => null;

	public bool IsCurrentPlayerKOL => false;

	public void SetCSBPActiveSkillSlotIndex(int slotIndex)
	{
	}

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

	private void CreatePlayerEditPlansSnapshot()
	{
	}

	public bool IsPlayerEditPlanItemEqual(PlayerEditRecPlanItem item1, PlayerEditRecPlanItem item2)
	{
		return false;
	}

	private bool IsRecommendPlanEqual(RecommendPlanItem plan1, RecommendPlanItem plan2)
	{
		return false;
	}

	private bool IsEquippedSkillsEqual(uint[] skills1, uint[] skills2)
	{
		return false;
	}

	private bool IsTagsEqual(uint[] tags1, uint[] tags2)
	{
		return false;
	}

	private List<PlayerEditRecPlanItem> GetChangedPlayerEditPlans()
	{
		return null;
	}

	public PlayerEditRecPlanItem CreatePlayerEditRecPlanItemSnapshot(PlayerEditRecPlanItem source)
	{
		return null;
	}

	private RecommendPlanItem CreateRecommendPlanFromScheme(AccountLoadoutScheme schemeItem)
	{
		return null;
	}

	private AccountLoadoutScheme CreateAccountLoadoutScheme(PlayerEditRecPlanItem plan)
	{
		return null;
	}

	public void InitPlayerPlan()
	{
	}

	public void SaveShowDetailSkillDescPref(bool value)
	{
	}

	public void ResetManualModifyFlag()
	{
	}

	public void SetManualModifyFlag(int index, EnumManualModifyFlagReason reason)
	{
	}

	public void SetUsingPlanManualModifyFlag(int index)
	{
	}

	public bool CheckHasManualModify(int index)
	{
		return false;
	}

	public void InitLoadoutAdjustTips()
	{
	}

	public void RefreshTipsWithLimitCard()
	{
	}

	public string GetLoadoutItemPlayerPrefKey(uint itemId)
	{
		return null;
	}

	public bool IsLoadoutAdjust(uint itemId)
	{
		return false;
	}

	public bool IsShowLoadoutItemRedPoint(uint itemId)
	{
		return false;
	}

	public void RecordLoadoutItemRedPoint(uint itemId)
	{
	}

	public bool IsPetBanned(uint gameMode)
	{
		return false;
	}

	public uint GetLoadoutID(int planIndex = -1)
	{
		return 0u;
	}

	public bool IsLoadoutV2Lock(uint loadoutV2)
	{
		return false;
	}

	public uint GetLoadoutV2ID(int planIndex = -1)
	{
		return 0u;
	}

	public uint GetAvatarId(int planIndex = -1)
	{
		return 0u;
	}

	public uint GetPetId(int planIndex = -1)
	{
		return 0u;
	}

	public uint GetAutoMode(int planIndex = -1)
	{
		return 0u;
	}

	public uint GetPetSkillID(int planIndex = -1)
	{
		return 0u;
	}

	public uint GetSkillID(int slot, int planIndex = -1)
	{
		return 0u;
	}

	public PlayerPlanItem GetPlan(int planIndex = -1)
	{
		return null;
	}

	public string GetPlanName(int planIndex = -1)
	{
		return null;
	}

	public List<PlayerPlanItem> GetAllPlayerPlan()
	{
		return null;
	}

	public void ChangeAvatarSkill(int planIndex, uint skillID, int slotIndex, bool isShared, EnumChangeAvatarSkillReason reason, bool needToNoti = true)
	{
	}

	public void ChangeAvatar(int planIndex, uint avatarID, EnumChangeAvatarReason reason, bool needToNoti = true)
	{
	}

	public void RefreshExpirePetInLoadout()
	{
	}

	public void RefreshCanNotUseLoadout()
	{
	}

	public void RefreshSharedSkill()
	{
	}

	public void RefreshOutExpriedAvatar()
	{
	}

	public void ChangeLoadout(int planIndex, uint loadoutID, EnumChangeLoadoutReason reason, bool needToNoti = true)
	{
	}

	public void ChangeLoadoutV2(int planIndex, uint loadoutV2Id, bool needToNoti = true)
	{
	}

	public void ChangePlanName(int planIndex, string name, bool needToNoti = true)
	{
	}

	public void ChangePetSkill(int planIndex, uint petSkillId, bool needToNoti = true)
	{
	}

	public void ChangePet(int planIndex, uint petId, bool needToNoti = true)
	{
	}

	public void ChangeAutoMode(int planIndex, uint mode, bool needToNoti = true)
	{
	}

	public bool HasActiveSkillBesidesSlot(int slot, int planIndex = -1)
	{
		return false;
	}

	public uint GetActiveSkillInOtherSlot(int slot, int planIndex = -1)
	{
		return 0u;
	}

	public bool OtherSlotHasRepeatSkill(int slot, uint skillId, int planIndex = -1)
	{
		return false;
	}

	public int GetRepeatSkillSlotIndex(int slot, uint skillId, int planIndex = -1)
	{
		return 0;
	}

	public bool IsEquipSkill(uint skillId, int planIndex = -1, bool? isSharedSkill = null)
	{
		return false;
	}

	public bool IsModifyingUnusedPlan()
	{
		return false;
	}

	public bool CanFillSkills()
	{
		return false;
	}

	public bool IsUserAvailableForFillSkills()
	{
		return false;
	}

	public bool HasEmptySkillsInCurrentShowPlan()
	{
		return false;
	}

	public bool IsCurrentShowPlanEmpty()
	{
		return false;
	}

	public bool IsPlanComplete(int planIndex)
	{
		return false;
	}

	public bool SlotSkillIsShared(int slot, int planIndex = -1)
	{
		return false;
	}

	public void ApplyRecommend(RecommendPlanItem recommendPlan, int planIndex, bool isV2Plan)
	{
	}

	public void ChangePlan(int targetPlanIndex, bool needBlock = false, bool forceApply = false, bool needTips = false)
	{
	}

	public bool CheckIsActiveSkill(uint skillId)
	{
		return false;
	}

	public bool CanUseLoadout(uint loadoutId)
	{
		return false;
	}

	public string EncodeShareCode(string resource)
	{
		return null;
	}

	public string DecodeShareCode(string resource)
	{
		return null;
	}

	public void CheckAutoMode(uint gameMode)
	{
	}

	public void HandleQuickEquip(uint itemId, int targetPlanIndex, uint targetSlot)
	{
	}

	public void ClearEmptyLoadoutRedDot()
	{
	}

	public PlayerPlanItem GetCSBPPreset()
	{
		return null;
	}

	public void RefreshCSBPPresetFromRoomPlayerInfo(RoomPlayerInfo playerInfo)
	{
	}

	public void ResetCSBPPreset()
	{
	}

	public int GetCSBPActiveSkillSlotIndex()
	{
		return 0;
	}

	public List<uint> GetCSBPPassiveSkillIDs()
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnSelectProfileSuccess(proto.AvatarProfile profile, int buildId, bool callFromAvatarList)
	{
	}

	public void OnEquipSkillSuccess(List<proto.AvatarProfile> profiles)
	{
	}

	public void OnChooseLoadoutSuccess(SelectedItems items)
	{
	}

	public void OnChooseLoadoutV2Success(uint loadoutV2)
	{
	}

	public void OnSelectPetSuccess(uint petId, bool carryState, uint planIndex)
	{
	}

	public void OnSelectPetSkillSuccess(uint petId, uint petSkillId, uint planIndex)
	{
	}

	public void InitLoadoutV2Switch(InventorySwitchDesc switchDesc)
	{
	}

	public bool IsLoadoutV2Open()
	{
		return false;
	}

	public ulong GetV2EndTime()
	{
		return 0uL;
	}

	public bool CheckLoadoutV2GuideStepFinish(string step)
	{
		return false;
	}

	public void FinishLoadoutV2GuideStep(string step)
	{
	}

	public bool IsOnlyShowLoadoutV2()
	{
		return false;
	}

	public BattleStyleLoadoutLevelData GetLoadoutV2Ability(uint id)
	{
		return null;
	}

	public bool IsLoadoutV2AbilityLock(uint id)
	{
		return false;
	}

	public IngameBattleStyleLoadoutData GetLoadoutV2Data(uint id, uint modeId = 1u)
	{
		return null;
	}

	public LoadoutStyleData GetLoadoutV2StyleData(uint id)
	{
		return null;
	}

	public IngameBattleStyleLoadoutData GetLoadoutV2DataInGame(byte id)
	{
		return null;
	}

	public List<IngameBattleStyleLoadoutData> GetLoadoutV2DataListByMode(uint gamemode)
	{
		return null;
	}

	public List<uint> GetLoadoutV2AbilityList(uint loadoutV2, uint modeId)
	{
		return null;
	}

	public bool TargetAvatarIsOnlyCharacter(int plaxIndex = -1)
	{
		return false;
	}

	public void LoadAvatarKeywordata()
	{
	}

	public string GetAvtarKeyword(uint avatarId)
	{
		return null;
	}

	public bool AvatarHasKeyword(uint avatarId, string searchContent)
	{
		return false;
	}

	private void ReplaceDefaultAvatar()
	{
	}

	private void InitFirstPresetPlan(bool needToNoti = true)
	{
	}

	private void LoadLoadoutV2Data()
	{
	}

	private void LoadPetBannedDict()
	{
	}

	private void AppendBuild(int target)
	{
	}

	private void ParseAutoMode()
	{
	}

	private void InitPrePlayerPlan()
	{
	}

	private CSSelectPresetLoadoutReq.EquipSkill BatchEquipSkillToAvatar(uint avatarId, int planIndex = -1)
	{
		return null;
	}

	private void EnqueuePresetRequest(RequestPresetParam param)
	{
	}

	private void HandleQueuePresetRequest()
	{
	}

	public void ResetLobbyAvatar()
	{
	}

	private void CheckNeedSendRequest(RequestPresetParam target)
	{
	}

	public void CheckLoadoutSideEmptyRedDot()
	{
	}

	private void CheckHasHandleReq(RequestPresetParam req)
	{
	}

	private bool IsEmptySlotsInLoadout(int planIndex = -1)
	{
		return false;
	}

	public void GetEmptyAndEquippedSlotsInCurPlan(out List<int> currentEmptySlots, out List<int> equippedSkillSlotIds, int planIndex = -1)
	{
		currentEmptySlots = null;
		equippedSkillSlotIds = null;
	}

	private bool HasSkillsCanEquip(int planIndex = -1)
	{
		return false;
	}

	private bool HasLoadoutCanEquip(int planIndex = -1)
	{
		return false;
	}

	public void RequestChangeAvatar(uint avatarID, bool callFromAvatarList = false, uint httpOp = 0u, int planIndex = -1)
	{
	}

	public void RequestChangeAvatarSkill(uint httpOp = 0u, int planIndex = -1)
	{
	}

	public void RequestChangeLoadout(uint itemId, uint httpOp = 0u, int planIndex = -1)
	{
	}

	public void RequestChangeLoadoutV2(uint loadoutV2Id, uint httpOp = 0u, int planIndex = -1)
	{
	}

	public void RequestChangePet(uint petId, bool carryState, int planIndex = -1, bool resetPetSkill = true)
	{
	}

	public void RequestChangePetSkill(uint petId, uint petSkillId, int planIndex = -1)
	{
	}

	public void RequestChangePlan(int planIndex, uint httpOp, bool needTips)
	{
	}

	public void SendSelectPresetRequest(RequestPresetParam req)
	{
	}

	public void RequestChangePlanName(int planIndex, string planName)
	{
	}

	public void RequestGetKOLLoadoutSchemeDescRes(HttpManager.EHttpChannel channel)
	{
	}

	public void RequestSearchKOLPlan(List<RecommendPlanItem> matchedActiveSkillPlanList, string searchText = "", ulong searchId = 0uL)
	{
	}

	public void RequestPlayerEditLoadout()
	{
	}

	public void RequestGetRegionKOLPlan()
	{
	}

	public void RequestUploadLoadoutScheme(int publishIndex = -1, Action<uint> onSuccess = null)
	{
	}

	public void RequestPublishLoadoutScheme(int publishIndex)
	{
	}

	public void RequestDeleteLoadoutScheme(int index)
	{
	}

	private void SetPlayerEditPlanToNoContent(int index)
	{
	}

	public void RequestLikeLoadoutScheme(ulong targetAccountID, uint schemeId)
	{
	}

	public void RequestRecommendPlan()
	{
	}

	public void RefreshCurRecommendPlans()
	{
	}

	private void AddSkillsToRecSkillList(RecommendPlanItem item, uint skillId, int index)
	{
	}

	public RecommendPlanItem GetRecommendPlanItemByPlanID(uint planID)
	{
		return null;
	}

	public void CheckInvalidPlanData()
	{
	}

	public void RequestPlayerPlan(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public CSSelectPresetLoadoutReq.UpdatePresetLoadout GetModifyPlayerPlans(int targetIndex = -1)
	{
		return null;
	}

	public bool CheckIncludeTag(AvatarSkillData data, uint currentTag)
	{
		return false;
	}

	public void SendApplyLoadoutPlanLog(uint plan_type, uint plan_id, uint avatar_status, uint loadout_status, uint pet_status, bool isCopy)
	{
	}

	public void SendPlanRenameLog(string name)
	{
	}

	public PlayerPlanItem GetPrePlayerPlanByIndex(int index)
	{
		return null;
	}

	public void SendBuildSystemSettingLog(PlayerPlanItem prePlanItem, PlayerPlanItem curPlanItem, bool isPaste = false, bool isRecommend = false, uint gamemode = 0u, uint role = 0u, ulong accountID = 0uL, ERecommenderType recommendType = ERecommenderType.None)
	{
	}

	public bool ShouldShowLoadoutEmptyBox()
	{
		return false;
	}

	public void SetClickedContinuePlayInCurrentSession()
	{
	}

	public bool ShowLoadoutDailyBubble()
	{
		return false;
	}

	public bool RecordDailyLoadBubble()
	{
		return false;
	}

	public bool HasPrePlayerPlansSet()
	{
		return false;
	}

	public bool LoadoutCanGuide()
	{
		return false;
	}

	public static BuildGuideData GetBuildGuideDataByGuideStep(int guideStep)
	{
		return null;
	}

	public static BuildGuideData GetPresetGuideDataByGuideStepV2(EGuideV2PresetNewbie guideStep)
	{
		return null;
	}

	public bool CheckPlayerOwnAllGuideSkill()
	{
		return false;
	}

	public void NewbieGuideSetPreset(NewbiePresetDesc newbiePresetData)
	{
	}

	public List<NewbiePresetDesc> GetNewbiePresetDataWithEmpty()
	{
		return null;
	}

	public bool NewbieSetPresetWithEmpty(out List<uint> filledSkills)
	{
		filledSkills = null;
		return false;
	}

	public void ApplyFillSkills(List<uint> filledSkills)
	{
	}

	public void RequestPresetGuideAvatar(bool isNewbie, NewbiePresetDesc newbiePresetData = null, bool isNewbieGuideCall = true)
	{
	}

	public void RequestAccountFreshStatsInfo()
	{
	}

	public uint GetClaimedNewbiePresetId()
	{
		return 0u;
	}

	public bool IsAccountFreshStatsInfoReady()
	{
		return false;
	}

	private void LoadNewbiePresetCsvData()
	{
	}

	public List<NewbiePreset> GetAllNewbiePresetData()
	{
		return null;
	}

	public NewbiePreset GetNewbiePresetById(uint presetId)
	{
		return null;
	}

	public List<NewbiePreset> GetNewbiePresetsByTypeAtStage2_3(uint presetType)
	{
		return null;
	}

	private bool IsCurrentAccountVeteran()
	{
		return false;
	}

	private ENewbiePresetType GetNewbiePresetType()
	{
		return (ENewbiePresetType)0u;
	}

	public List<NewbiePreset> BuildNewbiePresetDisplayList()
	{
		return null;
	}

	public bool HasUnequippedNewbiePreset()
	{
		return false;
	}

	public bool CheckNewbieRecommendLoadoutEligibility()
	{
		return false;
	}

	private ulong GetRecommendLoadoutApplyTime()
	{
		return 0uL;
	}

	public bool HasClaimableNewbiePresetReward()
	{
		return false;
	}

	private bool CheckNewbiePresetAllAvatarsOwned(NewbiePreset data, UIModelAvatarProfile modelAvatarProfile)
	{
		return false;
	}

	public bool NeedShowNewbieGuide()
	{
		return false;
	}

	public bool ShowAvatarCountDown(AvatarProfile profile)
	{
		return false;
	}

	public void OnCopyBtnClick()
	{
	}

	public void OnPasteBtnClick()
	{
	}

	private void ApplyPastePlan(RecommendPlanItem item)
	{
	}

	public bool IsCurrentRecPassiveSkill(uint activeSkill, uint passiveSkill)
	{
		return false;
	}

	public bool HasRecPassiveSkill(uint activeSkill)
	{
		return false;
	}

	public void InitPresetModeCorrelation(List<LoadoutModePresetCorrelationDesc> datas)
	{
	}

	public void RequestUploadCSBPPreset(uint avatarId, uint httpOp = 0u)
	{
	}

	private void _003CRequestGetKOLLoadoutSchemeDescRes_003Eb__245_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestPlayerPlan_003Eb__262_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestAccountFreshStatsInfo_003Eb__298_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
