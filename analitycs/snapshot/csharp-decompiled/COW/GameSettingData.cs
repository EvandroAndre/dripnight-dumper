using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using COW.HUD;
using GCommon;

namespace COW;

public static class GameSettingData
{
	public const string LastLoclizationKey = "LastLocalization";

	public const string LoclizationSettingKey = "Localization";

	public const string SensitivitySettingKey = "Sensitivity";

	public const string Sensitivity1PSettingKey = "Sensitivity1P";

	public const string AuxAimSensitivitySettingKey = "AuxAimSensitivity";

	public const string SpHudPlayerInfoIsBasicSettingKey = "SpHudPlayerInfoIsBasic";

	public const string MusicSettingKey = "Music";

	public const string SoundEffectSettingKey = "SoundEffect";

	public const string KillSoundEffectSettingKey = "KillSoundEffect";

	public const string GameVoiceSettingKey = "GameVoice";

	public const string MinimapSettingKey = "MiniMap";

	public const string MinimapScaleAssistKey = "MiniMapScaleAssist";

	public const string QualitySettingKey = "Quality";

	public const string QualitySettingRecommendKey = "QualityRecommend";

	public const string EnergySavingSettingKey = "EnergySaving";

	public const string HDQualitySettingAdjustKey = "HDQualityAdjust";

	public const string ScopeSensitivitySettingKeyPrefix = "ScopeSensitivity_";

	public const string AimAssistKey = "AimAssist";

	public const string OpenScopeOperateKey = "OpenScopeOperate";

	public const string LeftFireKey = "LeftFire";

	public const string ChangeWeaponKey = "ChangeWeapon";

	public const string ReloadKey = "Reload";

	public const string UseAuxAimKey = "UseAuxAimNew";

	public const string UseAuxAimParachuteKey = "UseAuxAimParachute";

	public const string UseAuxAimDashKey = "UseAuxAimDash";

	public const string UseAuxAimDriveKey = "UseAuxAimDrive";

	public const string SafeZoneInfoModeKey = "IngameTipsMode";

	public const string StackedKillModeKey = "StackedKillMode";

	public const string BrightnessSettingKey = "BrightnessSetting";

	public const string EnemyFireHintKey = "EnemyFireHint";

	public const string LobbyCamGyroKey = "LobbyCamGyro";

	public const string CurClanLevel = "CurClanLevel";

	public const string AutoSlidingKey = "AutoSliding";

	public const string AutoPickUpKey = "AutoPickup";

	public const string NotchScreenKey = "NotchScreen";

	public const string VehicleControlModeKey = "VehicleControlMode";

	public const string MovingJoystickModeKey = "MovingJoystickMode";

	public const string HighFPSKey = "HighFPS";

	public const string ShowShadowKey = "ShowShadow";

	public const string CollectionEffectKey = "ShowCollectionEffect";

	public const string AcceptUnknowPlayerGroupInviteKey = "AcceptUnknowPlayerGroupInvite";

	public const string AcceptReserveInviteKey = "AcceptReserveInvite";

	public const string AcceptGroupInviteKey = "AcceptGroupInviteKey";

	public const string AutoFireKey = "AutoFire";

	public const string AutoSwitchKey = "AutoSwitch";

	public const string BrScoreBoardSetting = "BrScoreBoardSetting";

	public const string BrScoreBoardOpenMode = "BrScoreBoardOpenMode";

	public const string HitHint = "HitHint";

	public const string HUDGrenadeDirection = "HUDGrenadeDirection";

	public const string HUDGrenade2Direction = "HUDGrenade2Direction_";

	public const string HUDSelection = "ConfigSelected";

	public const string NewUser = "NewUser";

	public const string NewUserByAccountID = "NewUserByAccountID";

	public const string EnableQuickChat = "EnableQuickChat";

	public const string EnableQuickChatSound = "EnableQuickChatSound";

	public const string SensiSettingPreset = "SensiSettingPreset";

	public const string DownloadCentreShowKey = "ShowDownloadCentre";

	public const string OBSettingMD5 = "OB_{0}_Account_{1}_SettingMD5";

	public const string ChatBlockListKey = "ChatBlockList";

	public const string MaxLobbyOpenKey = "MaxLobbyOpen";

	public const string SpectatorCamerMoveSpeedKey = "SpectatorCamerMoveSpeed";

	public const string SpectatorCamerRotateSpeedKey = "SpectatorCamerRotateSpeed";

	public const string ReduceResolutionKey = "ReduceResolution";

	public const string RegisteredOnThisDevice = "RegisteredOnThisDevice";

	public const string RecommendFriends = "RecommendFriends_";

	public const string ChatBubble = "ChatBubble_";

	public const string InviteNotify = "InviteNotify_";

	public const string RemindNotify = "RemindNotify_";

	public const string KEY_CUSTOMROOM_ERRORTIPS_ENABLED = "KEY_CUSTOMROOM_ERRORTIPS_ENABLED";

	public const string KEY_CUSTOMROOM_RECORD_REPLAY_ENABLED = "KEY_CUSTOMROOM_RECORD_REPLAY_ENABLED";

	public const string KEY_CUSTOMROOM_MOBILE_RECORD_REPLAY_ENABLED = "KEY_CUSTOMROOM_MOBILE_RECORD_REPLAY_ENABLED";

	public const string KEY_CUSTOMROOM_HIGHLIGHT_RECORD_REQUEST_PERMISSION = "KEY_CUSTOMROOM_HIGHLIGHT_REQUEST_PERMISSION";

	public const string KEY_CUSTOMROOM_HIGHLIGHT_PHOTO_ENABLED = "KEY_CUSTOMROOM_HIGHLIGHT_PHOTO_ENABLED";

	public const string KEY_CUSTOMROOM_RECORD_DELAY_OB_ENABLED = "KEY_CUSTOMROOM_RECORD_DELAY_OB_ENABLED";

	public const string KEY_CUSTOMROOM_DELAY_OB_SECONDS = "KEY_CUSTOMROOM_DELAY_OB_SECONDS";

	public const string KEY_CUSTOMROOM_PERSPECTIVE_TYPE = "KEY_CUSTOMROOM_PERSPECTIVE_TYPE";

	public const string KEY_CUSTOMROOM_PERSPECTIVE_COLOR_TYPE = "KEY_CUSTOMROOM_PERSPECTIVE_COLOR_TYPE";

	public const string KEY_CUSTOMROOM_FIRE_SOUND = "KEY_CUSTOMROOM_FIRE_SOUND";

	public const string KEY_CUSTOMROOM_ACHIEVEMENT_SOUND = "KEY_CUSTOMROOM_ACHIEVEMENT_SOUND";

	public const string KEY_CUSTOMROOM_PLAYERSIGHT_ENABLED = "KEY_CUSTOMROOM_PLAYERSIGHT_ENABLED_TEMP";

	public const string KEY_CUSTOMROOM_OPENINGCAM_ENABLED = "KEY_CUSTOMROOM_OPENINGCAM_ENABLED";

	public const string KEY_TEAM_BILLBOARD_ENABLED = "KEY_TEAM_BILLBOARD_ENABLED";

	public const string KEY_SLIDE_CHANGE_COLOR_ENABLED = "KEY_SLIDE_CHANGE_COLOR_ENABLED";

	public const string KEY_PC_IN_GAME_FLAG_ENABLED = "KEY_PC_FLAG_ENABLED";

	public const string KEY_CUSTOMROOM_SPMVP_ENABLED = "CSMVP";

	public const string KEY_CUSTOM_GRENADE_SLOT = "GrenadeSlot";

