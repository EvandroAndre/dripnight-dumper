using System;
using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using COW.Gameplay;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

internal class GameFacade
{
	public enum ELobbyEntryReason
	{
		Default,
		ReturnFromInGame
	}

	public enum EMPConnectionType
	{
		CREATE_NEW_CONN,
		REUSE_OLD_CONN
	}

	public enum ESocialLobbyState
	{
		None,
		EnterNinthArea,
		EnterSocialArea,
		ExitNinthArea,
		ExitSocialArea,
		GotoMapMode
	}

	private sealed class _003C_003Ec__DisplayClass397_0<TRes>
	{
		public Action<HttpErrorCode, object> onFinished;

		internal void _003CSendServerRequest_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public static BaseGame CurrentGame;

	public static MatchGame CurrentMatchGame;

	public const string NO_BLOOD_RESOURCE = "_India";

	public static readonly string KEY_IS_BLACK_BLOOD;

	private static readonly string KEY_CUSTOMROOM_IS_BLOOD_SHOW;

	private static readonly string KEY_CUSTOMROOM_IS_SAFEZONE_DAMAGE_EFFECT_SHOW;

	public static readonly string KEY_DEMAGE_LABELTYPE;

	public static readonly string UILOADING;

	public static readonly string UIRELOADING;

	public static readonly string INDIA_NO_BLOOD_KILL_ICON;

	private static BloodType m_bloodType;

	private static BloodConfigType m_BloodConfigType;

	public static readonly bool IsPCClient;

	public static ulong LocalPlayerUserID;

	public static byte RegionID;

	public static string RegionName;

	public static string NotiRegionName;

	public static string LastLoginRegionName;

	public static bool UseRegionalGameVar;

	public static bool OfflineMode;

	public static string m_GameServerAddr;

	public static int m_GameServerPort;

	public static int GameServerProxyPort;

	public static string m_ProxyGameServerAddr;

	public static int m_ProxyGameServerPort;

	public static ulong GameServerMatchID;

	public static ulong GameServerServiceMatchID;

	public static string GameServerToken;

	public static string GameServerSecretKey;

	public static string GameServerUDPHeadSecret;

	public static string GameProxyServerSecretKey;

	public static string GameProxyServerUDPHeadSecret;

	public static string DebugNickName;

	public static bool IsMUDP;

	public static bool ReadMultiRegionCSVError;

	public static bool NeedSaveSettingContentLog;

	public static bool ShowReplayFakeLoading;

	private static MapLayer m_GameServerMapLayer;

	private static MapConfigData m_GameServerMapConfigData;

	private static MapConfigData m_LobbySocialAreaMapConfigData;

	public static uint GameServerGameModeReconnectCache;

	public static uint GameServerMapIDReconnectCache;

	private static uint m_GameServerMapID;

	private static uint m_GameServerGameMode;

	public static bool isCabinBR;

	private static uint m_GameServerSceneLayer;

	public static bool TestModeButton;

	public static uint GameServerMatchMode;

	public static uint GameServerGroupMode;

	public static uint GameServerRoomRole;

	public static uint GameServerRoomType;

	public static uint GameServerDifficult;

	public static ulong EsportsID;

	public static int LastGameReturnToLobbyReason;

	public static bool IsReconnect;

	public static bool IsReconnectFromLobby;

	public static bool IsReconnectWithoutParseToken;

	public static bool IsLobbyReconnect;

	public static bool IsLobbyRoomMatchReconnect;

	public static bool NeedClearReconnectInfo;

	public static bool IsObserver;

	public static bool IsFriendObserver;

	public static bool LastGameNeedReconnect;

	public static string LastGameReturnToLobbyReasonTxt;

	public static ulong LastGameNeedReconnectServiceMatchID;

	public static uint LastGameReconnectTimes;

	public static ulong LastGameReconnectStartMoment;

	public static bool LastGameReconnectIsFriendOB;

	public static uint LobbyCustomRoomIndex;

	public static uint CustomRoomGroupIcon;

	public static bool IsROGPhone;

	public static bool IsSpecialPool;

	public static bool IsEmulatorPool;

	public static bool GameMainSceneLoadedByAb;

	public static bool IsUGCGameDataLoadedByRunner;

	public static string GameServerUGCGameDataUrl;

	public static byte[] GameServerWorkshopModeSettings;

	public static CLMPMGMIDGD GameServerWorkshopModeSettingsDeserialized;

	public static string GameServerWorkshopShareCode;

	public static string GameServerWorkshopOriginalCode;

	public static string GameServerWorkshopMapName;

	public static uint GameServerWorkshopResLevelMark;

	public static EHKDNIGOIEM LobbyUGCLoadingResourceState;

	public static List<ulong> LobbyUGCLoadingUnfinishedPlayers;

	public static ulong DebugFriendOBTrackingUserID;

	public static bool GameServerConnected;

	public static bool IsHighFps;

	public static string InGameSplitSceneReplaceLabel;

	private static byte[] _003CUGCGSGameData_MD5_003Ek__BackingField;

	private static JOEANMPIFAB _003CUGCGSGameData_003Ek__BackingField;

	public static UGCResInfo UGCGameResInfoForLocalTest;

	public static byte[] UGCGameDataBytesForLocalTest;

	public static bool IsUGCDownloadingNotNecessaryResInGame;

	public static bool IsMatchStarted;

	public static uint LevelVisualStyle;

	public static uint GamePlayOpen;

	public static uint SpecialModeEventID;

	public static uint GamePattern;

	public static bool IsHalfWayJoin;

	public static bool IsUGCFriendHalfWayJoin;

	public static EQuitGameReason LastUGCGameQuitReason;

	public static bool HideLobbyShadow;

	public static float ReplayLobbyBGAnimTimeStamp;

	public static bool FirstPlayLobbyBGAnim;

	public static bool IsUILobbyInGame;

	public static bool NeedStopBGAnimWhenLogin;

	public static ELobbyEntryReason LobbyEntryReason;

	public static bool HasRunLoginAutoTask;

	private static bool _IsAddicticUser;

	private static bool _IsAddictMatchUser;

	public static string AddicticFloating;

	public static ulong AddictAllTime;

	public static ulong AddictMatchTime;

	public static ulong StartTvTime;

	public static ulong FinishTvTime;

	public static ulong LastTvTime;

	public static bool _DeviceMaxConfirm;

	public static uint chessType;

	public static uint booyahtimes;

	public static uint SuperEmoteJoinPlayRoleNum;

	public static uint BooyahSuperEmoteId;

	public static bool ReleaseLightmapMemoryOnUnloading;

	public static bool UnloadEmbeddedSceneObjects;

	public static bool IsUGCUserEventlogSended;

	public static string[] m_WeaponDecreaseBackType;

	public static float STREAMING_BAND_RANGE_X;

	public static float STREAMING_BAND_RANGE_Y;

	public static float STREAMING_BAND_RANGE_Z;

	public static bool NeedReloadCSVDataToMemory;

	public static List<CSVBaseData> VersionGameVar;

	public static bool IsCloseScreenShotWnd;

	public static bool IsCloseSaveImageWnd;

	public static bool NeedRejoinWorldChannel;

	public static bool NeedRejoinNewbieChannel;

	public static bool NeedToLoadMPScene;

	public static bool IsFinishFirstGotoLobbyAfterLogin;

	public static ulong ShardKey;

	public static bool LobbySocialAreaMatchSucc;

