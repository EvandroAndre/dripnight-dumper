using System;
using System.Collections.Generic;

namespace COW;

public class FFStopWatch
{
	public enum TagType : uint
	{
		None,
		GetSDKDetail,
		ProcessTreasureBox,
		IntervalTree_CreateRanges,
		CreateLoginReqInfoData,
		DelayCreateLobbyStartGameContext,
		PrepareTouch,
		ProcessLocalBundle,
		MatchGameQuit2NewLobbyControllerInitFinish,
		WarmUpMessageInThread,
		UILobbyNewController_OnUIInit,
		PushNavigation_UILobbyNewController,
		FrontEndGame_OnSceneLoaded,
		WarmUpEVData,
		FrontEndGame_ReloadCSVDataFromMemory,
		FrontEndGame_ReloadTranslation,
		UIModelAvatarProfile_RequestLoginGetProfile_Finish,
		UIModelLogin_OnGetLoginDesc,
		UIModelLogin_ProcessSuccessfulLogin,
		Startup2Login,
		GameStartUp_Awake,
		GameStartUp_Awake_UGC,
		GameStartUp_Start,
		UILauncherController_OnUIOpen,
		Startup2Lobby,
		CowGameEntry_Awake,
		RetrieVeversion,
		UILauncherController_FirstLoad,
		UILauncherController_PlayerPrefs_Save_1,
		UILauncherController_PlayerPrefs_Save_2,
		UILauncherController_PlayerPrefs_Save_3,
		VersionCheck,
		HotUpdateDownload,
		DownloadOptionalLocRes,
		LoadFileInfo,
		DownloadCommonShader,
		CaculateMD5,
		StartGetLocalVersion,
		StartGetLocalVersion_Finished,
		StartVersionCheck,
		CowGameEntry_RefreshConfigData,
		CowGameEntry_ParseResourceConf,
		CowGameEntry_ParseResourceConfHotupdate,
		UILauncherController_ParseResourceConf,
		UILauncherController_LoadLoc,
		CowGameEntry_InjectFix,
		KeyValueData,
		KeyValueDataUtilReadKeyValue,
		RegionLangManagerInit,
		LocManager_LoadLoc,
		LocManager_ParseTranslation,
		SetBoolean,
		PreloadConfigData,
		TestLoadCSV,
		TestInitManager,
		TestInitManagerThread,
		UILauncherController_TestInitManager,
		AutoPickUpHelper,
		ProcessAH,
		CowGameEntry_EngineSwitchAndWarmUpShader,
		CowGameEntry_EngineSwitch,
		CowGameEntry_WarmUpShader,
		CowGameEntry_WarmUpShaderLoad,
		CowGameEntry_WarmUpShaderSetLod,
		CowGameEntry_EngineRest,
		CowGameEntry_WaitAllCSVEvent,
		MultiThreadPreloadCSVData_WaitAllCSVEvent,
		SdkLogin,
		ServerLogin,
		UMAContextSimple_InitCacheAndManagers,
		WarmupManager_WarmUpShaderProgressively,
		WarmupManager_WarmUpShaderInstantly,
		ConfigData_ReadKeyValue,
		ConfigData_LoadCsvText,
		ConfigData_ParseCSV,
		ConfigData_LoadCSVAsync,
		ConfigData_ThreadWait,
		ConfigData_ThreadParseCSV,
		ConfigData_LoopCallAfterParseData,
		KeyValueDataMap_SyncLoadOrg,
		KeyValueDataMap_SyncLoadTextOrg,
		KeyValueDataMap_SyncParseOrg,
		KeyValueDataMap_SyncLoad,
		KeyValueDataMap_SyncLoadText,
		KeyValueDataMap_SyncParse,
		KeyValueDataMap_AsyncLoadOrg,
		KeyValueDataMap_AsyncLoadTextOrg,
		KeyValueDataMap_AsyncParseOrg,
		KeyValueDataMap_AsyncLoad,
		KeyValueDataMap_AsyncLoadText,
		KeyValueDataMap_AsyncParse,
		KeyValueDataMap_LoadAsync,
		KeyValueDataMap_LoadAsyncText,
		KeyValueDataMap_Parse,
		SingletonModule_Init,
		UIModelManager_InitUIModel,
		ConfigData_ThreadWait_BundleDataManager,
		ConfigData_ThreadWait_TreasureBoxDataManager,
		ConfigData_ThreadWait_CSSharedAvatarDataManager,
		ConfigData_ThreadWait_SpawnDataManager,
		ConfigData_ThreadWait_AvatarWardrobeDataManager,
		ConfigData_ThreadWait_ElitePassDataManager,
		ConfigData_ThreadWait_CSSharedItemDataManager,
		ConfigData_ThreadWait_ItemManager,
		ConfigData_ThreadWait_CollectionDataManager,
		ConfigData_ThreadWait_AvatarProfileDataManager,
		ConfigData_ThreadParse_BundleDataManager,
		ConfigData_ThreadParse_TreasureBoxDataManager,
		ConfigData_ThreadParse_CSSharedAvatarDataManager,
		ConfigData_ThreadParse_SpawnDataManager,
		ConfigData_ThreadParse_AvatarWardrobeDataManager,
		ConfigData_ThreadParse_ElitePassDataManager,
		ConfigData_ThreadParse_CSSharedItemDataManager,
		ConfigData_ThreadParse_ItemManager,
		ConfigData_ThreadParse_CollectionDataManager,
		ConfigData_ThreadParse_AvatarProfileDataManager,
		ConfigData_ThreadWait_DevSpecWhitelistDataManager,
		ConfigData_ThreadParse_DevSpecWhitelistDataManager,
		ConfigData_ThreadWait_SkinDataManager,
		ConfigData_ThreadParse_SkinDataManager,
		ConfigData_ThreadWait_AudioConfigDataManager,
		ConfigData_ThreadParse_AudioConfigDataManager,
		ConfigData_ThreadWait_VoucherDataManager,
		ConfigData_ThreadParse_VoucherDataManager,
		ConfigData_ThreadWait_WeaponTabDataManager,
		ConfigData_ThreadParse_WeaponTabDataManager,
		ConfigData_ThreadWait_LoadingTipsDataManager,
		ConfigData_ThreadParse_LoadingTipsDataManager,
		ConfigData_ThreadWait_AchievementsDataManager,
		ConfigData_ThreadParse_AchievementsDataManager,
		ConfigData_ThreadWait_SoundTipsDataManager,
		ConfigData_ThreadParse_SoundTipsDataManager,
		ConfigData_ThreadWait_GameFunctionSwitchDataManager,
		ConfigData_ThreadParse_GameFunctionSwitchDataManager,
		ConfigData_ThreadWait_LadderConfigDataManager,
		ConfigData_ThreadParse_LadderConfigDataManager,
		ConfigData_ThreadWait_IceWallManager,
		ConfigData_ThreadParse_IceWallManager,
		ConfigData_ThreadWait_OptionalBundleDataManager,
		ConfigData_ThreadParse_OptionalBundleDataManager,
		ConfigData_ThreadWait_WebTutorialDataManager,
		ConfigData_ThreadParse_WebTutorialDataManager,
		ConfigData_ThreadWait_ClanBadgeInfoDataManager,
		ConfigData_ThreadParse_ClanBadgeInfoDataManager,
		ConfigData_ThreadWait_MentorTitleDataManager,
		ConfigData_ThreadParse_MentorTitleDataManager,
		ConfigData_ThreadWait_EventClothEffectDataManager,
		ConfigData_ThreadParse_EventClothEffectDataManager,
		ConfigData_ThreadWait_SpecialCharacterVoiceConfigDataManager,
		ConfigData_ThreadParse_SpecialCharacterVoiceConfigDataManager,
		ConfigData_ThreadWait_TutorialSoundDataManager,
		ConfigData_ThreadParse_TutorialSoundDataManager,
		ConfigData_ThreadWait_PVETalentDataManager,
		ConfigData_ThreadParse_PVETalentDataManager,
		ConfigData_ThreadWait_GameAssistantConfigDataManager,
		ConfigData_ThreadParse_GameAssistantConfigDataManager,
		ConfigData_ThreadWait_GameMissionDataManager,
		ConfigData_ThreadParse_GameMissionDataManager,
		ConfigData_ThreadWait_GameGlobalMissionDataManager,
		ConfigData_ThreadParse_GameGlobalMissionDataManager,
		ConfigData_ThreadWait_AutoPickUpHelper,
		ConfigData_ThreadParse_AutoPickUpHelper,
		ConfigData_ThreadWait_RegionActivityDataManager,
		ConfigData_ThreadParse_RegionActivityDataManager,
		ConfigData_ThreadWait_ClimbingTriggerSettingManager,
		ConfigData_ThreadParse_ClimbingTriggerSettingManager,
		ConfigData_ThreadWait_FullScreenPreviewDataManager,
		ConfigData_ThreadParse_FullScreenPreviewDataManager,
		ConfigData_ThreadWait_RoomGameSettingDataManager,
		ConfigData_ThreadParse_RoomGameSettingDataManager,
		ConfigData_ThreadWait_RoomOBEventDataManager,
		ConfigData_ThreadParse_RoomOBEventDataManager,
		ConfigData_ThreadWait_CSShopRecommendSetManager,
		ConfigData_ThreadParse_CSShopRecommendSetManager,
		ConfigData_ThreadWait_AvatarSkillDataManager,
		ConfigData_ThreadParse_AvatarSkillDataManager,
		ConfigData_ThreadWait_WeaponUpgradeInfoDataManager,
		ConfigData_ThreadParse_WeaponUpgradeInfoDataManager,
		ManagerInit_1,
		ManagerInit_2,
		ManagerInit_3,
		LoopCallAfterParseData,
		GameEngine_CleanAssets_1,
		GameEngine_CleanAssets_2,
		GameEngine_CleanAssets_2_1,
		GameEngine_CleanAssets_2_2,
		GameEngine_LoadAndRun,
		GameEngine_SceneChange,
		GameEngine_SceneChange_UIModelManager,
		GameEngine_SceneChange_ServiceConnectionManager,
		GameEngine_SceneChange_Remove,
		GameEngine_SceneChange_OnSceneChange,
		GameEngine_SceneChange_UIModelMall,
		GameEngine_SceneChange_UIModelMall_LoadData,
		GameEngine_SceneChange_UIModelMall_SaveData,
		GameEngine_SceneChange_UIModelLobbyPing,
		GameEngine_SceneChange_UIModelAvatar,
		GameEngine_SceneChange_UIModelActivity,
		GameEngine_CustomUIAtlasSetValid,
		GameEngine_CleanAssets,
		GameEngine_LoadLoadingScene,
		UILoadingControllerAwake2Desrtoy,
		GameEngine_LoadPendingGame_WithoutCoroutine,
		GameEngine_LoadPendingGame_ObjectPoolRepositoryClearAll,
		GameEngine_LoadGameProcess,
		GameEngine_UnloadShaderSource,
		GameEngine_ClearAllLoadedResource,
		GameEngine_LoadGameScene,
		VegetationManager_Start,
		SceneGraphics_Start,
		Streamer_Start,
		GameEngine_SetGraphicsQuality,
		GameEngine_SceneLoaded,
		GameEngine_AsyncLoadPreloadResource,
		GameEngine_AsyncLoadPreloadUMAResource,
		MultiplePlayerGame_OnGameServerJoinMatch,
		UIInGameScene_OpenHud,
		GameEngine_PreloadUMA,
		GameEngine_PreloadBaseUMA,
		GameEngine_AsyncLoadPreloadAudioResource,
		GameEngine_GamePreloaded,
		GameEngine_LoadGameProcess_1,
		GameEngine_LoadGameProcess_2,
		GameEngine_LoadGameProcess_GameInit,
		GameEngine_LoadLoadingScene_StartLoadingSceneAsync,
		GameEngine_LoadLoadingScene_1,
		GameEngine_LoadLoadingScene_2,
		GameEngine_Graphic_9,
		GameEngine_Graphic_10,
		GameEngine_LoadPreLoadAudioPure,
		MultiplePlayerGameMessageHandler_OnMsgPlayerJoin,
		GameEngine_LoadPreloadResource,
		GameEngine_LoadPreLoadPure,
		UIInGameScene_OpenUI,
		MultiplePlayerGameSendJoinAndReciveJoin,
		UMAGeneratorBuiltin_GC_Collect,
		UMAGeneratorBuiltin_Work,
		UMAGeneratorBuiltin_WorkSync,
		HttpManager_curReq_Notify,
		HttpManager_curReq_Deserialize,
		NetworkMessageDispatcher_MsgHandlerContinueRudp,
		NetworkMessageDispatcher_MsgHandlerInvoke,
		UIBaseScene_OpenUI,
		UIBaseScene_LoadUI,
		UIBaseScene_InstanceUI,
		LoadingLevelObjectSyncAction,
		UILobbyV2Controller_OnUIInit,
		UILobbyV2Controller_OnNavigationShow,
		PushNavigation_UILobbyV2Controller,
		Login_WaitPreload,
		ConfigData_LoadCSV,
		UILoadingPrintOpenedUI,
		OnCabinWaitingStart,
		GetCabinResource,
		Player_BuildCharacterImmediatly,
		AvatarManager_Instant,
		Player_InitCollider,
		Player_Init,
		Player_CreatePlayer_Instant,
		GcUtil_Collect,
		MultiplePlayerGameMessageHandler_OnMsgSyncPRIData,
		NetworkMessageDispatcher_MsgHandlerInvokeSum,
		UIBlackScreen,
		UILoading_DestroyImmediate,
		UILoading_OnDestroy,
		UnloadUnusedAssets_1,
		UnloadUnusedAssets_2,
		UnloadUnusedAssets_3,
		UnloadUnusedAssets_4,
		UnloadUnusedAssets_5,
		Test1_Load,
		Test2_Load,
		UIBaseView_Dump,
		NetworkMessageDispatcher_MsgFameEndHandlerInvokeSum,
		OptionalDownloadOnTimeDelFileWrite,
		LobbySocialArea_OnSceneLoaded
	}