	public const string KEY_DAMAGE_LABEL_TOTAL = "KEY_DAMAGE_LABEL_TOTAL";

	public const string KEY_MAXSETTING_VIDEODECODER = "KEY_MAXSETTING_VIDEODECODER";

	public const string KEY_OPTIONAL_SETTING_AUTODOWNLOAD = "KEY_OPTIONAL_SETTING_AUTODOWNLOAD";

	public const string KEY_OPTIONAL_SETTING_AUTOCLEARONTIME = "KEY_OPTIONAL_SETTING_AUTOCLEARONTIME";

	public const string UseHDAnimation = "UseHDAnimation";

	public const string UseHDAnimationFFOPorting = "UseHDAnimationFFOPorting";

	public const string HDWeaponEffect = "HDWeaponEffect";

	public const string HDTexture = "HDTexture";

	public const string HDVehicleVFX = "HDVehicleVFX";

	public const string AudioEngineTypeKey = "AudioEngineType";

	public const string AudioEngineTypeCacheKey = "AudioEngineTypeCacheKey";

	public const string KEY_MAXSETTING_LOGINViDEO_ENABLED = "KEY_MAXSETTING_LOGINViDEO_ENABLED";

	public const string HDLobbyVehicleAutoRotate = "HDLobbyVehicleAutoRotate";

	public const string HDLobbyIceWallAutoRotate = "HDLobbyIceWallAutoRotate";

	public const string HDLobbySkyboardAutoRotate = "HDLobbySkyboardAutoRotate";

	public const string HDShowMyLobby = "HDShowMyLobby";

	public const string HDShowCaptainLobby = "HDShowCaptainLobby";

	public const string AutoDownloadSwitch = "AutoDownloadSwitch";

	public const string MaxGraphicABTestKey = "MaxGraphicABTestKey";

	public const string UGCCameraMoveSpeedKey = "KEY_UGC_CAMERA_MOVE_SPEED";

	public const string UGC_AcceptFriendGroupInviteKey = "KEY_UGC_ACCEPT_FRIEND_GROUP_INVITE";

	public const string UGC_SceneEditFirstEnterNewMap = "KEY_UGC_SceneEditFirstEnterNewMap";

	public const string UGC_SceneEditPointDrag = "KEY_UGC_SCENEEDIT_POINT_DRAG";

	public const string UGC_SceneEditShowGridLine = "KEY_UGC_SCENEEDIT_SHOW_GRIDLINE";

	public const string UGC_SceneEditGridSnap = "KEY_UGC_SCENEEDIT_GRID_SNAP";

	public const string UGC_SceneEditBtnDesc = "KEY_UGC_SCENEEDIT_BTN_DESC";

	public const string UGC_SceneEditGridGran = "KEY_UGC_SCENEEDIT_GRID_GRAN";

	public const string UGC_SceneEditRotateInterval = "KEY_UGC_SCENEEDIT_ROTATE_INTERVAL";

	public const string UGC_SceneEditAutoSaveBoxId = "UGC_SCENEEDITAUTOSAVEBOXID";

	public const string KEY_Auto_Equip_Default_Music = "KEY_AUTO_EQUIP_DEFAULT_MUSIC";

	public const string CupMatchAcceptNotificationKey = "CupMatchAcceptNotificationKey";

	public const string RequestJoinCupTeamNotificationKey = "RequestJoinCupTeamNotificationKey";

	public const string GameResultFriendRecommendNotificationKey = "GameResultFriendRecommendNotificationKey";

	public const string GameResultInviteRecommendNotificationKey = "GameResultInviteRecommendNotificationKey";

	public const string IPMusicPlayKey = "IPMusicPlayKey";

	public const string SmartIceWallKey = "SmartIceWallKey";

	public const string SmartIceWallShowKey = "SmartIceWallShowKey";

	public const string SmartIceWallChangeBackWeaponKey = "SmartIceWallChangeBackWeaponKey";

	public const string InitedSmartIceWallSetting = "InitedSmartIceWallKey";

	public const string SmartIceWallSwitchAccountAuto = "SmartIceWallSwitchAccountAuto";

	public const string GrenadeSlotBeforeSmarIceWallEnable = "GrenadeSlotBeforeSmarIceWallEnableKey";

	public const string SpecialCharacterVoiceKey = "SpecialCharacterVoiceKey";

	public const string WeaponPowerLeaderBoardHidePlayerInfo = "WeaponPowerLeaderBoardHidePlayerInfo";

	public const string EPDiscountKey = "EPDiscountKey";

	public const string IngameEmojiSettingKey = "IngameEmoji";

	public const string GameVoiceVolumeBalance = "GameVoiceVolumeBalance";

	public const string TrainingSkillCDFactorKey = "TrainingSkillCDFactorKey";

	public const string CrossHairModeKey = "CrossHairMode";

	public const string CrossHairReloadKey = "CrossHairReload";

	public const string AutoSearchOpenKey = "AutoSearchOpenKey";

	public const string InventoryItemCombineKey = "InventoryItemCombineKey";

	public const string InventoryUselessGuideKey = "InventoryUselessGuideKey";

	public const string InventoryCombineGuideKey = "InventoryCombineGuideKey";

	public const string InventoryEntryGuideKey = "InventoryEntryGuideKey";

	public const string AutoQuickMessageKey = "AutoQuickMessageKey";

	public const string AutoQuickMessageMatchID = "AutoQuickMessageMatchID";

	public const string ForbidQuickChatMatchID = "ForbidQuickChatMatchID";

	public const string ForbidQuickChatTeamIndex = "ForbidQuickChatTeamIndex";

	public const string HideTeammateNameKey = "HideTeammateNameKey";

	public const string HideTeammateNameNewLabelKey = "HideTeammateNameNewLabelKey";

	public const string EuqippedWeaponHistoryItemID = "EuqippedWeaponHistoryItemID";

	public const string EuqippedWeaponHistoryByThisMatchID = "EuqippedWeaponHistoryByThisMatchID";

	public const string NetworkOptimizeMultiSessionKey = "NetworkOptimizeMultiSession";

	private const string NetworkShowDamageTypeKey = "NetworkShowDamageType";

	public const string HudGrenadeChangeOb38Key = "HudGrenadeChangeOb38";

	private const string IngameAutoHidePetKey = "IngameAutoHidePet";

	public const string ItemFinderModeKey = "ItemFinderModeKey";

	private const string GameVoiceBackgroundKey = "GameVoiceBackground";

	private const string MagicVoiceKey_Id = "MagicVoiceKey_Id";

	private const string MagicVoiceKey_Open = "MagicVoiceKey_Open";

	private const string GameVoiceAutoBalanceKey = "GameVoiceAutoBalanceKey";

	private const string PressedVoiceKey = "PressedVoiceKey";

	private const string PressedVoiceKey_IsAll = "PressedVoiceKey_IsAll";

	private const string MuteNonPreMatchTeammateKey = "MuteNonPreMatchTeammate";

	public const string EmoteOnly1PAudioKey = "EmoteOnly1PAudio";

	private const string NearbyPeopleDiscoverableKey = "NearbyPeopleDiscoverable";

	private const string NearbyPeopleLocationPrecisionKey = "NearbyPeopleLocationPrecision";

	private const string FollowEmoteBeFollowedSetting = "FollowEmoteBeFollowedSetting";

	private const string CSShowTeammateWeaponInfo = "CSShowTeammateWeaponInfo";

	private const string ApplicationBlitType = "APPLICATION_BLIT_TYPE";

	private const string CurClanWeek = "CurClanWeek_";

	private const string BarrageForFriendShip = "BarrageForFriendShip";

	public static int DefaultHudSet;