	public static string SettingLanguageToCollectionQuickChatData;

	public static DevSpecWhitelistData VersionWhitelistData;

	public static DeviceWhiteListSpecialData VersionWhitelistSpData;

	private static PerformacneMonitor m_BattlePerfMonitor;

	private static bool m_CheckUnregister;

	private static int s_UseNewRunning;

	private static bool _003CPopEvents_003Ek__BackingField;

	public static bool IsGroupUIOpen;

	public static bool IsHCGroupUIOpen;

	public const float DEFAULT_TIME_SCALE = 1f;

	private static bool m_iceWallMakerState;

	private static int m_KillCamFrameCount;

	private static int m_ExtendCount;

	public static bool IsOnEighthLand;

	private static int m_OnEighthLandFrameCount;

	private static UIModelWeaponProficiency m_UIModelWeaponProficiency;

	private static UIModelWishList m_UIModelWishList;

	private static UIModelNewVault m_UIModelNewVault;

	private static UIModelMatch m_UIModelMatch;

	private static UIModelSpectator m_UIModelSpectator;

	private static UIModelCollection m_UIModelCollection;

	private static UIModelOptionalDownload m_ModelOptionalDownload;

	private static UIModelStoreBox m_UIModelStoreBox;

	private static UIModelFriends m_UIModelFriends;

	private static UIModelLobbySocial m_UIModelLobbySocial;

	private static UIModelRole m_modelRole;

	private static UIModelPrime m_modelPrime;

	private static UIModelGameAssistantIntroduction m_UIModelGameAssistantIntroduction;

	private static uint _003CResourceLoadCount_003Ek__BackingField;

	public static bool HasPlayedFirstGameFlag;

	public static bool HasFirstGameLandFlag;

	private static bool openingMovieRegionEnable;

	private static bool m_EmulatorChecked;

	private static bool m_IsEmulator;

	private static bool m_InitSocialVoiceSet;

	private static bool EnableSocialVoice;

	public static ulong NewVersionStartTime;

	public static ulong OldVersionEndTime;

	public static bool IsLatestReleaseVersionByVersionList;

	public static bool IsLatestReleaseVersionByServer;

	private static List<uint> m_ListPreCloseTime;

	private static int[] m_SaveInstructItemTypes;

	public static bool BotAgentEnabledInGame;

	private static readonly string m_ShowGetOffSlideGuideKey;

	public static bool LoginDescGetAccountSwitch;

	public static float PacketLossRateForEditorTest;

	public static bool IsDefault3DLobby;

	public static bool IsSocialLobbyRoom;

	public static ESocialLobbyState SocialLobbyState;

	public static string GameServerAddr
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static int GameServerPort
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static string ProxyGameServerAddr
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static int ProxyGameServerPort
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool IsCameraMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsCameraModeZooming
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsInVerticalCameraMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsInFreeViewMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsLocalPlayerHideByCameraMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsTeammateHideByCameraMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsEnemyHideByCameraMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool CanShowEnemyToggleInCameraMode => false;

	public static MapLayer GameServerMapLayer => null;

	public static MapConfigData GameServerMapConfigData => null;

	public static uint GameServerMapID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public static uint GameServerGameMode
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public static uint GameServerSceneLayer
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public static byte[] UGCGSGameData_MD5
	{
		get
		{
			return _003CUGCGSGameData_MD5_003Ek__BackingField;
		}
		private set
		{
			_003CUGCGSGameData_MD5_003Ek__BackingField = value;
		}
	}

	public static JOEANMPIFAB UGCGSGameData
	{
		get
		{
			return _003CUGCGSGameData_003Ek__BackingField;
		}
		private set
		{
			_003CUGCGSGameData_003Ek__BackingField = value;
		}
	}

	public static PerformacneMonitor BattleGamePerfMonitor => null;

	public static bool CheckUnregister
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int UseNewRunning
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool UseBooyahEmote
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool ReplaceBooyahEmote
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static uint DefaultFollowEmoteItemId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public static bool IsDebtUser => false;

	public static bool IsAddicticUser
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool DeviceMaxConfirm
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsAddicticMatchUser
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool PopEvents
	{
		get
		{
			return _003CPopEvents_003Ek__BackingField;
		}
		private set
		{
			_003CPopEvents_003Ek__BackingField = value;
		}
	}

	public static bool IsUsePCWaitingRoomRankUI => false;

	public static bool IsUGCDebuggerMode => false;

	public static UIModelWeaponProficiency UIModelWeaponProficiency => null;

	public static UIModelWishList UIModelWishList => null;

	public static UIModelNewVault UIModelNewVault => null;

	public static UIModelMatch UIModelMatch => null;

	public static UIModelSpectator UIModelSpectator => null;

	public static UIModelCollection UIModelCollection => null;

	public static UIModelOptionalDownload ModelOptionalDownload => null;

	public static UIModelStoreBox UIModelStoreBox => null;

	public static UIModelFriends UIModelFriends => null;

	public static UIModelLobbySocial UIModelLobbySocial => null;

	public static UIModelRole UIModelRole => null;

	public static UIModelPrime UIModelPrime => null;

	public static UIModelGameAssistantIntroduction UIModelGameAssistantIntroduction => null;

	public static uint ResourceLoadCount
	{
		get
		{
			return _003CResourceLoadCount_003Ek__BackingField;
		}
		set
		{
			_003CResourceLoadCount_003Ek__BackingField = value;
		}
	}

	public static bool IsFriendDamage => false;

	public static bool IsHardCore => false;

	public static NIKKALKPIBO SelectedGameMode => NIKKALKPIBO.EGAMEMODE_NONE;

	public static bool IsCompatibleLogin => false;

	public static bool IsDuringDuoVersion => false;

	public static bool IsLatestReleaseVersion => false;

	public static List<uint> ListPreCloseTime => null;

	public static bool UseExtremeOpt => false;

	public static bool CheckVisibleByCameraMode(BHGGAEEHJCO playerID)
	{
		return false;
	}

	public static bool IsCameraModeEnable()
	{
		return false;
	}

	public static bool IsFullCameraModeGameMode()
	{
		return false;
	}

	public static void ClearLobbySocialAreaMapConfigData()
	{
	}

	private static void RefreshMapConfig()
	{
	}

	private static void RefreshMapLayer()
	{
	}

	public static void PreloadGlooWorldRes()
	{
	}

	private static void OnAsyncPreLoaded(uint ticket, bool succeeded, UnityEngine.Object resObj)
	{
	}

	public static void SetUGCGSGameData(JOEANMPIFAB gameData, byte[] md5)
	{
	}

	public static void RefreshStreamerSize()
	{
	}

	public static void UpdateSettingContentLogFlag()
	{
	}

	public static void ToggleAllCameraUI()
	{
	}

	public static bool IsBackDecreaseWeaponType(int WeaponType)
	{
		return false;
	}

	public static void DeleteUseNewRunningKey()
	{
	}

	public static uint GetActiveFollowEmotePlayId()
	{
		return 0u;
	}

	public static void ClearManualFollowEmoteDefaultIfRemovedFromWheel(UIModelInventory inventory)
	{
	}

	private static uint GetFirstEquippedFollowEmoteIdOnWheel(UIModelInventory inventory)
	{
		return 0u;
	}

	public static bool IsFollowEmoteMode()
	{
		return false;
	}

	public static bool IsFollowEmoteHudClosed()
	{
		return false;
	}