	public static int MainThreadId;

	public static bool IsMainThread => false;

	public static void UpdateFFStopWatchConfig(Dictionary<string, string> gameVarPairFromLocalConfig)
	{
	}

	public static void AddLogRecordList(string record)
	{
	}

	public static void ProfilerLoading(string record)
	{
	}

	public static void SampleTagTimeBegin(TagType tag)
	{
	}

	public static void SampleTagTimeEnd(TagType tag)
	{
	}

	public static void StartNewGame(Type game)
	{
	}

	public static void DrawSeparation()
	{
	}

	public static void SampleTagTimeSumBegin(TagType tag)
	{
	}

	public static void SampleTagTimeSumEnd(TagType tag)
	{
	}

	public static void SampleTagTimeCleanAndWriteAllSum()
	{
	}

	public static void SampleTagTimeWithTypeBegin(TagType tag, Type uiBaseControllerType)
	{
	}

	public static void SampleTagTimeWithTypeEnd(TagType tag, Type uiBaseControllerType)
	{
	}

	public static void SampleTagTimeWithStringBegin(TagType tag, string url)
	{
	}

	public static void SampleTagTimeWithStringEnd(TagType tag, string url)
	{
	}

	public static void SampleTagTimeWithUintBegin(TagType tag, uint cmd)
	{
	}

	public static void SampleTagTimeWithUintEnd(TagType tag, uint cmd)
	{
	}

	public static void AddCurrentTimeSinceStart()
	{
	}

	public static void AddCurrentTimeSinceStart(string s)
	{
	}

	public static void EnterWaitAllCSVEvent()
	{
	}

	public static void SaveLogRecordList()
	{
	}

	public static void SampleUITypeTimeBegin(TagType tag, Type uiType)
	{
	}

	public static void SampleUITypeTimeEnd(TagType tag, Type uiType)
	{
	}

	public static void SampleDoubleTagWithTypeTimeBegin(TagType mainTag, uint subTag, Type type)
	{
	}

	public static void SampleDoubleTagWithTypeTimeEnd(TagType mainTag, uint subTag, Type type)
	{
	}

	public static void SampleDoubleTagWithStringTimeBegin(TagType mainTag, uint subTag, string str)
	{
	}

	public static void SampleDoubleTagWithStringTimeEnd(TagType mainTag, uint subTag, string str)
	{
	}
}