	public const string DualChannelSuggestTime = "DualChannelSuggestTime";

	public const string UGCSubscribeRecommend = "UGCSubscribeRecommend";

	public const string UGCMapAutoTranslate = "UGCMapAutoTranslate";

	public const string ShowPlayerOutlineKey = "ShowPlayerOutline";

	public const string ShowTeamOutlineKey = "ShowTeamOutline";

	public const string PlayerStatsShowSPKey = "PlayerStatsShowSP";

	public const string ShowHint3DKey = "ShowHint3D";

	public const string HUDButtonHint = "HUDButtonHit";

	private const string ShowCdTimeTxtPrefsKey = "ShowCdTimeTxt";

	public const string IngameBackSickleScalingPrefsKey = "IngameBackSickleScaling";

	public const string WhitelistMask = "WhitelistMask";

	public const string WhitelistInfo = "WhitelistInfo";

	public const string WhitelistSPMask = "WhitelistSPMask";

	public const string WhitelistSPInfo = "WhitelistSPInfo";

	public const string TeamUpRecommendKey = "TeamUpRecommendKey";

	public const string SmoothHighFrameKey = "SmoothHighFrame";

	public const string BotAgentSwitchKey = "BotAgentSwitch";

	public const string BotAgentVoiceVolumeKey = "BotAgentVoiceVolume";

	public const string BotAgentCatFeedBackKey = "BotAgentCatFeedback";

	public const string BotAgentCatLootKey = "BotAgentCatLoot";

	public const string BotAgentCatOperationKey = "BotAgentCatOperation";

	public const string BotAgentCatGunHelperKey = "BotAgentCatGunHelper";

	public const string BotAgentCatSurviveTipKey = "BotAgentCatSurviveTip";

	public const string BotAgentCatCooperationKey = "BotAgentCatCooperation";

	public const string BotAgentCSSwitchKey = "BotAgentCSSwitch";

	public const string BotAgentCSVoiceVolumeKey = "BotAgentCSVoiceVolume";

	public const string BotAgentCSRuleKey = "BotAgentCSRule";

	public const string BotAgentCSShopKey = "BotAgentCSShop";

	public const string BotAgentCSBattleKey = "BotAgentCSBattle";

	public const string BotAgentCSMapKey = "BotAgentCSMap";

	public const string AIChatInGameSwitchKey = "AIChatInGameSwitch";

	public const string AIChatInUGCSwitchKey = "AIChatInUGCSwitch";

	public const string LastChangeLanguageTimeKey = "LastChangeLanguageTime";

	public const string LOCAL_SETTING_PENDING_SYNC = "LOCAL_SETTING_PENDING_SYNC_{0}";

	public const float MAX_SENSITIVITY = 1f;

	public const float MAX_MUSICVOLUME = 1f;

	public const float MAX_SOUNDEFFECTVOLUME = 1f;

	public const float MAX_KILLSOUNDEFFECTVOLUME = 1f;

	public const float MAX_GAMEVOICEVVOLUME = 1f;

	public const float DEFAULT_1xSCOPE_SENSE = 0.8f;

	public const float DEFAULT_2xSCOPE_SENSE = 0.7f;

	public const float DEFAULT_4xSCOPE_SENSE = 0.6f;

	public const float DEFAULT_8xSCOPE_SENSE = 0.5f;

	public const int HUDGRENADETOP = 0;

	public const int HUDGRENADEBOTTOM = 1;

	public const int HUDGRENADELEFT = 2;

	public const int HUDGRENADERIGHT = 3;

	private static bool? m_AutoFire;

	private static bool? m_InviteNotify;

	private static ulong m_InviteNotifyTimeStamp;

	private static MNMBLBKENMK m_cacheQuality;

	private static MNMBLBKENMK m_SocialLobbyQualitySnapshot;

	private static float m_SensitivitySetting;

	private static float m_Sensitivity1PSetting;

	private static float m_AuxAimSensitivity;

	private static float m_ScopeSensitivity1x;

	private static float m_ScopeSensitivity2x;

	private static float m_ScopeSensitivity4x;

	private static float m_ScopeSensitivity8x;

	private static int m_CurrentMaxLobbyType;

	public const int HD_COMMONLOBBY = 0;

	public const int HD_STANDLOBBY = 10;

	private static bool m_HasReadShowMaxLobbyState;

	private static bool? m_IsUsingSpHudCsplayerInfo;

	private static bool? m_SmartIceWallEnable;

	private static bool? m_SmartIceWallChangeBackWeapon;

	private static int? m_DamageLabelType;

	private static int m_EnemyFireHintVal;

	private static List<char[]> m_memoryList;

	private static bool m_SmoothHighFrame;

	private static EAudioEngineType m_cacheHDAudio;

	private static EAudioEngineType m_HDAudio;

	private static bool m_EnableReplaykitMicrophone;

	private static bool m_HDLoginVideo;

	private static EHDTexture m_HDTexture;

	private static EHDVehicleVFX m_HDVehicleVFX;

	private static EHDWeaponEffect m_HDWeaponEffect;

	private static EHDShowMyLobby m_HDShowMyLobby;

	private static EHDShowCaptainLobby m_HDShowCaptainLobby;

	private static bool m_HDAnimation;

	private static bool s_IsDancePoolMusicMuted;

	private static int s_MinimapSetting;

	private static string SensiSettingFormatStr;

	private static EOpenScopeOperate? OpenScopeOperateCachedValue;

	private static bool? PlayerStatsShowSPCachedValue;

	public static int m_VehicleControlMode;

	public static int m_MovingJoystickMode;

	private static bool? UseAuxAimCachedValue;

	private static bool _003CAutoPickSettingChanged_003Ek__BackingField;

	private static int? HudSelectionCachedValue;

	public static string AutoQuickChatV2SettingKey;

	private static bool? m_AutoQuickChatV2Setting;

	private static bool? EnableQuickChatSoundCachedValue;

	private static bool? VibrateSettingInLobby;

	private static StringBuilder m_StringBuilder;

	private static string m_LocalPlayerUserID;

	private static string m_LobbySettingTipsKey;

	private static string m_FilterSettingTipsKey;

	private static bool? cachedFFOHDAnimationDeviceSupported;

	private static int m_CrossHairMode;

	private static int m_AutoSearchOpenState;

	private static int m_InventoryItemCombineState;

	private static int m_InventoryUseless;

	private static int m_InventoryCombine;

	private static int m_InventoryEntry;

	private static int m_AutoQuickMessage;

	private static bool? ShowCdTimeTxtCachedValue;

	private static Dictionary<int, string> SettingKeyDict;

	public static string FriendInvitationPush => null;

	public static bool UGCSmoothHighFrame
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private static bool HDAnimation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool HasBrScoreBoardSetting => false;

	public static bool AutoPickSettingChanged
	{
		get
		{
			return _003CAutoPickSettingChanged_003Ek__BackingField;
		}
		set
		{
			_003CAutoPickSettingChanged_003Ek__BackingField = value;
		}
	}

	public static string LocalPlayerUserID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string LobbySettingTipsKey => null;

	public static string FilterSettingTipsKey => null;

	private static string PlayerEverLogIn => null;

	public static int CurrentMaxLobbyType => 0;

	public static int ShowMaxLobbyConfig
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int CurrentShowMaxLobbyState => 0;

	public static EAudioEngineType CurrentAudioEngine
	{
		get
		{
			return EAudioEngineType.eUnity;
		}
		set
		{
		}
	}

	public static bool HasCrossHairMode => false;

	public static bool HasCrossHairReload => false;

	public static string GetCompatibleGraphicsDeviceName()
	{
		return null;
	}