	public static bool CanShowFollowEmoteHud()
	{
		return false;
	}

	public static bool CanShowEnemyFollowMoveEmoteToLocalViewer()
	{
		return false;
	}

	public static void Cleanup()
	{
	}

	public static void SetCurrentGame(BaseGame game)
	{
	}

	public static UICOWBaseScene CurrentUIScene()
	{
		return null;
	}

	public static UIFrontEndScene CurrentFrontEndScene()
	{
		return null;
	}

	public static UIAvatarWindowController GetFrontEndSceneAvatarWnd()
	{
		return null;
	}

	public static UIInGameScene CurrentInGameUIScene()
	{
		return null;
	}

	public static bool IsInGameUIScene()
	{
		return false;
	}

	public static AMGDCBACIBH GetBuffHUDDataByUID(ulong uid)
	{
		return null;
	}

	public static AMGDCBACIBH GetSpecatorBuffHUDDataByUID(ulong uid, BHGGAEEHJCO playerID)
	{
		return null;
	}

	public static List<AMGDCBACIBH> GetAllSpectatorBuffHUDDataByPlayerID(BHGGAEEHJCO playerID)
	{
		return null;
	}

	public static PBMECFKJKFO GetBuffHUDCustomVFXDataByUID(ulong uid)
	{
		return null;
	}

	public static void RefreshAllDebuffList()
	{
	}

	public static List<Player.FLFADFKGIHB> GetAllDebuffDataList()
	{
		return null;
	}

	public static bool IsCurrentWeaponSkinGunBuff()
	{
		return false;
	}

	public static bool IsCurrentWeaponSkinGunBuff(uint behaviorID)
	{
		return false;
	}

	public static bool UsePlayerUpMiniMap()
	{
		return false;
	}

	public static UIForceTutorialGameScene ForceTutorialGameUIScene()
	{
		return null;
	}

	public static UITutorialCSGameScene TutorialCSGameUIScene()
	{
		return null;
	}

	public static UICollectionTrialScene CollectionTrialUIScene()
	{
		return null;
	}

	public static TimeService CurrentGameTimer()
	{
		return null;
	}

	public static void SetTimeScale(float scale = 1f)
	{
	}

	public static void ResetTimeScale()
	{
	}

	public static EventDispatcher CurrentGameEventDispatcher()
	{
		return null;
	}

	public static TimeService CurrentGameSimulationTimer()
	{
		return null;
	}

	public static float CurrentGameFixedDeltaTime()
	{
		return 0f;
	}

	public static MADJIBAMOLM CurrentAvatarAttributeManager()
	{
		return null;
	}

	public static IOGBFCCOHIL CurrentOniQuestManager()
	{
		return null;
	}

	public static DHBFKHBHIAA CurrentDeadLootBoardManager()
	{
		return null;
	}

	public static LPDFKAMGMAI CurrentCSRandomBuffManager()
	{
		return null;
	}

	public static OADCLGCBGGE GetSpecialCSEnv()
	{
		return null;
	}

	public static IJKMLLKGDPJ CurrentCSChooseSkillManager()
	{
		return null;
	}

	public static bool IsEnableDualSkill()
	{
		return false;
	}

	public static bool IsInChooseSkillPhase()
	{
		return false;
	}

	public static bool IsRecoverEpForbiddenMatchPhase()
	{
		return false;
	}

	public static BHOAPEABNIN GetVerticleViewBuffGenerator()
	{
		return null;
	}

	public static ANINHOGNNKB CurrentCameraModeManager()
	{
		return null;
	}

	public static NAHFMFGGCDN CurrentLevelObjectManager()
	{
		return null;
	}

	public static MFHGBNGFDIP CurrentMetaManager()
	{
		return null;
	}

	public static CLLLDGMKBHK CurrentInGameShopManager()
	{
		return null;
	}

	public static GameModeSetting CurrentGameModeSetting()
	{
		return null;
	}

	public static bool IsUGCEnabledInGame()
	{
		return false;
	}

	public static bool IsGamePaused()
	{
		return false;
	}

	public static bool IsLobbyGameType(ELobbyGameType lobbyGameType)
	{
		return false;
	}

	public static bool IsLobbySocialAreaMode()
	{
		return false;
	}

	public static bool IsLobbySocialAreaArenaRelatedState()
	{
		return false;
	}

	public static bool IsLobbySocialAreaArenaMatchBlocked()
	{
		return false;
	}

	public static void ShowLobbySocialAreaArenaBlockedTips()
	{
	}

	public static void TrySelectLobbySocialAreaInteractionTarget(Player target, EventLogger.ESocialHubPersonalInfoTriggerSource source)
	{
	}

	public static EMKJHAJNPDH CurrentMatch()
	{
		return null;
	}

	public static bool CurrentMatchHasBot()
	{
		return false;
	}

	public static ulong GetLocalPlayerUserID()
	{
		return 0uL;
	}

	public static FOCGJHJOBFE CurrentLocalPawn()
	{
		return null;
	}

	public static Player GetLocalPlayerOrObServer()
	{
		return null;
	}

	public static bool IsLocalTeammate(Player player)
	{
		return false;
	}

	public static bool IsLocalPlayerOrObServerFPPMode()
	{
		return false;
	}

	public static bool IsFPPOrUGCGameMode()
	{
		return false;
	}

	public static bool NeedLoadFPPConfigWhenEnterGame()
	{
		return false;
	}

	public static Player CurrentLocalPlayer()
	{
		return null;
	}

	public static AttackableEntity GetPlayerByIDIncludePendingReviveOrMatchAI(BHGGAEEHJCO playerID)
	{
		return null;
	}

	public static PlayerWereWolves CurrentLocalWereWolvesPlayer()
	{
		return null;
	}

	public static Player CurrentLocalPlayerWithPending()
	{
		return null;
	}

	public static BHGGAEEHJCO CurrentLocalPlayerID()
	{
		return default(BHGGAEEHJCO);
	}

	public static uint CurrentLocalPlayerTeamIndex()
	{
		return 0u;
	}

	public static MatchTeam CurrentLocalTeam()
	{
		return null;
	}

	public static Player GetLocalTeammateByTeamIndex(int teamIndex)
	{
		return null;
	}

	public static PHLHIEGPMMK CurrentLocalObserver()
	{
		return null;
	}

	public static PHLHIEGPMMK GetLocalObserverNotRoomSpectator()
	{
		return null;
	}

	public static FNJJOALKJOC GetObserverAssistantManager()
	{
		return null;
	}

	public static APELCIGCHDJ CurrentLocalSpectator()
	{
		return null;
	}

	public static Player GetLocalPlayerOrObserverTarget()
	{
		return null;
	}

	public static bool TryGetReplayOrKillCamViewTeamId(out int teamId)
	{
		teamId = default(int);
		return false;
	}

	public static Player GetReplayOrKillCamViewPlayer()
	{
		return null;
	}

	private static bool IsReplayOrKillCamState()
	{
		return false;
	}

	public static BHGGAEEHJCO GetLocalPlayerOrObserverTargetId()
	{
		return default(BHGGAEEHJCO);
	}

	public static bool IsLocalPlayerOrObserverTarget(BHGGAEEHJCO playerID)
	{
		return false;
	}

	public static bool IsLocalPlayerOrObserverTargetTeammate(BHGGAEEHJCO playerID)
	{
		return false;
	}

