using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelSparkPet : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<SparkPetConfig, uint> _003C_003E9__77_0;

		public static Func<SparkDialogueConfig, uint> _003C_003E9__78_0;

		public static Func<SparkDressUp, uint> _003C_003E9__79_0;

		public static Func<SparkTemper, uint> _003C_003E9__80_0;

		public static Converter<uint, string> _003C_003E9__163_0;

		public static Action<HttpErrorCode, object> _003C_003E9__173_0;

		internal uint _003CEnsureSparkPetConfigDatasLoaded_003Eb__77_0(SparkPetConfig value)
		{
			return 0u;
		}

		internal uint _003CEnsureSparkDialogueConfigDatasLoaded_003Eb__78_0(SparkDialogueConfig value)
		{
			return 0u;
		}

		internal uint _003CEnsureSparkDressUpDatasLoaded_003Eb__79_0(SparkDressUp value)
		{
			return 0u;
		}

		internal uint _003CEnsureSparkTemperDatasLoaded_003Eb__80_0(SparkTemper value)
		{
			return 0u;
		}

		internal string _003CFormatStageAppearanceItems_003Eb__163_0(uint x)
		{
			return null;
		}

		internal void _003CRequestSyncSparkUnlockedColors_003Eb__173_0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass164_0
	{
		public UIModelSparkPet _003C_003E4__this;

		public string cmd;

		internal void _003CRequestSparkPetDesc_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass165_0
	{
		public UIModelSparkPet _003C_003E4__this;

		public string cmd;

		internal void _003CRequestSparkPetInfo_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass166_0
	{
		public UIModelSparkPet _003C_003E4__this;

		public string cmd;

		internal void _003CRequestClaimSparkPet_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass168_0
	{
		public UIModelSparkPet _003C_003E4__this;

		public string cmd;

		public uint[] levels;

		public Action<bool, CSClaimSparkLevelAwardRes> callback;

		internal void _003CRequestClaimLevelAward_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass169_0
	{
		public UIModelSparkPet _003C_003E4__this;

		public string cmd;

		public Action callback;

		internal void _003CRequestSetSparkCustomInfo_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass170_0
	{
		public UIModelSparkPet _003C_003E4__this;

		public string cmd;

		internal void _003CRequestSetSparkCollab_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass171_0
	{
		public UIModelSparkPet _003C_003E4__this;

		public string cmd;

		internal void _003CRequestDrawSparkGachaPool_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private static bool _003CIsSparkPetDragging_003Ek__BackingField;

	private bool m_DailyFirstLoginFinish;

	private bool m_HasShownRecoveryUIFX;

	private SparkPetCustomInfoCache _003CPendingCustomInfo_003Ek__BackingField;

	private ExchangeChangeData _003CClaimeLevelUpRewards_003Ek__BackingField;

	private bool _003CShouldShowLuckyDrawAfterClaimLevelAward_003Ek__BackingField;

	private bool _003CSkipAutoFeatureUnlockPopup_003Ek__BackingField;

	public const uint PropID_SparkPetReady = 2u;

	public const uint PropID_GetSparkPetDesc = 4u;

	public const uint PropID_GetSparkPetInfo = 8u;

	public const uint PropID_ClaimSparkPet = 16u;

	public const uint PropID_ClaimLevelRewards = 32u;

	public const uint PropID_SparkPetCustomInfoUpdate = 64u;

	public const uint PropID_SetSparkCollab = 128u;

	public const uint PropID_DrawSparkGachaPool = 256u;

	private const uint ALL_STEP_READY = 12u;

	public static float DAILY_DIALOGUE_EXISTTIME;

	private uint m_ReadyFlag;

	private CSVAsyncDataMap<uint, SparkPetConfig> m_SparkPetConfigDatas;

	private CSVAsyncDataMap<uint, SparkDialogueConfig> m_SparkDialogueConfigDatas;

	private CSVAsyncDataMap<uint, SparkDressUp> m_SparkDressUpDatas;

	private CSVAsyncDataMap<uint, SparkTemper> m_SparkTemperDatas;

	private readonly Dictionary<uint, SparkPetConfig> m_DicCombinePairingToSparkPetConfig;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private CSGetSparkDescRes m_SparkDesc;

	private CSGetSparkInfoRes m_SparkInfo;

	private readonly List<uint> m_ClientUnlockedColorIDs;

	private Dictionary<uint, uint> m_SparkFeatureUnlockLevel;

	private readonly Dictionary<uint, SparkLevelAwardDesc> m_DicLevelToLevelAwardDescs;

	private readonly Dictionary<uint, uint> m_DicLevelToStage;

	private SparkPetDisplaySettings m_SparkPetAvatarScriptableObject;

	private bool m_ForbidClickSparkPet;

	private bool m_HasShowLevelUp;

	private bool m_HasShownRecoveryAnimation;

	private const string PREF_KEY_STAGE_EVOLUTION_CLAIMED = "SparkPet_StageEvolution_Claimed_{0}_{1}";

	public const float STAGE_EVOLUTION_GUIDE_DELAY = 5f;

	private const int SPARK_PET_LOCAL_NOTIFICATION_HOUR = 20;

	private const int SPARK_PET_LOCAL_NOTIFICATION_MINUTE = 0;

	private const int SPARK_PET_LOCAL_NOTIFICATION_SECOND = 0;

	private const int SPARK_PET_LOCAL_NOTIFICATION_TIMES = 1;

	public static bool IsSparkPetDragging
	{
		get
		{
			return _003CIsSparkPetDragging_003Ek__BackingField;
		}
		set
		{
			_003CIsSparkPetDragging_003Ek__BackingField = value;
		}
	}

	public CSGetSparkDescRes SparkDesc => null;

	public CSGetSparkInfoRes SparkInfo => null;

	public Dictionary<uint, uint> SparkFeatureUnlockLevel => null;

	public SparkPetCustomInfoCache PendingCustomInfo
	{
		get
		{
			return _003CPendingCustomInfo_003Ek__BackingField;
		}
		private set
		{
			_003CPendingCustomInfo_003Ek__BackingField = value;
		}
	}

	public ExchangeChangeData ClaimeLevelUpRewards
	{
		get
		{
			return _003CClaimeLevelUpRewards_003Ek__BackingField;
		}
		set
		{
			_003CClaimeLevelUpRewards_003Ek__BackingField = value;
		}
	}

	public bool ShouldShowLuckyDrawAfterClaimLevelAward
	{
		get
		{
			return _003CShouldShowLuckyDrawAfterClaimLevelAward_003Ek__BackingField;
		}
		set
		{
			_003CShouldShowLuckyDrawAfterClaimLevelAward_003Ek__BackingField = value;
		}
	}

	public bool SkipAutoFeatureUnlockPopup
	{
		get
		{
			return _003CSkipAutoFeatureUnlockPopup_003Ek__BackingField;
		}
		set
		{
			_003CSkipAutoFeatureUnlockPopup_003Ek__BackingField = value;
		}
	}

	private Dictionary<uint, SparkPetConfig> DicCombinePairingToSparkPetInner => null;

	public SparkPetDisplaySettings SparkPetAvatarScriptableObject => null;

	private uint ReadyFlag
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool ForbidClickSparkPet
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override void Logout(object[] data)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public override void Init()
	{
	}

	private void EnsurePendingCustomInfoCache()
	{
	}

	private void LoadAllSparkPetConfigDatas()
	{
	}

	private void EnsureSparkPetConfigDatasLoaded()
	{
	}

	private void EnsureSparkDialogueConfigDatasLoaded()
	{
	}

	private void EnsureSparkDressUpDatasLoaded()
	{
	}

	private void EnsureSparkTemperDatasLoaded()
	{
	}

	public int GetTemperCount()
	{
		return 0;
	}

	public ResourceID GetTemperRes(ESparkPetTemper type)
	{
		return default(ResourceID);
	}

	public static string GetLuckDrawQualityBgSpriteName(uint quality)
	{
		return null;
	}

	public SparkPetConfig GetSparkPetConfigData(uint sparkPetID, uint stageID)
	{
		return null;
	}

	public SparkDressUp GetSparkDressUpData(uint dressUpID)
	{
		return null;
	}

	public List<SparkDressUp> GetAllSparkDressUpData()
	{
		return null;
	}

	public List<SparkDialogueConfig> GetAllSparkDialogueData()
	{
		return null;
	}

	private void ProcessCombineDic()
	{
	}

	private uint GetCombinedPairing(uint sparkPetID, uint Stage)
	{
		return 0u;
	}

	public bool HasShownRecoveryUIFX()
	{
		return false;
	}

	public void SetHasShownRecoveryUIFX(bool value)
	{
	}

	public uint GetCosmeticType(uint id)
	{
		return 0u;
	}

	public bool IsReady()
	{
		return false;
	}

	public uint GetEquippedCosmeticIDByType(uint type)
	{
		return 0u;
	}

	public bool IsCosmeticUnlocked(uint id)
	{
		return false;
	}

	public int GetRecoverDays(EFriend.SparkCondition state)
	{
		return 0;
	}

	public bool IsSparkPetClaimed()
	{
		return false;
	}

	public bool IsShowInLobby()
	{
		return false;
	}

	public bool IsShowBuddy()
	{
		return false;
	}

	public uint GetCurLevel()
	{
		return 0u;
	}

	public bool IsSparkInfoGet()
	{
		return false;
	}

	public uint GetLoginStreakDays()
	{
		return 0u;
	}

	public uint GetCollabLoginStreakDays()
	{
		return 0u;
	}

	public bool IsDailyFirstLogin()
	{
		return false;
	}

	public void SetDailyFirstLoginFinish()
	{
	}

	public bool IsShowExtinctionFeedback()
	{
		return false;
	}

	public bool IsRecoveredFromDeadToActive()
	{
		return false;
	}

	public bool IsRecoveredFromDormantToActive()
	{
		return false;
	}

	public bool ShouldShowRecoveryAnimation()
	{
		return false;
	}

	public void SetHasShownRecoveryAnimation(bool value)
	{
	}

	public bool IsRewardClaimed(uint levelId)
	{
		return false;
	}

	public bool IsSparkGachaDrawAwardObtainedButNotUsed(uint levelId)
	{
		return false;
	}

	public ESparkPetStage GetSparkStage(uint level)
	{
		return ESparkPetStage.None;
	}

	public uint GetStageUnlockLevel(ESparkPetStage stage)
	{
		return 0u;
	}

	public ESparkPetStage GetSelfSparkStage()
	{
		return ESparkPetStage.None;
	}

	public ESparkPetStage GetSelfAppearanceSparkStage()
	{
		return ESparkPetStage.None;
	}

	public ESparkPetStage GetCollabSparkStage()
	{
		return ESparkPetStage.None;
	}

	public ESparkPetStage GetCollabAppearanceSparkStage()
	{
		return ESparkPetStage.None;
	}

	public EFriend.SparkState GetSelfSparkState()
	{
		return EFriend.SparkState.SparkState_NONE;
	}

	public EFriend.SparkState GetSelfSparkDisplayState()
	{
		return EFriend.SparkState.SparkState_NONE;
	}

	public bool IsSelfSparkStateActiveOrDormant()
	{
		return false;
	}

	public bool IsSelfSparkStateExtinguished()
	{
		return false;
	}

	public EFriend.SparkState GetCollabSparkState()
	{
		return EFriend.SparkState.SparkState_NONE;
	}

	public List<SparkColorWheelDesc> GetSparkColorWheelDescs()
	{
		return null;
	}

	public SparkColorWheelDesc GetSparkColorWheelDesc(uint colorID)
	{
		return null;
	}

	public bool TryGetSparkColorIDByItemID(uint itemID, out uint colorID)
	{
		colorID = default(uint);
		return false;
	}

	public bool IsSparkAppearanceItem(uint itemID)
	{
		return false;
	}

	public bool EquipSparkAppearanceItemToPending(uint itemID)
	{
		return false;
	}

	public uint GetDefaultSparkColorID()
	{
		return 0u;
	}

	public bool IsSparkColorUnlocked(uint colorID)
	{
		return false;
	}

	private bool IsClientSparkColorUnlocked(uint colorID)
	{
		return false;
	}

	public bool IsSparkColorRewardUnlockedByItemID(uint itemID)
	{
		return false;
	}

	private void InitClientUnlockedSparkColors()
	{
	}

	private bool AddClientUnlockedSparkColor(uint colorID)
	{
		return false;
	}

	public static uint NormalizeSparkColorID(uint colorID)
	{
		return 0u;
	}

	public bool TryGetSparkColorResourceIndex(uint colorID, out int colorResourceIndex)
	{
		colorResourceIndex = default(int);
		return false;
	}

	public uint GetSelfSparkColorID()
	{
		return 0u;
	}

	public uint GetCollabSparkColorID()
	{
		return 0u;
	}

	public uint GetSparkColorIDBySparkInfo(SparkInfo sparkInfo)
	{
		return 0u;
	}

	public uint GetPendingSparkColorID()
	{
		return 0u;
	}

	private uint GetAvailableSparkColorID(uint colorID)
	{
		return 0u;
	}

	private SparkColorWheelDesc GetAvailableSparkColorWheelDesc(uint colorID)
	{
		return null;
	}

	public ResourceID GetStageProfileRes(ESparkPetStage stage)
	{
		return default(ResourceID);
	}

	public bool HasCollabSpark()
	{
		return false;
	}

	public bool HasSelfSpark()
	{
		return false;
	}

	public uint[] GetSelfAppearanceItemIds()
	{
		return null;
	}

	public uint[] GetCollabAppearanceItemIds()
	{
		return null;
	}

	public uint[] GetAppearanceItemIdBySparkInfo(SparkInfo sparkInfo)
	{
		return null;
	}

	public void InitializePendingCustomInfo()
	{
	}

	public uint[] GetAwardsToClaim()
	{
		return null;
	}

	public ulong GetCumulativeExpUpToLevel(uint targetLevel)
	{
		return 0uL;
	}

	public bool GetIsSelfFeatureUnlocked(EFriend.SparkFeatureUnlockType featureUnlockType)
	{
		return false;
	}

	public bool GetIsFeatureUnlocked(SparkInfo sparkInfo, EFriend.SparkFeatureUnlockType featureUnlockType)
	{
		return false;
	}

	public SparkLevelAwardDesc GetLevelAwardDescs(uint level)
	{
		return null;
	}

	public bool IsShowLevelUpVFX()
	{
		return false;
	}

	public void SetHasShowLevelUp(bool hasShowLevelUp)
	{
	}

	public bool HasPendingStageEvolution()
	{
		return false;
	}

	public void SetStageEvolutionFinished()
	{
	}

	private string GetStageEvolutionPrefKey(uint stage)
	{
		return null;
	}

	public string GetShareDescKeyByLoginDays(uint loginDays)
	{
		return null;
	}

	public string GetCollabPlayerName()
	{
		return null;
	}

	public string GetShareActiveAnimName()
	{
		return null;
	}

	private string FormatStageAppearanceItems(List<SparkStageAppearance> stageItems)
	{
		return null;
	}

	public void RequestSparkPetDesc(LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestSparkPetInfo(LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestClaimSparkPet()
	{
	}

	private bool HasClaimGachaDrawAward(uint[] levels)
	{
		return false;
	}

	public void RequestClaimLevelAward(uint[] levels, Action<bool, CSClaimSparkLevelAwardRes> callback = null)
	{
	}

	public void RequestSetSparkCustomInfo(Action callback = null)
	{
	}

	public void RequestSetSparkCollab(ulong buddyAccountID)
	{
	}

	public bool RequestDrawSparkGachaPool()
	{
		return false;
	}

	private void ProcessDrawSparkGachaPoolReward(SparkGachaPoolRewardInfo reward)
	{
	}

	private void RequestSyncSparkUnlockedColors(uint colorID)
	{
	}

	public void RescheduleLocalNotifications()
	{
	}

	private void ScheduleSparkPetLocalNotification(LocalNotificationManager.NotifyType notifyType, int firstDay)
	{
	}

	private int GetSparkPetLocalNotificationFirstDay(int firstDay)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