	public static string GetCompatibleGraphicsDeviceName(string graphicsDeviceName)
	{
		return null;
	}

	private static string ExtractAngleGpuName(string graphicsDeviceName)
	{
		return null;
	}

	private static string TrimPowerVRCoreCount(string gpuName)
	{
		return null;
	}

	public static void ResetDefaultValue()
	{
	}

	public static void SetLoclizationLanguage(LocLang locLang, bool checkOfflineLangRes = false)
	{
	}

	private static void CheckOfflineLangRes(LocLang locLang)
	{
	}

	public static LocLang GetLoclizationLanguage()
	{
		return LocLang.None;
	}

	public static LocLang GetFontLanguage()
	{
		return LocLang.None;
	}

	public static bool ShouldUseNASpanishTranslation()
	{
		return false;
	}

	public static void SetSensitivity(float sen)
	{
	}

	public static int GetSensitivityPreset()
	{
		return 0;
	}

	public static void SetSensitivityPreset(int presetType)
	{
	}

	public static float GetSensitivity()
	{
		return 0f;
	}

	public static void SetSensitivity1P(float sen)
	{
	}

	public static float GetSensitivity1P()
	{
		return 0f;
	}

	public static bool IsUseNewDeathCameraMode(int modeID)
	{
		return false;
	}

	public static void SetAuxAimSensitivity(float sen)
	{
	}

	public static bool IsUsingSpHudCsplayerInfo()
	{
		return false;
	}

	public static void SetUsingSpHudCsplayerInfo(bool use)
	{
	}

	public static float GetAuxAimSensitivity()
	{
		return 0f;
	}

	public static void SetMusicVolume(float volume)
	{
	}

	public static void SetDancePoolMusicMuted(bool muted)
	{
	}

	public static bool GetDancePoolMusicMuted()
	{
		return false;
	}

	public static float GetMusicVolumeForDancePool()
	{
		return 0f;
	}

	public static float GetMusicVolume()
	{
		return 0f;
	}

	public static void UpdateOBSettingMD5(string currentMD5)
	{
	}

	public static string GetOBSettingMD5()
	{
		return null;
	}

	public static bool IsEqualToLocalSettingMD5(string MD5)
	{
		return false;
	}

	public static void SetAutoUploadSwitch(int enable)
	{
	}

	public static int GetAutoUploadSwitch()
	{
		return 0;
	}

	public static bool IsAutoUploadSwitchOpen()
	{
		return false;
	}

	public static void SetIngameEmojiSwitch(int enable)
	{
	}

	public static int GetIngameEmojiSwitch()
	{
		return 0;
	}

	public static void SetSoundEffect(float volume)
	{
	}

	public static void SetKillSoundEffect(float volume)
	{
	}

	public static void SetPCFireSound(float volume)
	{
	}

	public static float GetPCFireSound()
	{
		return 0f;
	}

	public static void SetPCAchievementSound(float volume)
	{
	}

	public static float GetPCAchievementSound()
	{
		return 0f;
	}

	public static float GetGameVoiceVolumeBalance()
	{
		return 0f;
	}

	public static float GetRawGameVoiceVolumeBalance()
	{
		return 0f;
	}

	public static void SetLocalSettingPendingSyncState(int value)
	{
	}

	public static bool IsLocalSettingPendingSync()
	{
		return false;
	}

	public static void SetGameVoiceVolumeBalance(float val)
	{
	}

	public static bool GetAutoFire()
	{
		return false;
	}

	public static void SetAutoFire(bool autoFire)
	{
	}

	public static bool GetAutoSwitchWeapon()
	{
		return false;
	}

	public static void SetAutoSwitchWeapon(bool flag)
	{
	}

	public static bool GetBrScoreBoardSetting()
	{
		return false;
	}

	public static void SetBrScoreBoardSetting(bool flag)
	{
	}

	public static bool GetBrScoreBoardOpenMode()
	{
		return false;
	}

	public static void SetBrScoreBoardOpenMode(bool flag)
	{
	}

	public static bool IsAutoFireMode(bool ck = false)
	{
		return false;
	}

	public static float GetSoundEffect()
	{
		return 0f;
	}

	public static float GetKillSoundEffect()
	{
		return 0f;
	}

	public static void SetGameVoiceVolume(float volume)
	{
	}

	public static float GetGameVoiceVolume()
	{
		return 0f;
	}

	public static void SetEnergySavingEnabled(int value)
	{
	}

	public static bool GetEnergySavingEnabled()
	{
		return false;
	}

	public static void SetMinimapMode(UIHudMinimapController.EMinimapMode mode)
	{
	}

	public static UIHudMinimapController.EMinimapMode GetMinimapMode()
	{
		return UIHudMinimapController.EMinimapMode.NorthUp;
	}

	public static bool GetMiniMapScaleAssistEnabled()
	{
		return false;
	}

	public static void BeginSocialLobbyQualitySnapshot()
	{
	}

	public static void EndSocialLobbyQualitySnapshot()
	{
	}

	public static void SetQuality(MNMBLBKENMK q, bool resetOthers = true, bool applyRuntime = true)
	{
	}

	public static void SetForceMiddleQualityFor32Bit()
	{
	}

	public static MNMBLBKENMK GetRecommendedQuality(bool InAfterSystemInited = true)
	{
		return MNMBLBKENMK.High;
	}

	private static MNMBLBKENMK GetCachedQualityWithSnapshot()
	{
		return MNMBLBKENMK.High;
	}

	public static MNMBLBKENMK GetCachedQuality()
	{
		return MNMBLBKENMK.High;
	}

	public static MNMBLBKENMK GetQuality(bool InAfterSystemInited = true, bool useSocialLobbySnapshot = true)
	{
		return MNMBLBKENMK.High;
	}

	public static bool CheckEnablePreZByGraphicDevice()
	{
		return false;
	}

	public static int GetQualityLevel()
	{
		return 0;
	}

	public static ALBFCNLDNBL GetGraphicQuality()
	{
		return (ALBFCNLDNBL)0;
	}

	public static bool IsMemoryAbove(int memory)
	{
		return false;
	}

	public static bool IsMemoryHighest()
	{
		return false;
	}

	public static OLOJJDJEKKO GetMemoryLevel()
	{
		return OLOJJDJEKKO.Low;
	}

	public static OLOJJDJEKKO GetMemoryLevel_V2()
	{
		return OLOJJDJEKKO.Low;
	}

	public static bool NeedOptimizeMemory()
	{
		return false;
	}

	public static int UMAStringToHash(string uma)
	{
		return 0;
	}

	public static bool IsHighFramerate()
	{
		return false;
	}

	private static int GetEnemyFireHintDefaultValue()
	{
		return 0;
	}

	public static bool IsEnemyFireHintEnalbed()
	{
		return false;
	}

	public static void SetEnemyFireHintEnalbed(int v)
	{
	}

	public static void ResetEnemyFireHintEnalbed()
	{
	}

	public static bool IsLobbyCamGyroEnabled()
	{
		return false;
	}

	public static void SetLobbyCamGyroEnabled(int v)
	{
	}

	public static bool ShowHighFrameOption()
	{
		return false;
	}

	public static int GetHighFramerateDefault()
	{
		return 0;
	}

	public static bool IsLowMemoryIOS()
	{
		return false;
	}

	public static bool OptMemFor3gIOSOr32bitAndroid(bool checkMode = true)
	{
		return false;
	}

	internal static bool ShouldPrecacheSkillEffect(Player player)
	{
		return false;
	}

	public static bool ShouldReleaseUmaRefsInBattle(MNMBLBKENMK quality)
	{
		return false;
	}