	public static SceneEditFocus CurrentSceneEditFocus()
	{
		return null;
	}

	public static SceneEditAgent CurrentSceneEditAgent()
	{
		return null;
	}

	public static SceneEditResourceShopManager CurrentResourceShopManager()
	{
		return null;
	}

	public static WorkshopPrefabItemManager CurrentPrefabItemManager()
	{
		return null;
	}

	public static GAPHGOAAKML CurrentAsyncLoadManager()
	{
		return null;
	}

	public static HNDHJGJILHC CurrentSceneEditGame()
	{
		return null;
	}

	public static bool IsCurrentSceneEditGameInEditPhase()
	{
		return false;
	}

	public static bool IsSceneEditGame()
	{
		return false;
	}

	public static bool IsCurrentUGCInGameMatchmaking()
	{
		return false;
	}

	public static bool HasCustomLevelObjectEditor(string logTitle)
	{
		return false;
	}

	public static FFEAJEKGIIF CurrentSceneBuilder()
	{
		return null;
	}

	public static UGCMiniMapMgr CurrentUGCMiniMap()
	{
		return null;
	}

	public static void EnableCheckUpperPanelForLeftRightAxisInput(bool enable)
	{
	}

	public static void EnableCheckUpperPanelForLeftAxisInput(bool enable)
	{
	}

	public static void EnableCheckUpperPanelForRightAxisInput(bool enable)
	{
	}

	public static void EnablePopupMaskForLeftRightAxisInput(bool enable)
	{
	}

	public static void OnMatchSuccessLoading(uint ret, MatchmakingSussNtf resData, string outAddr, int outPort)
	{
	}

	public static bool IsSameFaction(Player p1, Player p2)
	{
		return false;
	}

	public static bool IsSameTeam(Player p1, Player p2)
	{
		return false;
	}

	public static bool IsSameTeam(BHGGAEEHJCO p1, BHGGAEEHJCO p2)
	{
		return false;
	}

	public static EFactionRelationType GetRelationWithTrackedPlayer(BHGGAEEHJCO playerID)
	{
		return EFactionRelationType.Friendly;
	}

	public static EFactionRelationType GetRelationWithTrackedPlayer(BHGGAEEHJCO playerID, BHGGAEEHJCO trackedPlayerID)
	{
		return EFactionRelationType.Friendly;
	}

	public static bool CheckSameTeam(Player p1, Player p2)
	{
		return false;
	}

	public static NKMCHIMCOHK CurrentLocalFixedObserverEntity()
	{
		return null;
	}

	public static float GetRevisedValueByFPS(float v, float deltaTime)
	{
		return 0f;
	}

	public static float GetRevisedValueBySystemFPS(float v)
	{
		return 0f;
	}

	public static bool IsOnlineGame()
	{
		return false;
	}

	public static bool Send(uint messageID, UDPClientMessageBase msg, byte sendOption = 0, bool cacheMsgAnyWay = false)
	{
		return false;
	}

	public static MatchGameClient CurretOnlineMatchClient()
	{
		return null;
	}

	public static void DoCache(ICollection<ResourceID> rids, int insID = 268435455, ResourceManager.LoadPriority priority = ResourceManager.LoadPriority.Normal, bool preload = false, int instCount = -1)
	{
	}

	public static void DoCache(ResourceID rid, int insID = 268435455, ResourceManager.LoadPriority priority = ResourceManager.LoadPriority.Normal, bool preload = false, int instCount = -1)
	{
	}

	public static void UnCache(ICollection<ResourceID> rids, int insID = 268435455)
	{
	}

	public static bool IsCabinWaitingGame()
	{
		return false;
	}

	public static ResourceID GetRealPlayAudio(ResourceID rid)
	{
		return default(ResourceID);
	}

	public static void GetRealPlayAudios(ref ICollection<ResourceID> rids)
	{
	}

	public static float CurrentTotalServerTime()
	{
		return 0f;
	}

	public static float CurrentServerTime()
	{
		return 0f;
	}

	public static float CurrentServerDeltaTime()
	{
		return 0f;
	}

	public static uint CurrentServerTick()
	{
		return 0u;
	}

	public static uint CurrentGameTick()
	{
		return 0u;
	}

	public static uint CurrentGameRealDoLogicTick()
	{
		return 0u;
	}

	public static CameraControllerManager CurrentCameraControllerManager()
	{
		return null;
	}

	public static void EventsPopupDone()
	{
	}

	public static bool CanShowLobbyTaskEntry()
	{
		return false;
	}

	public static bool CheckIceWallMakerState()
	{
		return false;
	}

	public static void SetEnabelIceWallMaker(bool enable)
	{
	}

	public static bool CheckGamePlayOpen(MHGIGDEFCKM id)
	{
		return false;
	}

	public static void SyncBloodOptionConfig()
	{
	}

	public static BloodConfigType GetCurrentBloodConfigType()
	{
		return BloodConfigType.No;
	}

	public static bool NeedShowBloodOption()
	{
		return false;
	}

	public static BloodType GetCurrentBloodType(bool pcIgnoreBloodSwitch = false)
	{
		return BloodType.NoBlood;
	}

	public static bool IsIndiaNoblood()
	{
		return false;
	}

	public static ResourceID GetNoBloodResourceID(ResourceID originalRes)
	{
		return default(ResourceID);
	}

	public static void TrySetNoBloodSprite(UISprite sprite)
	{
	}

	public static BloodType GetCurrentSafeZoneDmgEffectType(bool pcIgnoreBloodSwitch = false)
	{
		return BloodType.NoBlood;
	}

	public static void SetCurrentBloodType(BloodType bloodType)
	{
	}

	public static bool GetBloodVisibility()
	{
		return false;
	}

	public static bool GetSafeZoneDmgEffectVisibility()
	{
		return false;
	}

	public static void SetBloodVisibility(bool visibility)
	{
	}

	public static void SetSafeZoneDmgEffectVisibility(bool visibility)
	{
	}

	public static void LoadMPBattleGame(EMPConnectionType connType)
	{
	}

	private static void SetUGCGameDataUrlBySocialArea()
	{
	}

	public static HttpRequest SendServerRequest<TRes>(string url, string cmd, object data, Action<HttpErrorCode, object> onFinished, float timeout = 0f, uint http_option = 0u, bool encrypt = true, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, int urgentAfterIndex = -1, bool sendImmediately = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, Action OnDeserialize = null)
	{
		return null;
	}

	public static void ReportNetworkMetricEvent(NetworkMetricEvent networkMetricEvent, string network_detail = "", uint gameMode = 0u, uint matchMode = 0u, uint mapID = 0u, uint groupMode = 0u)
	{
	}

	public static bool IsCurrentGameMode(uint gamemode, bool gamemodeNoneFilter)
	{
		return false;
	}

	public static bool IsCasualMatch()
	{
		return false;
	}

	public static bool IsCSRanking()
	{
		return false;
	}

	public static bool IsBRRanking()
	{
		return false;
	}

	public static bool IsFuncAliveLoadingShowPlayerInfo()
	{
		return false;
	}

	public static bool IsFuncAliveBRLoadingShowPlayerInfo()
	{
		return false;
	}

	public static bool IsFuncAliveCSPeakLoadingShowPlayerInfo()
	{
		return false;
	}

	public static bool DoesLoadingShowPlayerInfo()
	{
		return false;
	}

	public static bool IsPeriodicRanking()
	{
		return false;
	}