	public static bool Is3gIOSOr32bitAndroid()
	{
		return false;
	}

	private static bool CheckShadowSupport()
	{
		return false;
	}

	public static bool CheckShowHighQuailtyCollectionEffect()
	{
		return false;
	}

	public static bool ShowCollectionOption()
	{
		return false;
	}

	public static bool ShowShadowOption()
	{
		return false;
	}

	public static bool IsHDGraphics()
	{
		return false;
	}

	public static ALBFCNLDNBL GetMapDesertGraphicQuality()
	{
		return (ALBFCNLDNBL)0;
	}

	public static void SetInGameFilter(EInGameFilterSetting b)
	{
	}

	public static EInGameFilterSetting GetInGameFilter()
	{
		return EInGameFilterSetting.Classic;
	}

	public static List<float> GetSensiSettingsByPreset(int presetType)
	{
		return null;
	}

	public static void UpdateSensiSettingByDownload(SettingDetail settingDetail)
	{
	}

	public static void Set1xScopeSensitivity(float sen)
	{
	}

	public static float Get1xScopeSensitivity()
	{
		return 0f;
	}

	public static void Set2xScopeSensitivity(float sen)
	{
	}

	public static float Get2xScopeSensitivity()
	{
		return 0f;
	}

	public static void Set4xScopeSensitivity(float sen)
	{
	}

	public static float Get4xScopeSensitivity()
	{
		return 0f;
	}

	public static void Set8xScopeSensitivity(float sen)
	{
	}

	public static float Get8xScopeSensitivity()
	{
		return 0f;
	}

	public static float GetScopeSensitivity(int x)
	{
		return 0f;
	}

	public static EAimAssist GetAimAssistSetting()
	{
		return EAimAssist.AllOn;
	}

	public static EOpenScopeOperate GetOpenScopeOperate()
	{
		return EOpenScopeOperate.Tradition;
	}

	public static void SetOpenScopeOperate(EOpenScopeOperate o)
	{
	}

	public static void ResetOpenScopeOperate()
	{
	}

	public static bool EnableShowPlayerOutline()
	{
		return false;
	}

	public static bool EnableShowTeamOutline()
	{
		return false;
	}

	public static void SetBotAgentEnabled(bool enable)
	{
	}

	public static bool IsBotAgentEnabled()
	{
		return false;
	}

	public static void SetBotAgentCSEnabled(bool enable)
	{
	}

	public static bool IsBotAgentCSEnabled()
	{
		return false;
	}

	public static void SetAIChatInGameSwitchEnabled(bool enable)
	{
	}

	public static bool IsAIChatInGameSwitchEnabled()
	{
		return false;
	}

	public static void SetAIChatInUGCSwitchEnabled(bool enable)
	{
	}

	public static bool IsAIChatInUGCSwitchEnabled()
	{
		return false;
	}

	public static void SetCustomIntParamEnabled(string key, bool enable)
	{
	}

	public static bool IsCustomIntParamEnabled(string key, int defaultValue = 1)
	{
		return false;
	}

	public static void SetCustomFloatParam(string key, float value)
	{
	}

	public static float GetCustomFloatParam(string key, float defaultValue = 1f)
	{
		return 0f;
	}

	public static float GetBotAgentVolume(bool isCSMode)
	{
		return 0f;
	}

	public static bool GetPlayerStatsShowSP()
	{
		return false;
	}

	public static void SetPlayerStatsShowSP(bool value)
	{
	}

	public static void ResetPlayerStatsShowSP()
	{
	}

	public static bool GetShowHint3D()
	{
		return false;
	}

	public static ENotchScreen GetNotchScreen()
	{
		return ENotchScreen.On;
	}

	public static void SetNotchScreen(ENotchScreen o)
	{
	}

	public static EControlMode GetVehicleControlMode()
	{
		return EControlMode.Default;
	}

	public static void ResetVehicleControlMode()
	{
	}

	public static void SetVehicleControlMode(int c)
	{
	}

	public static EMovingJoystickMode GetMovingJoystickMode()
	{
		return EMovingJoystickMode.Follow;
	}

	public static void ResetMovingJoystickMode()
	{
	}

	public static void SetMovingJoystickMode(int mode)
	{
	}

	public static ELeftFireSetting GetLeftFireSetting()
	{
		return ELeftFireSetting.Often;
	}

	public static EChangeWeaponSetting GetChangeWeaponSetting()
	{
		return EChangeWeaponSetting.On;
	}

	public static EReloadSetting GetReloadSetting()
	{
		return EReloadSetting.On;
	}

	public static bool GetUseAuxAimSetting()
	{
		return false;
	}

	public static void SetUseAuxAimSetting(int value)
	{
	}

	public static void DeleteUseAuxAimSetting()
	{
	}

	public static bool GetUseAuxAimParachuteSetting()
	{
		return false;
	}

	public static bool GetUseAuxAimDashSetting()
	{
		return false;
	}

	public static bool GetUseAuxAimDriveSetting()
	{
		return false;
	}

	public static ESafeZoneModeSetting GetSafeZoneInfoMode()
	{
		return ESafeZoneModeSetting.Center;
	}

	public static EStackedKillModeSetting GetStackedKillMode()
	{
		return EStackedKillModeSetting.Center;
	}

	public static void SetClanWeekId(uint week)
	{
	}

	public static uint GetLocalClanWeekId()
	{
		return 0u;
	}

	public static EAutoSlidingSetting GetAutoSlidingSetting()
	{
		return EAutoSlidingSetting.On;
	}

	public static EAutoPickup GetAutoPickupSetting(string itemType = "AutoPickup")
	{
		return EAutoPickup.On;
	}

	public static void SetAutoPickupSystemStatus(EAutoPickup autoPickup)
	{
	}

	public static void SetAutoPickupItemStatus(string itemKey, int autoPickupValue)
	{
	}

	public static int GetHudSelection()
	{
		return 0;
	}

	public static bool IsHudSelectionFour()
	{
		return false;
	}

	public static void SetHudSeletion(int selection)
	{
	}

	public static int GetHudGrenadeDirection()
	{
		return 0;
	}

	public static int GetHudGrenade2Direction()
	{
		return 0;
	}

	public static int GetHudGrenadeDirection(int selection)
	{
		return 0;
	}

	public static int GetHudGrenade2Direction(int selection)
	{
		return 0;
	}

	public static int GetHudGrenadeDirectionDefault(int presetIndex)
	{
		return 0;
	}

	public static int GetHudGrenade2DirectionDefault(int preset)
	{
		return 0;
	}

	public static void SetHudGrenadeDirection(int direction)
	{
	}

	public static void SetHudGrenade2Direction(int direction)
	{
	}

	public static bool HasHighFPSSetting()
	{
		return false;
	}

	public static bool IsSettingOverloadFPS(EHighFPS targetFPS)
	{
		return false;
	}

	public static bool IsHighFPS120Open()
	{
		return false;
	}

	public static bool IsHighFPS144Open()
	{
		return false;
	}

	public static EHighFPS GetDefaultHighFPSSetting()
	{
		return EHighFPS.HighFPS;
	}

	public static EHighFPS GetHighFPSSetting()
	{
		return EHighFPS.HighFPS;
	}

	public static EHighFPS GetLocolHighFPSSetting()
	{
		return EHighFPS.HighFPS;
	}

	public static int GetFPSSettingLogValue()
	{
		return 0;
	}

	public static bool CachedSmoothHighFrame()
	{
		return false;
	}

	public static bool SmoothHighFrame3P()
	{
		return false;
	}

	public static void RefreshCacheSmoothHighFrame()
	{
	}