	public static bool IsCustomRoom()
	{
		return false;
	}

	public static bool IsCustomRoomCasual()
	{
		return false;
	}

	public static bool IsCustomRoomLeague()
	{
		return false;
	}

	public static bool IsCustomRoomWorkshop()
	{
		return false;
	}

	public static bool IsCustomRoomNotWorkshop()
	{
		return false;
	}

	public static bool IsCustomRoomObserver()
	{
		return false;
	}

	public static bool IsSpectatorOrCreator()
	{
		return false;
	}

	public static bool DuringKillCam()
	{
		return false;
	}

	public static bool DuringEighthLand()
	{
		return false;
	}

	public static bool IsRoomSpectator()
	{
		return false;
	}

	public static bool IsRoomOBFreeCamEnabled()
	{
		return false;
	}

	public static bool IsRoomOBUsingSingleItem()
	{
		return false;
	}

	private static bool IsCurrentGameModeInConfigList(string config)
	{
		return false;
	}

	public static bool IsObserverLikeRole()
	{
		return false;
	}

	public static bool IsWorkShopShowFeedBackQuit()
	{
		return false;
	}

	public static bool IsWorkShopDebugModeQuit()
	{
		return false;
	}

	public static bool IsBattleRoomType()
	{
		return false;
	}

	public static bool IsCSLikePreparePhase()
	{
		return false;
	}

	public static bool IsWaitingCabinPhase()
	{
		return false;
	}

	public static bool NeedShowSkillEffect(BHGGAEEHJCO skillOwnerOrEffectTaker)
	{
		return false;
	}

	public static bool NeedShowSkillEffect(Player skillOwnerOrEffectTaker)
	{
		return false;
	}

	private static bool NeedShowSkillEffectV2(Player skillOwnerOrEffectTaker)
	{
		return false;
	}

	public static bool IsInvisibleInCabinWaitingPhase(Player player)
	{
		return false;
	}

	public static bool IsBattleRoyale()
	{
		return false;
	}

	public static bool IsBRTutorialTaskEnabled()
	{
		return false;
	}

	private static bool IsFormalBRTutorialTaskEnabled()
	{
		return false;
	}

	private static bool IsBRTutorialTaskMatchModeEnabled()
	{
		return false;
	}

	private static bool IsWithinBRTutorialTaskPlayerLevel()
	{
		return false;
	}

	private static bool IsWithinBRTutorialTaskRank()
	{
		return false;
	}

	public static bool IsBrScoreBoardNeeded()
	{
		return false;
	}

	public static bool IsTutorialBR()
	{
		return false;
	}

	public static bool IsTutorialCS()
	{
		return false;
	}

	public static bool IsSpeedMode()
	{
		return false;
	}

	public static bool IsPVEMatch()
	{
		return false;
	}

	public static bool EnablePveWeaponSkinProperty()
	{
		return false;
	}

	public static bool UGCDisableEnemyFootstepVibrate()
	{
		return false;
	}

	public static bool EnableOnBoardFlight()
	{
		return false;
	}

	public static bool IsGameAllowFlight()
	{
		return false;
	}

	public static bool IsGameShowAllFlight()
	{
		return false;
	}

	public static bool UseNewDeathCamera()
	{
		return false;
	}

	public static bool IsCSMode()
	{
		return false;
	}

	public static bool CheckGameModeIsCS(uint gameMode)
	{
		return false;
	}

	public static bool IsFPPCSMode()
	{
		return false;
	}

	public static bool IsCSPeakMode()
	{
		return false;
	}

	public static bool NeedShowScoreGameMode()
	{
		return false;
	}

	public static bool IsClanWarMode()
	{
		return false;
	}

	public static bool IsClanWarChampionshipMode()
	{
		return false;
	}

	public static bool IsClanWarOrTournament()
	{
		return false;
	}

	public static bool IsShowBRAceTeamIcon()
	{
		return false;
	}

	public static bool IsMetropolisMode()
	{
		return false;
	}

	public static bool IsFateRandomMode()
	{
		return false;
	}

	public static bool IsFightClubMode()
	{
		return false;
	}

	public static bool IsLoneWolfSpecialMode()
	{
		return false;
	}

	public static bool IsLoneWolfMultiMode()
	{
		return false;
	}

	public static bool IsFateRoyaleMode()
	{
		return false;
	}

	public static bool IsFateRoyaleFastMode()
	{
		return false;
	}

	public static bool IsTKMode()
	{
		return false;
	}

	public static bool IsTDMMode()
	{
		return false;
	}

	public static bool IsTokenMode()
	{
		return false;
	}

	public static bool IsGiantMode()
	{
		return false;
	}

	public static bool IsOnlyShowOneWeapon()
	{
		return false;
	}

	public static bool IsArmsRaceMode()
	{
		return false;
	}

	public static bool IsArmsRaceTeamMode()
	{
		return false;
	}

	public static bool IsReaperMode()
	{
		return false;
	}

	public static bool IsBombMode()
	{
		return false;
	}

	public static bool IsBombQuadMode()
	{
		return false;
	}

	public static bool IsTrainingMode()
	{
		return false;
	}

	public static bool IsEnableInviteInGamePlayerSwitchOpen()
	{
		return false;
	}

	public static bool IsEnableInviteInGamePlayerSwitchOpen(uint gameMode, uint matchMode)
	{
		return false;
	}

	public static bool IsEnableMatchResultInviteSwitchOpen(uint gameMode, uint matchMode)
	{
		return false;
	}

	private static bool ParseGameModeAndMatchMode(string content, uint gameMode, uint matchMode)
	{
		return false;
	}

	public static bool IsTrainingGame()
	{
		return false;
	}

	public static bool IsHippoCrisisMode()
	{
		return false;
	}

	public static bool IsHippoCrisisTutorialMode()
	{
		return false;
	}

	public static bool IsTrainingOrSocialArea()
	{
		return false;
	}

	public static bool IsOfflineTrainingMode()
	{
		return false;
	}

	public static bool IsSocialMode()
	{
		return false;
	}

	public static bool IsForceTutorialGameMode()
	{
		return false;
	}

	public static bool IsSinglePlayerGame()
	{
		return false;
	}

	public static bool IsNoPlayDeadGameMode()
	{
		return false;
	}

	public static bool IsPartyMode()
	{
		return false;
	}

	public static bool IsHypeRelatedMode()
	{
		return false;
	}

	public static bool IsZombiePlusMode()
	{
		return false;
	}

	public static bool IsHypeMode()
	{
		return false;
	}

	public static bool IsSnowManMode()
	{
		return false;
	}

	public static bool IsNightHunterMode()
	{
		return false;
	}

	public static bool IsRushHourMode()
	{
		return false;
	}

	public static bool IsIgnoreMultiTeamFlightMode()
	{
		return false;
	}

	public static bool IsFourSymbolsMode()
	{
		return false;
	}

	public static bool IsSnowManModeBattleGame()
	{
		return false;
	}

	public static bool IsBigHeadMode()
	{
		return false;
	}

	public static bool IsAttackOnHeadMode()
	{
		return false;
	}

	public static bool IsDGGMode()
	{
		return false;
	}

	public static bool IsControlMode()
	{
		return false;
	}

	public static bool IsCSStrikeOutMode()
	{
		return false;
	}

	public static bool IsTeamCsMode()
	{
		return false;
	}

	public static bool IsBanknoteMode()
	{
		return false;
	}

	public static bool IsADSMode()
	{
		return false;
	}

	public static bool IsWereWolvesMode()
	{
		return false;
	}

	public static bool IsRushingPetsMode()
	{
		return false;
	}

	public static bool IsWorkshopMap()
	{
		return false;
	}

	public static bool IsWorkshopMap(uint mapId, uint gameMode)
	{
		return false;
	}

	public static bool IsNeedPrewarmEnumParse()
	{
		return false;
	}

	public static bool IsWorkshopMap(uint mapID)
	{
		return false;
	}

	public static bool IsUGCPartyMode()
	{
		return false;
	}

	public static bool IsLWSOMode()
	{
		return false;
	}

	public static bool IsFlagBattleMode()
	{
		return false;
	}

	public static bool IsPVEInfiniteMode()
	{
		return false;
	}

	public static bool IsUGCCommonMode()
	{
		return false;
	}

	public static bool IsUGCCommonMode(uint gameMode)
	{
		return false;
	}

	public static bool IsNewPGCMode()
	{
		return false;
	}

	public static bool IsNewPGCMode(uint gameMode)
	{
		return false;
	}

	public static bool IsUGCPVETtemplate(int gsModeTemplateID)
	{
		return false;
	}

	public static bool IsPDMMode()
	{
		return false;
	}

	public static bool IsHuntingGround()
	{
		return false;
	}

	public static bool IsHuntingGroundSnow()
	{
		return false;
	}

	public static bool IsUGCInfectionMode()
	{
		return false;
	}

	public static bool HasShopItemReinforce()
	{
		return false;
	}

	public static bool IsTeammateOfSameFaction()
	{
		return false;
	}

	public static bool IsSkyDivingRevive()
	{
		return false;
	}

	public static bool IsLowFallingRevive()
	{
		return false;
	}

	public static bool IsPlayerReadyNeedDelay()
	{
		return false;
	}

	public static bool GameModeSupportRevive()
	{
		return false;
	}

	public static bool GameModeCanChangeSkills()
	{
		return false;
	}

	public static bool GameModeSupportChangeTeam()
	{
		return false;
	}

	public static bool GameModeSupportChangeTeam(uint gameMode)
	{
		return false;
	}

	public static bool EnableOptimizeParachuteProcess()
	{
		return false;
	}

	public static bool EnableOptimizeParachuteProcessV2()
	{
		return false;
	}

	public static float GetSkyDivingMinVSpeed()
	{
		return 0f;
	}

	public static float GetSkyDivingMaxVSpeed()
	{
		return 0f;
	}

	public static float GetSkyDivingMinHSpeed()
	{
		return 0f;
	}

	public static float GetSkyDivingMaxHSpeedRatio()
	{
		return 0f;
	}

	public static float GetSkyDivingMaxHSpeed()
	{
		return 0f;
	}

	public static float GetSkySurfingMinVSpeed()
	{
		return 0f;
	}

	public static float GetSkySurfingMaxVSpeed()
	{
		return 0f;
	}

	public static float GetSkySurfingMinHSpeed()
	{
		return 0f;
	}

	public static float GetSkySurfingMaxHSpeed()
	{
		return 0f;
	}

	public static float GetParachutingMinHSpeed()
	{
		return 0f;
	}

	public static float GetParachutingMaxHSpeed()
	{
		return 0f;
	}

	public static float GetParachutingMinVSpeed()
	{
		return 0f;
	}

	public static float GetParachutingMaxVSpeed()
	{
		return 0f;
	}

	public static bool IsFootballMatch()
	{
		return false;
	}

	public static bool EnableCheckButtonPressedDirty()
	{
		return false;
	}

	public static void SetFrameRate(EHighFPS FrameRateLevel)
	{
	}

	public static int GetFrameRate()
	{
		return 0;
	}

	public static bool IsNoSafeZone()
	{
		return false;
	}

	public static bool IsNoJumping()
	{
		return false;
	}

	public static bool IsGameSafeZoneIgnoreFirstOne()
	{
		return false;
	}

	public static bool ShowGuideToSafeZone()
	{
		return false;
	}

	public static InGameCutsceneManager CurrentInGameCutsceneManager()
	{
		return null;
	}

	public static void RegisterInGameCutsceneManager(InGameCutsceneManager manager)
	{
	}

	public static void PlayUIBlackMaskAnim(EMaskAnimType animType, float fadeDuration, float lightDuration, float stableDuration, bool disableMaskAfterFinished = true)
	{
	}

	public static bool IsBossByType(BMLKMJHLEDP aiType)
	{
		return false;
	}

	public static bool IsUnlimitedAmmo()
	{
		return false;
	}

	public static bool IsUnlimitedGloowall()
	{
		return false;
	}

	public static bool IsUnlimitedThrowables()
	{
		return false;
	}

	public static bool IsFateRoyalMode(uint mode)
	{
		return false;
	}

	public static void HasPlayedFirstGame()
	{
	}

	public static void PlayFirstGame()
	{
	}

	public static void HasFirstGameLand()
	{
	}

	public static void FirstGameLand()
	{
	}

	public static void UpdateOpeningMovieRegion()
	{
	}

	public static bool IsOpeningMovieRegionEnabled()
	{
		return false;
	}

	public static float GetFakePingInRegion()
	{
		return 0f;
	}

	public static bool IsSonoranMap()
	{
		return false;
	}

	public static bool IsParadiseNeoMap()
	{
		return false;
	}

	public static bool IsParadiseMap()
	{
		return false;
	}

	public static bool IsRushBBombMap()
	{
		return false;
	}

	public static List<COW.GamePlay.KCIPKBBMIOJ> GetArmsRaceInfo()
	{
		return null;
	}

	public static ResourceID GetWeaponIconByArmsLevel(int armsLevel)
	{
		return default(ResourceID);
	}

	public static bool NeedSyncInfoInTrainingMode(BHGGAEEHJCO fromPlayerID)
	{
		return false;
	}

	public static bool NeedSyncInfoInTrainingMode()
	{
		return false;
	}

	public static bool IsTrainingSubZone(NADDEMMBAJF z)
	{
		return false;
	}

	public static void SetUIRootOnAwake(Action<UIRoot> onAwake)
	{
	}

	public static FNIFJFFGDDO GetSinglePlayerForceTutorialGame()
	{
		return null;
	}

	public static bool IsSinglePlayerForceTutorialGame()
	{
		return false;
	}

	public static bool IsUGCOfflineGame()
	{
		return false;
	}

	public static LCPPIJOHKBG GetSingleplayerCollectionTrialGame()
	{
		return null;
	}

	public static bool IsSinglePlayerCollectionTrialGame()
	{
		return false;
	}

	public static bool IsBountGameIgnoreOneShotSound()
	{
		return false;
	}

	public static void LoadAndRunSinglePlayerGameBountyWaiting()
	{
	}

	public static UIRushingPetsGameScene GetRushingPetsGameUIScene()
	{
		return null;
	}

	public static MultiplePlayerWereWolvesGame GetWereWolvesGame()
	{
		return null;
	}

	public static UIWereWolvesGameScene GetWereWolvesGameUIScene()
	{
		return null;
	}

	public static PlayerWereWolves GetLocalWereWolvesPlayer()
	{
		return null;
	}

	public static WereWolvesBodyManager GetWereWolvesBodyManager()
	{
		return null;
	}

	public static Color GetWereWolveColorByIndex(int index)
	{
		return default(Color);
	}