	public static void SetSmoothHighFrameSetting(int value)
	{
	}

	public static int GetFPSSettingRankValue(EHighFPS FPSSetting)
	{
		return 0;
	}

	public static bool GetSmoothHighFrameSetting()
	{
		return false;
	}

	public static void SetCollectionEffectSetting(int CollectionEffectSwtich, bool needResetPrefs)
	{
	}

	public static void SetHighFPSSetting(EHighFPS value)
	{
	}

	public static bool IsCompliantFPSSetting(EHighFPS value)
	{
		return false;
	}

	public static int GetFPSSettingValue(EHighFPS value)
	{
		return 0;
	}

	public static int GetResolutionLevel()
	{
		return 0;
	}

	public static ECollectionEffect GetCollectionEffectSetting()
	{
		return ECollectionEffect.On;
	}

	public static EShowShadow GetShadowSetting()
	{
		return EShowShadow.On;
	}

	public static void SetAcceptUnknowPlayerGroupInvite(bool value)
	{
	}

	public static void SetIPMusicPlayKey(bool value)
	{
	}

	public static bool GetIPMusicPlayKey()
	{
		return false;
	}

	public static void SetCupMatchAcceptNotificationKey(bool value)
	{
	}

	public static bool GetCupMatchAcceptInvitation()
	{
		return false;
	}

	public static void SetRequestJoinCupTeamNotificationKey(bool value)
	{
	}

	public static bool GetRequestJoinCupTeamNotification()
	{
		return false;
	}

	public static void SetGameResultFriendRecommendNotificationKey(bool value)
	{
	}

	public static bool GetGameResultFriendRecommendNotification()
	{
		return false;
	}

	public static void SetGameResultInviteRecommendNotificationKey(bool value)
	{
	}

	public static bool GetGameResultInviteRecommendNotification()
	{
		return false;
	}

	public static void SetTeamUpRecommendSettingKey(bool value)
	{
	}

	public static bool GetTeamUpRecommendSettingKey()
	{
		return false;
	}

	public static bool GetAcceptUnknowPlayerGroupInvite()
	{
		return false;
	}

	public static void SetAcceptReserveInvite(bool value)
	{
	}

	public static bool GetAcceptReserveInvite()
	{
		return false;
	}

	public static bool GetAutoQuickChatV2Setting()
	{
		return false;
	}

	public static void SetEnableAutoQuickChatV2Setting(bool value)
	{
	}

	public static void ResetEnableAutoQuickChatV2Setting()
	{
	}

	public static void SetEnableQuickChat(bool value)
	{
	}

	public static bool GetEnableQuickChat()
	{
		return false;
	}

	public static void SetEnableQuickChatSound(bool value)
	{
	}

	public static bool GetEnableQuickChatSound()
	{
		return false;
	}

	public static void SetAcceptGroupInvite(bool value)
	{
	}

	public static bool GetAcceptGroupInvite()
	{
		return false;
	}

	public static void SetCustomRoomReplayEnabled(bool enabled)
	{
	}

	public static bool GetCustomRoomReplayEnabled()
	{
		return false;
	}

	public static void SetCustomRoomDelayOBEnabled(bool enabled)
	{
	}

	public static bool GetCustomRoomDelayOBEnabled()
	{
		return false;
	}

	public static void SetCustomRoomOpeningCamEnable(bool enabled)
	{
	}

	public static void SetTeamBillboardEnable(bool enabled)
	{
	}

	public static bool GetCustomRoomOpeningCamEnabled()
	{
		return false;
	}

	public static bool GetTeamBillboardEnabled()
	{
		return false;
	}

	public static void SetSlideChangeColorEnabled(bool enabled)
	{
	}

	public static void SetPCInGameFlagEnabled(bool enabled)
	{
	}

	public static bool GetPCInGameFlagEnabled()
	{
		return false;
	}

	public static bool GetSlideChangeColorEnabled()
	{
		return false;
	}

	public static bool GetCustomRoomMVPEnabled()
	{
		return false;
	}

	public static bool GetHitHintClassic()
	{
		return false;
	}

	public static void SetHitHintClassic(bool enabled)
	{
	}

	public static bool GetNameClassicEnable()
	{
		return false;
	}

	public static int GetNameClassicDefaultValue()
	{
		return 0;
	}

	public static bool GetQualityAllowOptionalDownLoadOpen()
	{
		return false;
	}

	public static bool GetOptionalAutoDownLoad()
	{
		return false;
	}

	public static void SetOptionalAutoDownLoad(bool On)
	{
	}

	public static bool GetOptionalAutoClearOnTime()
	{
		return false;
	}

	public static void SetOptionalAutoClearOnTime(bool On)
	{
	}

	public static bool GetCustomRoomPerspectiveType()
	{
		return false;
	}

	public static void SetCustomRoomPerspectiveType(bool left)
	{
	}

	public static bool GetCustomRoomPerspectiveColorType()
	{
		return false;
	}

	public static void SetCustomRoomPerspectiveColorType(bool stuffed)
	{
	}

	public static void SetCustomRoomPlayerSightEnabled(bool enable)
	{
	}

	public static bool GetCustomRoomPlayerSightEnabled()
	{
		return false;
	}

	public static void SetCustomRoomObTipsEnabled(bool enable)
	{
	}

	public static bool GetCustomRoomObTipsEnabled()
	{
		return false;
	}

	public static int GetCustomGrenadeSlot()
	{
		return 0;
	}

	public static void SetCustomGrenadeSlot(int slot)
	{
	}

	public static string GetChatBlockList()
	{
		return null;
	}

	public static void SetChatBlockList(string jsonData)
	{
	}

	public static bool GetSmartIceWallSetting()
	{
		return false;
	}

	public static void ResetSmartIceWallSetting()
	{
	}

	public static void SetSmartIceWallSetting(bool enable)
	{
	}

	public static void SetGrenadeSlotBeforeSmarIceWallEnable()
	{
	}

	public static void SetSmartIceWallShowSetting(bool enable)
	{
	}

	public static bool GetSmartIceWallShowSetting()
	{
		return false;
	}

	public static void SetSmartIceWallChangeBackWeaponSetting(bool enable)
	{
	}

	public static bool GetSmartIceWallChangeBackWeaponSetting()
	{
		return false;
	}

	public static int GetGrenadeSlotBeforeSmartIceWallEnable()
	{
		return 0;
	}

	public static bool GetSpecialCharacterVoiceSetting()
	{
		return false;
	}

	public static void SetSpecialCharacterVoiceSetting(bool enable)
	{
	}

	public static bool GetWeaponPowerLeaderBoardHidePlayerInfoSetting()
	{
		return false;
	}

	public static bool GetDisableFriendSpectateSetting()
	{
		return false;
	}

	public static float GetResolutionReduceRate()
	{
		return 0f;
	}

	public static int GetVideoDecoderSupport()
	{
		return 0;
	}

	public static void SetVideoDecoderSupport(bool able)
	{
	}

	public static void InitVibrateSetting(int type, int value)
	{
	}

	public static int GetVibrateSetting(int type)
	{
		return 0;
	}

	public static void SetVibrateSettingInLobby(bool value)
	{
	}

	public static bool GetVibrateSettingInLobby()
	{
		return false;
	}

	public static bool GetIsNewUserByAccountID()
	{
		return false;
	}

	public static void SetNewUserByAccountID()
	{
	}

	public static bool GetIsNewUser()
	{
		return false;
	}

	public static void SetNewUser()
	{
	}

	public static bool GetEverLoggedIn()
	{
		return false;
	}

	public static void SetEverLoggedIn()
	{
	}

	public static bool GetFriendRecommendState()
	{
		return false;
	}

	public static void SetFriendRecommendState(bool state)
	{
	}

	public static string GetBotAgentSwitchKeyWithUserID()
	{
		return null;
	}

	public static string GetBotAgentCSSwitchKeyWithUserID()
	{
		return null;
	}

	public static bool GetChatBubbleState()
	{
		return false;
	}

	public static void SetChatBubbleState(bool state)
	{
	}

	public static bool GetSendRemindNotifyState()
	{
		return false;
	}

	public static void SetSendRemindNotifyState(bool state)
	{
	}

	public static bool GetInviteNotifyState()
	{
		return false;
	}

	public static void SetInviteNotifyState(bool state)
	{
	}

	public static ulong GetInviteNotifyTimeStamp()
	{
		return 0uL;
	}

	public static void SetInviteNotifyTimeStamp(ulong stamp)
	{
	}

	private static List<ResourceID> GetMaxLobbyDependResList()
	{
		return null;
	}

	private static bool CheckMaxLobbyDependenceNeedDownload()
	{
		return false;
	}

	public static void SetSpectatorCameraMoveSpeed(float b)
	{
	}

	public static void SetSpectatorCameraRotateSpeed(float b)
	{
	}

	public static float GetSpectatorCameraMoveSpeed()
	{
		return 0f;
	}

	public static float GetSpectatorCameraRotateSpeed()
	{
		return 0f;
	}

	public static bool IsMobileReplaySettingEnabled()
	{
		return false;
	}

	public static void SetMobileReplaySettingEnabled(bool enabled)
	{
	}

	public static void SetHighlightRecordRequestPerssion(bool enable)
	{
	}

	public static void SetHighlightPhotoEnabled(bool enable)
	{
	}

	public static bool GetHighlightPhotoEnabled()
	{
		return false;
	}

	public static bool IsUnloadEmbeddedSceneObjects()
	{
		return false;
	}

	public static EHDABtestState GetABTestValue()
	{
		return EHDABtestState.Invalid;
	}

	public static void InitMaxSettingBeforeLogin()
	{
	}

	public static void InitMaxSettingAfterLogin()
	{
	}

	public static void RefreshMaxSetting()
	{
	}

	private static void InitHDConfig()
	{
	}

	public static void AdjustFullShadowSetting()
	{
	}

	public static void SetEnableReplaykitMicrophone(bool enable)
	{
	}

	public static void SetLoginVideoEnabled(bool enable)
	{
	}

	public static bool GetLoginVideoEnabled()
	{
		return false;
	}

	public static bool IsFFOHDAnimationDeviceSupported()
	{
		return false;
	}

	public static bool GetUseHDAnimation()
	{
		return false;
	}

	public static bool GetUseHDAnimationConfig()
	{
		return false;
	}

	public static void SetUseHDAnimation(bool flag)
	{
	}

	private static void SetUseHDAnimation(bool flag, bool syncAllPackageKeys)
	{
	}

	private static string GetUseHDAnimationKey()
	{
		return null;
	}

	public static void SetHDWeaponEffect(EHDWeaponEffect value)
	{
	}

	public static EHDWeaponEffect GetHDWeaponEffectConfig()
	{
		return EHDWeaponEffect.On;
	}

	public static EHDWeaponEffect GetHDWeaponEffect()
	{
		return EHDWeaponEffect.On;
	}

	public static void SetHDTexture(EHDTexture value)
	{
	}

	public static EHDTexture GetHDTexture()
	{
		return EHDTexture.On;
	}

	public static EHDVehicleVFX GetHDVehicleVFX()
	{
		return EHDVehicleVFX.On;
	}

	public static EHDShowMyLobby GetHDShowMyLobby()
	{
		return EHDShowMyLobby.On;
	}

	public static EHDShowCaptainLobby GetHDShowCaptainLobby()
	{
		return EHDShowCaptainLobby.On;
	}

	public static void SetHDShowMyLobby(EHDShowMyLobby value)
	{
	}

	public static void SetHDShowCaptainLobby(EHDShowCaptainLobby value)
	{
	}

	public static bool IsUseHDLogin()
	{
		return false;
	}

	public static bool IsUseHDLobby()
	{
		return false;
	}

	public static bool IsUseHDAudio(bool useGraphicsConfig = true)
	{
		return false;
	}

	public static bool CanUseHDVehicleVFX()
	{
		return false;
	}

	public static bool IsUseHDVehicleVFX(bool useGraphicsConfig = true)
	{
		return false;
	}

	public static bool IsUseHDAnimation(bool useGraphicsConfig = true)
	{
		return false;
	}

	public static bool IsUseHDWeaponEffect(bool useGraphicsConfig = true)
	{
		return false;
	}

	public static bool IsUseHDTexture(bool useGraphicsConfig = true)
	{
		return false;
	}

	public static ALBFCNLDNBL GetHDGraphQuality()
	{
		return (ALBFCNLDNBL)0;
	}

	public static void SetHDLobbyVehicleAutoRotate(bool isOn)
	{
	}

	public static bool GetHDLobbyVehicleAutoRotate()
	{
		return false;
	}

	public static void SetHDLobbyIceWallAutoRotate(bool isOn)
	{
	}

	public static bool GetHDLobbyIceWallAutoRotate()
	{
		return false;
	}

	public static void SetHDLobbySkyboardAutoRotate(bool isOn)
	{
	}

	public static bool GetHDLobbySkyboardAutoRotate()
	{
		return false;
	}

	public static bool GetFriendInvitationPush()
	{
		return false;
	}

	public static void SetFriendInvitationPush(bool isOn)
	{
	}

	public static float GetUGCCameraMoveSpeed()
	{
		return 0f;
	}

	public static void SetUGCCameraMoveSpeed(float value)
	{
	}

	public static bool GetUGCAcceptFriendGroupInvite()
	{
		return false;
	}

	public static void SetUGCAcceptFriendGroupInvite(bool value)
	{
	}

	public static void SetUGCSceneEditFirstEnterNewMap()
	{
	}

	public static bool GetSceneEditPointDrag()
	{
		return false;
	}

	public static void SetSceneEditPointDrag(bool value)
	{
	}

	public static bool GetSceneEditShowGridLine()
	{
		return false;
	}

	public static void SetSceneEditShowGridLine(bool value)
	{
	}

	public static bool GetSceneEditGridSnap()
	{
		return false;
	}

	public static void SetSceneEditGridSnap(bool value)
	{
	}

	public static void SetSceneEditBtnDesc(bool value)
	{
	}

	public static bool GetSceneEditBtnDesc()
	{
		return false;
	}

	public static float GetSceneEditGridGran()
	{
		return 0f;
	}

	public static float ResolveTutorialGridGran()
	{
		return 0f;
	}

	public static void SetSceneEditGridGran(float value)
	{
	}

	public static int GetSceneEditRotateInterval()
	{
		return 0;
	}

	public static void SetSceneEditRotateInterval(int value)
	{
	}

	public static float GetceneEditGridGran()
	{
		return 0f;
	}

	public static int GetSceneEditAutoSaveId()
	{
		return 0;
	}

	public static void SetSceneEditAutoSaveId(int value)
	{
	}

	public static void SetAutoEquipDefaultMusicVault(bool value)
	{
	}

	public static bool GetAutoEquipDefaultMusicVault()
	{
		return false;
	}

	public static int GetCrossHairMode()
	{
		return 0;
	}

	public static bool IsNewCrossHairMode()
	{
		return false;
	}

	public static void SetCrossHairMode(int value)
	{
	}

	public static int GetCrossHairReload()
	{
		return 0;
	}