	public static WereWolvesRoleData GetWereWolveRoleInfoByIndex(int index)
	{
		return null;
	}

	public static JMJGFNCIPMI GetWereWolvesGameOverState()
	{
		return JMJGFNCIPMI.EWereWolvesGameOverState_NoOver;
	}

	public static CDJJBJOBOKM GetWereWolvesGameMatchEndInfo()
	{
		return null;
	}

	public static WolfTrapManager CurrentWolfTrapManager()
	{
		return null;
	}

	public static DHLFCEHOPHH GetHealRobotXRayManager()
	{
		return null;
	}

	public static int GetWereWolveVoteCenterCDEndTimeMS()
	{
		return 0;
	}

	public static JNPKEGLIEPC GetSpeedScaleGroupInfo()
	{
		return null;
	}

	public static MPHKHODEACE GetPoteniallyVisibleSetManager()
	{
		return null;
	}

	public static bool IsShowPlayerDeadPopMsg()
	{
		return false;
	}

	public static bool IsPlayerEnterPendingReviveNeedHideModel()
	{
		return false;
	}

	public static bool IsShowGodUI()
	{
		return false;
	}

	public static bool IsEmulator()
	{
		return false;
	}

	public static bool IsGameNeedCheckObserverMatchEnd()
	{
		return false;
	}

	public static bool IsTimeHandleTeamParachuteMarkChat()
	{
		return false;
	}

	public static ResourceID GetUGCMoveTemplateCSVResID(uint mapID)
	{
		return default(ResourceID);
	}

	public static UILoadingController GetLoadingController()
	{
		return null;
	}

	public static UIReloadingController GetReloadingController()
	{
		return null;
	}

	public static UGCEntityDataStore GetUGCEntityDataStore()
	{
		return null;
	}

	public static void DispatchUGCEvent(string entityID, long eventType, object[] param = null)
	{
	}

	public static UGCRuntime GetUGCClientRuntime()
	{
		return null;
	}

	public static FJEEGHOAKOG GetUGCBridge()
	{
		return null;
	}

	public static FJEEGHOAKOG GetUGCGame(bool includeSceneEditGame = false, bool includeSocialGame = true)
	{
		return null;
	}

	public static bool IsInGameUGCSocial()
	{
		return false;
	}

	public static bool EnableSocialFriendList()
	{
		return false;
	}

	public static bool EnableSocialDialogBox()
	{
		return false;
	}

	public static bool EnableSocialPlayerDetail()
	{
		return false;
	}

	public static int GetLastPing()
	{
		return 0;
	}

	public static IUGCModuleTransform GetUGCTransformManager()
	{
		return null;
	}

	public static UGCCommerceIAPModule GetUGCCommerceIAPModule()
	{
		return null;
	}

	public static UGCPropertyFormulaMgr GetUGCPropertyFormulaMgr()
	{
		return null;
	}

	public static UGCHostilityModule GetUGCHostilityModule()
	{
		return null;
	}

	public static IUGCModuleArchTypeMgr GetUGCArchTypeMgr()
	{
		return null;
	}

	public static UGCRunnerManager GetUGCRunnerMgr()
	{
		return null;
	}

	public static UGCHardCodeManager GetUGCHardCodeMgr()
	{
		return null;
	}

	public static void SendUGCChannelEvent(int evtType, string channelID, string userID)
	{
	}

	public static void JoinVoiceRoom(CMDBIPLGLGA groupMode, ulong voiceId, bool is_for_loading = false, RoomInfo.EVoiceJoinScene join_scene = RoomInfo.EVoiceJoinScene.Other)
	{
	}

	public static bool DisableInGameUGCVoice()
	{
		return false;
	}

	public static bool TryJoinLobbySocialAreaVoiceRoom(bool is_for_loading = false)
	{
		return false;
	}

	public static bool TryJoinLobbySocialAreaVoiceRoom(out bool didJoinRoom, bool is_for_loading = false)
	{
		didJoinRoom = default(bool);
		return false;
	}

	public static bool NeedJoinRoom(CMDBIPLGLGA groupMode, ulong voiceId, ref string voiceIdStr)
	{
		return false;
	}

	public static bool EnableCasualCustomRoomPrivilegeVoice()
	{
		return false;
	}

	public static bool EnableAreaTalkMode()
	{
		return false;
	}

	public static int GetInGameTokenUnit()
	{
		return 0;
	}

	public static uint GetTreasuryUpgradeCost()
	{
		return 0u;
	}

	public static uint GetTreasuryUpgradeCostByVaultKey(bool hasVaultKey)
	{
		return 0u;
	}

	public static uint GetLocalPlayerTreasuryUpgradeCost()
	{
		return 0u;
	}

	public static ResourceID GetHealEffectResourceId(Player p)
	{
		return default(ResourceID);
	}

	public static T GetWorkshopModeData<T>()
	{
		return default(T);
	}

	public static void TryBuyWeaponInTrainingMode()
	{
	}

	public static EAuth.ClientUsingVersion ClientUsingVersion()
	{
		return EAuth.ClientUsingVersion.ClientUsingVersion_NONE;
	}

	public static bool NeedffantihackEmulatorCheck()
	{
		return false;
	}

	public static bool IsEnemyAtPreparePhase(BHGGAEEHJCO enemyID)
	{
		return false;
	}

	public static void OnSystemScreenShot()
	{
	}

	public static bool IsAtLobby()
	{
		return false;
	}

	public static void TryCloseBigMap()
	{
	}

	public static bool IsPreClose(uint minute)
	{
		return false;
	}

	public static bool IsSideWeapon(NAELPAAELNO item)
	{
		return false;
	}

	public static void AddPreCloseTime(uint value)
	{
	}

	public static Dictionary<BHGGAEEHJCO, Player> LocalUGCFactionMembers()
	{
		return null;
	}

	public static bool IsPlayerInLocalUGCFaction(Player player)
	{
		return false;
	}

	public static string LocalUGCFactionEntityID()
	{
		return null;
	}

	public static string LocalUGCTeamEntityID()
	{
		return null;
	}

	public static bool ShowUGCFactionUI(CHOJPPHABKN param = CHOJPPHABKN.MapInfo)
	{
		return false;
	}

	public static bool ShowUGCTeamUI(FFDLOJGLDMH param = FFDLOJGLDMH.HudName)
	{
		return false;
	}

	public static bool ShowUGCCustomMatchResult()
	{
		return false;
	}

	public static bool IsPlayerInLocalUGCTeam(Player player)
	{
		return false;
	}

	public static bool IsGameEnableDelaySyncAvatarSyncAvatarProperties()
	{
		return false;
	}

	public static void ShowMsgPop(string content, float duration = 2f)
	{
	}

	public static int[] GetSaveInstructItemType()
	{
		return null;
	}

	public static void SetSaveInstructItemType(List<int> types)
	{
	}

	public static bool GetOverrideUnlimitedAmmoSetting()
	{
		return false;
	}

	public static bool IsSpecialUnLimitedAmmo()
	{
		return false;
	}

	public static bool IsHighRankReviveCard(uint cardID)
	{
		return false;
	}

	public static bool IsReviveCard(uint cardID)
	{
		return false;
	}

	public static bool DebugFFI()
	{
		return false;
	}

	public static bool DebugBRAntiAddiction()
	{
		return false;
	}

	public static bool IsInGameRegionRankListEnabled()
	{
		return false;
	}

	public static bool TryGetBattleLevelModule(out NKDHFJHPEFL module)
	{
		module = null;
		return false;
	}

	public static bool CanOpenUI()
	{
		return false;
	}

	public static bool CanOpenFrontendUI()
	{
		return false;
	}

	public static bool NeedShowGlooAirdropGuide()
	{
		return false;
	}

	public static void AlreadyShowGlooAirdropGuide()
	{
	}

	public static string HashStringToFileName(string inputString)
	{
		return null;
	}

	public static bool IsNBOrangeFoxOpen()
	{
		return false;
	}

	public static DJFOLHHFCNM GetAIECAManager()
	{
		return null;
	}

	public static void TryRegisterBotAgentUI(KLDGLAFFLNJ type, UIButton button, bool register)
	{
	}

	public static void TryRegisterBotAgentPinReceiver(bool register, GameObject obj, string actionName, Func<string> runtimeData, bool isCircleHighlight, bool colliderOnlyOnWhenStartReceive = false)
	{
	}

	public static bool IsUseSplitMiniMap()
	{
		return false;
	}

	public static bool CheckCanRankMatch(DLBMPCCFKKM matchMode, bool showTips = true)
	{
		return false;
	}

	public static bool IsGatewayGS()
	{
		return false;
	}

	public static void AddArcGeneratorToMatch(ArcGenerator arc)
	{
	}

	public static ArcGenerator FindArcGeneratorFromMatch(int groupID, int number)
	{
		return null;
	}

	public static void AddSlideDoorManager(SlideDoorManager door)
	{
	}

	public static List<SlideDoorManager> FindSlideDoorManager(uint groupID)
	{
		return null;
	}

	public static void AddSlideColorManager(SlideColorManager mgr)
	{
	}

	public static SlideColorManager GetSlideColorManager()
	{
		return null;
	}

	public static void UpdateSlideEnemyInfo(uint groupID, bool hasEnemy)
	{
	}

	public static bool SlideHasEnemyNearby(uint groupID)
	{
		return false;
	}

	public static void UpdateSlideScanAreaInfo(uint groupID, bool isEnter)
	{
	}

	public static void ClearSlideScanAreaInfo()
	{
	}

	public static void SetEnterSlideScanAreaFlag()
	{
	}

	public static bool CheckEnterSlideScanAreaFlag()
	{
		return false;
	}

	public static bool IsEnterSlideScanArea(uint groupID)
	{
		return false;
	}

	public static SortedList<int, SortedList<int, ArcGenerator>> GetAllArcGenerator()
	{
		return null;
	}

	public static SortedList<int, ArcGenerator> GetArcGeneratorsByGroup(int groupID)
	{
		return null;
	}

	public static Dictionary<int, BezierSlide> GetAllBezierSlides()
	{
		return null;
	}

	public static BezierSlide GetBezierSlideByGroup(int groupID)
	{
		return null;
	}

	public static void AddBezierSlideToMatch(BezierSlide slide)
	{
	}

	public static Transform GetBezierSlideEndNodeByGroup(int groupID, bool isArcPathMoveDirClockwise)
	{
		return null;
	}

	public static void LoadSlideCsvConfig()
	{
	}

	public static Dictionary<uint, SlidePrefabConfig> GetSlidePrefabConfigs()
	{
		return null;
	}

	public static int GetShowGetOffSlideGuideCnt()
	{
		return 0;
	}

	public static void SetShowGetOffSlideGuide()
	{
	}

	public static bool IsFriendOBWithDelay()
	{
		return false;
	}

	public static ulong GetAccountID()
	{
		return 0uL;
	}

	public static float ReconnectTime()
	{
		return 0f;
	}

	public static bool CheckTrainingModeMapNeedDownload(uint gameMode)
	{
		return false;
	}

	public static bool IsSpecialWaitingIsland()
	{
		return false;
	}

	public static uint CurReviveZoneRemainCount()
	{
		return 0u;
	}

	public static uint CurReviveZoneUseMaxCount()
	{
		return 0u;
	}

	public static float CurReviveZoneCloseTime()
	{
		return 0f;
	}

	public static float CurReviveZoneDuration()
	{
		return 0f;
	}

	public static bool IsIngameEighthOpen()
	{
		return false;
	}

	public static EighthLandModelLoadHelper EighthLandModeLoadHelper()
	{
		return null;
	}

	public static EntityVisualEffectManager GetGameVisualEffectManager()
	{
		return null;
	}

	public static ResourceID GetOnBoardPlaneSoundResID()
	{
		return default(ResourceID);
	}

	public static int GetCurGroupModeOneSidePlayerCount(CMDBIPLGLGA groupMode)
	{
		return 0;
	}

	public static ResourceID CurMatchParachutingBGM()
	{
		return default(ResourceID);
	}

	public static bool IsLobbyTakephotoState()
	{
		return false;
	}

	public static bool IsPortraitCloseupTakePhotoState()
	{
		return false;
	}

	public static bool IsProfileTakePhotoState()
	{
		return false;
	}

	public static UITakePhotoController GetLobbyTakephotoCtrl()
	{
		return null;
	}

	public static bool IsSfRoleplayOpen()
	{
		return false;
	}

	public static void PlaySFXAccordingToRole(BHGGAEEHJCO playerID, ResourceID sound, float volumeSelf = 0.9f, float volumeTeammate = 0.9f, float volumeEnemy = 1f, bool lp2D = false)
	{
	}

	public static bool IsAttachmentInValidForReinforcedWeapon(GIANNEDDMLL type, NAELPAAELNO item)
	{
		return false;
	}

	public static DGGAKDCKJPP GetWinterLand25MatchManager()
	{
		return null;
	}

	public static NOAPGJAIOBB GetCarni25GPManager()
	{
		return null;
	}

	public static bool IsCarni25GPOpen()
	{
		return false;
	}

	public static bool IsCarni25CSOpen()
	{
		return false;
	}

	public static bool IsWinterLand25Open()
	{
		return false;
	}

	public static bool IsWinterLand25SkateboardOpen()
	{
		return false;
	}

	public static bool IsTreasureHuntOpen()
	{
		return false;
	}

	public static bool IsGB_GPOpen()
	{
		return false;
	}

	public static bool IsNinthGPCabinTipsOpen()
	{
		return false;
	}

	public static bool IsBloodmoonGPOpen()
	{
		return false;
	}

	public static bool IsLoneWolfCasualMode()
	{
		return false;
	}

	public static bool IsLoneWolfCasualSoloMode()
	{
		return false;
	}

	public static bool IsLoneWolfCasualDualMode()
	{
		return false;
	}

	public static bool IsSpecialPickupEffect()
	{
		return false;
	}

	public static bool IsLocalTargetInLikeIIV1v1BattleScene()
	{
		return false;
	}

	public static bool IsRelatedWeaponIDSwitch()
	{
		return false;
	}

	public static bool IsFullScreenPreviewRelatedUI()
	{
		return false;
	}

	public static void SendDropMatchToService()
	{
	}

	public static bool IsSoloGroupMode()
	{
		return false;
	}

	public static bool IsMobileReplayJumping()
	{
		return false;
	}

	public static bool IsLobbyVerticalPreviewAvatar()
	{
		return false;
	}

	public static bool IsModifierAvailable(COIMGCDMDCC modify)
	{
		return false;
	}

	public static bool IsReplayJumping()
	{
		return false;
	}
}