	public static bool IsNewCrossHairReload()
	{
		return false;
	}

	public static void SetCrossHairReload(int value)
	{
	}

	public static int GetTrainingSkillCDFactor()
	{
		return 0;
	}

	public static void SetTrainingSkillCDFactor(int value)
	{
	}

	public static void SetAutoSearchOpenState(int opened)
	{
	}

	public static int GetItemFinderModeSetting()
	{
		return 0;
	}

	public static void SetItemFinderModeSetting(int value)
	{
	}

	public static int GetAutoSearchOpenState()
	{
		return 0;
	}

	public static void SetInventoryItemCombineState(int value)
	{
	}

	public static bool GetInventoryItemCombineState()
	{
		return false;
	}

	public static int GetInventoryItemCombineStateValue()
	{
		return 0;
	}

	public static void SetInventoryUselessGuide(int value)
	{
	}

	public static bool GetInventoryUselessGuide()
	{
		return false;
	}

	public static void SetInventoryCombineGuide(int value)
	{
	}

	public static int GetInventoryCombineGuide()
	{
		return 0;
	}

	public static void SetInventoryEntryGuide(int value)
	{
	}

	public static int GetInventoryEntryGuide()
	{
		return 0;
	}

	public static void SetAutoQuickMessage(int value)
	{
	}

	public static int GetAutoQuickMessage()
	{
		return 0;
	}

	public static bool HasAutoQuickMessageKey()
	{
		return false;
	}

	public static void SetAutoQuickMessageMatchID(string value)
	{
	}

	public static string GetAutoQuickMessageMatchID()
	{
		return null;
	}

	public static void SetForbidQuickChatMatchID(string value)
	{
	}

	public static string GetForbidQuickChatMatchID()
	{
		return null;
	}

	public static void SetForbidQuickChatMute(int key, int value)
	{
	}

	public static int GetForbidQuickChatMute(int key)
	{
		return 0;
	}

	public static void SetEquippedWeaponHistory(int key, int value)
	{
	}

	public static int GetEquippedWeaponHistory(int key)
	{
		return 0;
	}

	public static bool HasEquippedWeaponHistory(int key)
	{
		return false;
	}

	public static void DeleteEquippedWeaponHistory(int key)
	{
	}

	public static void SetEquippedWeaponHistoryForThisMatch(string value)
	{
	}

	public static string GetEquippedWeaponHistoryForThisMatch()
	{
		return null;
	}

	public static bool IsNetworkOptimizeMultiSessionSwitchOpen()
	{
		return false;
	}

	public static bool IsNetworkShowSelfDamageTypeSwitchOpen()
	{
		return false;
	}

	public static bool IsDeviceSupportNetworkOptimizeMultiSession()
	{
		return false;
	}

	public static bool IsNetworkOptimizeMultiSessionAllowed()
	{
		return false;
	}

	public static bool GetNetworkOptimizeMultiSessionPlayerPrefs()
	{
		return false;
	}

	public static void SetNetworkOptimizeMultiSessionPlayerPrefs(bool enable)
	{
	}

	public static int GetNetworkShowDamageTypePlayerPrefs()
	{
		return 0;
	}

	public static void SetNetworkShowDamageTypePlayerPrefs(int showType)
	{
	}

	public static bool IsNetworkOptimizeMultiSessionAvailable()
	{
		return false;
	}

	private static int GetAutoHidePetSwitchValue()
	{
		return 0;
	}

	public static bool GetIngameAutoHidePetPlayerPrefs()
	{
		return false;
	}

	public static void SetIngameAutoHidePetPlayerPrefs(bool autoHide)
	{
	}

	public static bool GetHitArmorHint()
	{
		return false;
	}

	public static bool GetGameVoiceBackground()
	{
		return false;
	}

	public static void SetGameVoiceBackground(bool isEnable)
	{
	}

	public static void SetMagicVoiceEffecId(int effecId)
	{
	}

	public static int GetMagicVoiceEffecId()
	{
		return 0;
	}

	public static int GetMagicVoiceEffecIsOpen()
	{
		return 0;
	}

	public static void SetMagicVoiceEffecIsOpen(bool isOpen)
	{
	}

	public static bool GetGameVoiceAutoBalacne()
	{
		return false;
	}

	public static bool GetPressedVoiceOpen()
	{
		return false;
	}

	public static void SetPressedVoiceOpen(bool isOpen)
	{
	}

	public static bool GetPressedVoiceIsAll()
	{
		return false;
	}

	public static void SetPressedVoiceIsAll(bool isAll)
	{
	}

	public static bool GetMuteNonPreMatchTeammate()
	{
		return false;
	}

	public static void SetMuteNonPreMatchTeammate(bool isMute)
	{
	}

	public static bool GetEmoteOnly1PAudio()
	{
		return false;
	}

	public static void SetEmoteOnly1PAudio(bool isOn)
	{
	}

	public static bool GetNearbyPeopleDiscoverable()
	{
		return false;
	}

	public static int GetFollowEmoteBeFollowedSetting()
	{
		return 0;
	}

	public static void SetNearbyPeopleDiscoverable(bool isDiscoverable)
	{
	}

	public static bool GetNearbyPeopleLocationPrecision()
	{
		return false;
	}

	public static void SetNearbyPeopleLocationPrecision(bool isPrecise)
	{
	}

	public static void SetFollowEmoteBeFollowedState(int followedState)
	{
	}

	public static void SetGameVoiceAutoBalance(bool isEnable)
	{
	}

	public static void SetCSShopShowTeammateWeaponInfo(bool bShow)
	{
	}

	public static bool GetCSShopShowTeammateWeaponInfo()
	{
		return false;
	}

	public static bool GetBarrageForFriendShipState()
	{
		return false;
	}

	public static void SetBarrageForFriendShipState(bool isOpen)
	{
	}

	public static bool GetBarrageForGuildWarState()
	{
		return false;
	}

	public static void SetDamageLabelType(int type)
	{
	}

	public static int GetDamageLabelType()
	{
		return 0;
	}

	public static void ResetDamageLabelType()
	{
	}

	public static void SetApplicationBlitType()
	{
	}

	public static bool NeedBlitTypeAlways()
	{
		return false;
	}

	public static float GetResolutionHeightReduceRate()
	{
		return 0f;
	}

	public static bool EnableMinResolutionHeight()
	{
		return false;
	}

	public static int GetMinResolutionHeight()
	{
		return 0;
	}

	public static bool EnableUnmapReservedWebViewVirtualMemory()
	{
		return false;
	}

	public static int GetUGCSubscribeRecommend()
	{
		return 0;
	}

	public static void SetUGCSubscribeRecommend(int value)
	{
	}

	public static int GetUGCMapAutoTranslate()
	{
		return 0;
	}

	public static void SetUGCMapAutoTranslate(int value)
	{
	}

	public static bool GetHUDButtonHintShow()
	{
		return false;
	}

	public static void SetHUDButtonHintShow(int value)
	{
	}

	public static bool GetShowCdTimeTxt()
	{
		return false;
	}

	public static void SetShowCdTimeTxt(bool value)
	{
	}

	public static void SetDamageLabelTotal(bool total)
	{
	}

	public static bool GetDamageLabelTotal()
	{
		return false;
	}

	public static bool CheckCameraFilter()
	{
		return false;
	}

	public static void TestMemoryAlloc()
	{
	}

	public static int GetVibrateSettingByKeyType(VibrationSettingKey type)
	{
		return 0;
	}

	public static void ResetVibrateSettingByKeyType(VibrationSettingKey type)
	{
	}

	public static string GetVibrateSettingKey(VibrationSettingKey type)
	{
		return null;
	}
}
