using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugConsoleController : UIPopupWindowController
{
	public enum CmdType
	{
		NoArg,
		Arg1,
		Arg2,
		Arg3,
		ArgPopup2,
		Toggle,
		ToggleArgs,
		Arg4,
		ToggleSlider
	}

	public enum LoadPrefabType
	{
		Login,
		Lobby,
		Mall,
		Cutscene,
		WeaponPreview
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__219_0;

		public static Converter<int, string> _003C_003E9__223_0;

		public static Action _003C_003E9__233_0;

		public static Converter<CSVBaseData, PlatformPromotionProductsData> _003C_003E9__241_0;

		internal void _003CLoadSinglePlayerForceTutorialGame_003Eb__219_0()
		{
		}

		internal string _003CChangeLanguage_003Eb__223_0(int lang)
		{
			return null;
		}

		internal void _003CTestBigEventLobbyIcon_003Eb__233_0()
		{
		}

		internal PlatformPromotionProductsData _003COnDebugExchangeProdution_003Eb__241_0(CSVBaseData temp)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass193_0
	{
		public UIDebugConsoleToggleArgs item;

		public UIDebugConsoleController _003C_003E4__this;

		internal void _003CInitCmdTemplate_003Eb__14(string cmd, bool togglevalue, object[] args)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass193_1
	{
		public string cmd;

		public _003C_003Ec__DisplayClass193_0 CS_0024_003C_003E8__locals1;

		internal void _003CInitCmdTemplate_003Eb__15(string c, bool t, object[] a)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass196_0
	{
		public UIPopupMessageBoxController quitDialog;

		internal void _003CRunCmd_003Eb__0()
		{
		}

		internal void _003CRunCmd_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass222_0
	{
		public List<ServerSettingsData> serverSettings;

		public UIDebugConsoleController _003C_003E4__this;

		internal void _003CChangeServer_003Eb__0(string server)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass223_0
	{
		public List<int> langList;

		public UIDebugConsoleController _003C_003E4__this;

		internal void _003CChangeLanguage_003Eb__1(string langName)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass234_0
	{
		public string DEBUG_GRAPH_ID;

		internal bool _003COnCustomCmdRunClick_003Eb__0(GraphData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass234_1
	{
		public string DEBUG_GRAPH_ID;

		internal bool _003COnCustomCmdRunClick_003Eb__1(GraphData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass234_2
	{
		public UIModelLobbySocial model;

		internal void _003COnCustomCmdRunClick_003Eb__2(bool success)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass244_0
	{
		public double latitude;

		public double longitude;

		internal void _003CCheckCustomCmd_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003CAudioFullPlayTestCoroutine_003Ed__257 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDebugConsoleController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAudioFullPlayTestCoroutine_003Ed__257(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIDebugConsoleView m_View;

	private bool m_DebugInfoState;

	public static bool s_InitNotchDebugButton;

	public static bool s_ToggleSnowMode;

	private static GameObject m_loadPrefabGo;

	private static List<UIMaleAvatar> m_teammateFemaleList;

	private static List<UIMaleAvatar> m_teammateMaleList;

	public static bool IsDebugMessage;

	private const string Cmd_Offline = "Offline";

	private const string Cmd_DebugLogin = "DebugLogin";

	private const string Cmd_PCSelectServer = "PCSelectServer";

	private const string Cmd_SoloTestBattleA = "SoloTestBattleA";

	private const string Cmd_SoloTestBattleB = "SoloTestBattleB";

	private const string Cmd_SoloTestBattleC = "SoloTestBattleC";

	private const string Cmd_SoloTestBattleNEO = "SoloTestBattleNEO";

	private const string Cmd_SoloTestBattleNEOMAX = "SoloTestBattleNeoMax";

	private const string Cmd_SoloOfflineBattle = "SoloOfflineGame";

	private const string Cmd_MSAA_OFF = "MSAAOff";

	private const string Cmd_MSAA_2X = "MSAA2X";

	private const string Cmd_MSAA_4X = "MSAA4X";

	private const string Cmd_SwitchVFXTestCase = "SwitchVFXTestCase";

	private const string Cmd_SparkPet = "SparkPet";

	private const string Cmd_ColliderDebug = "Collider Debug";

	private const string Cmd_MultiParadise = "MultiParadise";

	private const string Cmd_MultiAzores = "MultiAzores";

	private const string Cmd_Wating = "Wating";

	private const string Cmd_SetNickName = "NickName";

	private const string Cmd_MultiGame = "MultiGame";

	private const string Cmd_JoinAsFriendOB = "JoinAsFriendOB";

	private const string Cmd_ShowJira = "ShowJira";

	private const string Cmd_ShowLobbyWeather = "ShowLobbyWeather";

	private const string Cmd_SingleGame = "SingleGame";

	private const string Cmd_SingleGamePopup = "SingleGamePopup";

	private const string Cmd_TestParadiseLabelBase = "TestParadiseLabelBase";

	private const string Cmd_TestParadiseLabelExchangeA = "TestParadiseLabelExchangeA";

	private const string Cmd_TestParadiseLabelExchangeB = "TestParadiseLabelExchangeB";

	private const string Cmd_CustomSingleGame = "CustomSingleGame";

	private const string Cmd_Room = "Room";

	private const string Cmd_AIObserver = "AIObserver";

	private const string Cmd_SetAITrainingGS = "SetAITrainingGS";

	private const string Cmd_TutorialGame = "TutorialGame";

	private const string Cmd_Cloth = "Cloth";

	private const string Cmd_LDWhiteBox = "LDWhiteBox";

	private const string Cmd_SetGS = "SetGS";

	private const string Cmd_SetOnlineGS = "SetOnlineGS";

	private const string Cmd_SetGatewayGS = "SetGatewayGS";

	private const string Cmd_SetDebugSamoAI = "SetSamoAI";

	private const string Cmd_DebugSetPrimeTestData = "PrimeActivityTest";

	private const string Cmd_GyroSettings = "GyroSettings";

	private const string cmd_OptionSimulate = "OptionSimulate";

	private const string Cmd_HDAnimationOB54Simulate = "HDAnimOB54";

	private const string Cmd_TestMode = "SetTestMode";

	private const string Cmd_Notch = "Notch";

	private const string Cmd_ChangeServer = "ChangeServer";

	private const string Cmd_LobbyBGSwitch = "LobbyBGSwitch";

	private const string Cmd_BountyWaiting = "BountyWaiting";

	private const string Cmd_Monopoly = "Monopoly";

	private const string Cmd_ChangeLanguage = "ChangeLanguage";

	private const string Cmd_ShowTestBtn = "ShowTestBtn";

	private const string Cmd_ShowPreviewToolBtn = "ShowPreviewToolBtn";

	private const string Cmd_ShowLabelParam = "ShowLabelParam";

	private const string Cmd_LocStyleSwitch = "LocStyleSwitch";

	private const string Cmd_WereWholves = "WereWholves";

	private const string Cmd_SingleWereWholves = "SingleWereWholves";

	private const string Cmd_CupMatchFaction = "CupMatchFaction";

	private const string Cmd_CupMatchCourse = "CupMatchCourse";

	private const string Cmd_CupMatchChampion = "CupMatchChampion";

	private const string Cmd_CupMatchReward = "CupMatchReward";

	private const string Cmd_Navigate = "Navigate";

	private const string Cmd_PlayerprefDeleteAll = "PlayerprefDeleteAll";

	private const string Cmd_PrintCompatibleInfo = "PrintCompatibleInfo";

	private const string Cmd_EnableDebugUpload = "EnableDebugUpload";

	private const string CMD_BetterListUsePool = "BetterListUsePool";

	private const string CMD_DebugQuickMatch = "DebugQuickMatch";

	private const string Cmd_SetDevId = "SetDevId";

	private const string Cmd_ResetIngameTutorial = "ResetIngameTutorial";

	private const string Cmd_Replay = "Replay";

	private const string Cmd_KillCamDump = "KillCamDump";

	private const string Cmd_OpenProxy = "Proxy";

	private const string Cmd_LivePay = "LivePay";

	private const string Cmd_ClearIconCDNCachce = "ClearCDNCache";

	private const string Cmd_AutoClear = "AutoClear";

	private const string Cmd_RunUGC = "UGCEditMode";

	private const string Cmd_SetUGCParams = "SetUGCParams";

	private const string Cmd_VeteranReturn = "VeteranReturn";

	private const string Cmd_LobbyRepop = "LobbyRepop";

	private const string Cmd_TestBigEventLobbyIcon = "TestBigEventLobbyIcon";

	private const string Cmd_ReturnRepop = "ReturnRepop";

	private const string Cmd_CopyPlatformInfo = "CopyPlatformInfo";

	private const string Cmd_DebugPlatformLogin = "DebugPlatformLogin";

	private const string Cmd_TutorialBR = "TutorialBR";

	private const string Cmd_DebugPlatformProductionExchange = "DebugPlatformProductionExchange";

	private const string Cmd_TutorialCS = "TutorialCS";

	private const string Cmd_LegentClothVault = "LegentClothVault";

	private const string Cmd_ResetTutorial = "ResetTutorial";

	private const string Cmd_LobbyAutoTaskPop = "LobbyAutoTaskPop";

	private const string Cmd_ToggleTcp = "ToggleTcp";

	private const string Cmd_ResetGuest = "ResetGuest";

	private const string Cmd_3pPosLog = "3pSyncPosLog";

	private const string Cmd_PreDropMatch = "PreDropMatch";

	public const string KeyLobbyAutoTaskPop = "KeyLobbyAutoTaskPop";

	private const string Cmd_SkipTutorialBR = "SkipTutorialBR";

	public const string KeySkipTutorialBR = "KeySkipTutorialBR";

	public const string Key3pPosLog = "Key3pPosLog";

	public const string KeyPreDropMatchBeforeJoin = "KeyPreDropMatchBeforeJoin";

	private const string Cmd_NewPreviewTest = "NewPreviewTest";

	private const string Cmd_HideClientDamage = "HideClientDamage";

	public const string Cmd_AutoAddPlayer = "AutoAddPlayer";

	private const string Cmd_AdminCreateRoom = "AdminCreateRoom";

	private const string Cmd_CustomAdminCreateRoom = "CustomAdminCreateRoom";

	private const string Cmd_WeaponTTKGame = "WeaponTTKGame";

	private const string Cmd_IgnoreScreenShotWnd = "IgnoreScreenShotWnd";

	private const string Cmd_PlayerPrefsDeleteAll = "PlayerPrefsDeleteAll";

	private const string KeyIgnoreScreenShotWnd = "KeyIgnoreScreenShotWnd";

	private const string Cmd_Log = "Log";

	private const string Cmd_EnableBackendLog = "EnableBackendLog";

	private const string Cmd_ProfilingUI = "Profiling UI";

	private const string Cmd_EvoGunMain = "EvoGunMain";

	private const string Cmd_DrawShop = "DrawShop";

	private const string Cmd_PhotoWall = "PhotoWall";

	private const string Cmd_CompatibleLogin = "Compatible Login";

	private const string Cmd_LoadPrefab = "LoadPrefab";

	private const string Cmd_RemovePrefab = "RemovePrefab";

	private const string Cmd_ShowLoadPrefabBtn = "ShowLoadPrefabBtn";

	private const string Cmd_PlayWeaponPreviewEffectByName = "PlayWeaponPreviewEffectByName";

	private const string Cmd_FakeTeammate = "FakeTeammate";

	private const string Cmd_ClearFakeTeammate = "ClearFakeTeammate";

	private const string Cmd_PlayEnterTeamAnim = "PlayEnterTeamAnim";

	private const string Cmd_PlayEmoteAnim = "PlayEmoteAnim";

	private const string Cmd_GameAssistantPlayerType = "GameAssistantPlayerType";

	private const string Cmd_ClearGameAssistantPlayerType = "ClearGameAssistantPlayerType";

	private const string Cmd_SetCDNMaxDownloadNum = "SetCDNMaxDownloadNUM";

	private const string Cmd_SetCDNMaxLoadNum = "SetCDNMaxLoadNUM";

	private const string Cmd_DeleteCDNUrl = "DeleteCDNUrlCache";

	private const string Cmd_OldReleaseVersion = "OldReleaseVersion";

	private const string Cmd_DebugFFI = "DebugFFI";

	private const string Cmd_ASRDebugSave = "ASRDebugSave";

	private const string Cmd_DebugBR = "DebugBR";

	private const string Cmd_PlayItemCollectionEffect = "PlayItemCollectinEffect";

	private const string Cmd_PlayItemCollectionEffectGacha = "PlayItemCollectinEffectGacha";

	private const string Cmd_ShowClickLog = "ShowClickLog";

	private const string Cmd_DebugHudHeatmap = "DebugHudHeatmap";

	private const string Cmd_TestGroupAnim = "TestGroupAnim";

	private const string Cmd_TCPClose = "TCPClose";

	private const string Cmd_TCPConnect = "TCPConnect";

	private const string Cmd_AudioVolumeMonitor = "AudioVolumeMonitor";

	private const string Cmd_AudioPlayingInfoMonitor = "AudioPlayingInfoMonitor";

	private const string Cmd_LobbyPingDesc = "LobbyPingDesc";

	private const string Cmd_OpenUnityMobileInfoViewer = "OpenUnityMobileInfoViewer";

	private const string Cmd_ShowTopUpLimit = "ShowTopUpLimit";

	private const string Cmd_SetFakeGSIDCPing = "SetFakeGSIDCPing";

	private const string Cmd_ShowUGCDevDebug = "ShowUGCDevDebug";

	private const string Cmd_SetReadyForPT = "SetReadyForPT";

	private const string Cmd_IMessageSwitch = "IMessage Switch";

	private const string Cmd_OfflineTraining = "OfflineTrainingTest";

	private const string Cmd_TestDeepLink = "TestDeepLink";

	private const string Cmd_DefaultCloth = "ChangeDefaultCloth";

	private const string Cmd_CustomHideUI = "CustomHideUI";

	private const string Cmd_SettingLocalVersionMinus = "Cmd_SettingLocalVersionMinus";

	private const string Cmd_SettingLocalVersionAdd = "Cmd_SettingLocalVersionAdd";

	private const string Cmd_ShowSettingVersion = "Cmd_ShowSettingVersion";

	private const string CMD_StopAllAudio = "StopAllAudio";

	private const string Cmd_AudioFullPlayTest = "AudioFullPlayTest";

	private const string Cmd_ForceTutorialV2 = "ForceTutorialV2";

	private const string Cmd_LevelUpNextLevelAnnounce = "LevelUpNextLevelAnnounce";

	private const string Cmd_OpenHighlightDebugLog = "OpenHighlightDebugLog";

	private const string Cmd_AudioEvt_PlayOneShot = "AudioEvt_PlayOneShot";

	private const string Cmd_SetAppIcon = "SetAppIcon";

	private const string Cmd_ForbidAFK = "ForbidAFK";

	private const string Cmd_PlayMvpAnim = "PlayMvpAnim";

	private const string Cmd_TournamentInvite = "TournamentInvite";

	private const string Cmd_ToggleSnowMode = "ToggleSnowMode";

	private const string Cmd_TestBooyahRating = "TestBooyahRating";

	private const string Cmd_InstantSurvey = "InstantSurvey";

	private const string Cmd_BRMatchReviewByID = "BRMatchReviewByID";

	private const string Cmd_BRMatchReviewSpeedupOff = "BRReviewSpeedupOff";

	private const string Cmd_BRMatchReviewAutoScaleRect = "BRReviewAutoScaleRect";

	private const string Cmd_BRMatchReviewFakeArrowBlack = "BRReviewFakeArrowBlack";

	private const string Cmd_SwitchLoginBG = "SwitchLoginBG";

	private const string Cmd_DancePanel = "DancePanel";

	private const string Cmd_ClaimDanceTitle = "ClaimDanceTitle";

	private const string Cmd_UGCTutorialReset = "UGCTutorialReset";

	private static readonly Dictionary<string, int> m_overwriteQualityData;

	private UILobbyPingDescController m_LobbyPingDescController;

	private UIHudClanGameInfoController m_ClanWarGameInfoCtrl;

	private string audioInfoCsvRPathName;

	private string audioInfoCsvWPathName;

	private bool cmdAudioFullPlayTestState;

	private AudioSource currentAudioSource;

	private float maxWavLen;

	private bool counting;

	private float timer;

	private StreamReader reader;

	private StreamWriter writer;

	private float cmdStartTime;

	private string line;

	public static bool DropMatchBeforeJoinEnabled
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void InitCmdTemplate()
	{
	}

	private void InitCmds()
	{
	}

	public void RunCmdDebugLogin()
	{
	}

	private void RunCmd(string cmd, object[] args)
	{
	}

	private void GotoNewPreviewTest()
	{
	}

	private void OnBtnLoginOfflineClick()
	{
	}

	private void OnBtnIMessageSwitchClick()
	{
	}

	private void OnBtnPCSelectServerClick()
	{
	}

	private void GotoSinglePlayerGame(ulong matchID, uint mapID)
	{
	}

	private void OnBtnEnterGameMGClick(uint matchID, uint mapID)
	{
	}

	private void OnBtnTestSingleplayerGameClick(uint mapID, uint modeID)
	{
	}

	private void OnBtnTestParadiseLabelClick(uint mapID, uint modeID, string label)
	{
	}

	private void OnStartCustomSingleGame()
	{
	}

	private void OnBtnTestMultiplayerGameClick(uint mapID, uint modeID, ulong friendObTrackingUserId, uint mapLayerId = 0u)
	{
	}

	private void OnRoomTestClick(uint mapID, uint modeID)
	{
	}

	private void OnAIObserverTestClick(uint roomID, uint mapID, uint mapLayerId, uint gameMode)
	{
	}

	private void OnBtnTestClothClick()
	{
	}

	private void OnBtnLDWhiteBoxClick()
	{
	}

	private void OnWatingClick()
	{
	}

	private void OnBountyWaitingClick()
	{
	}

	private void OnTutorialGameClick()
	{
	}

	private void SetAntiHackButton()
	{
	}

	private void OnWereWholvesClick()
	{
	}

	private void OnSingleWereWovlesClick()
	{
	}

	private void SetGS(string gsIP, string port)
	{
	}

	private void SetNotch()
	{
	}

	private void LoadSinglePlayerForceTutorialGame()
	{
	}

	private void SetOverMaskShow(bool show)
	{
	}

	private void LobbyBGSwitch()
	{
	}

	private void ChangeServer()
	{
	}

	private void ChangeLanguage()
	{
	}

	private void ShowTestBtn(bool show)
	{
	}

	private void SetPreviewToolBtnVisible(bool show)
	{
	}

	private void ShowLabelParam(bool show)
	{
	}

	private void OnCupMatchFactionClick(string win)
	{
	}

	private void OnCupMatchCouseClick(string result)
	{
	}

	private void OnCupMatchChampionClick()
	{
	}

	private void OnCupMatchRewardClick(string result)
	{
	}

	private void OpenProxy()
	{
	}

	private void OnCopyPlatformInfo()
	{
	}

	private void TestBigEventLobbyIcon()
	{
	}

	private void OnCustomCmdRunClick()
	{
	}

	private void CmdHDAnimationOB54Simulate(string mode)
	{
	}

	private void DeleteHDAnimationPrefs()
	{
	}

	private void ShowHDAnimationCacheStatus(string action)
	{
	}

	private string GetHDAnimationPrefValue(string key)
	{
		return null;
	}

	private void ShowSettingVersion()
	{
	}

	private void OnLocStyleSwitch()
	{
	}

	private void OnDebugExchangeProdution()
	{
	}

	private void ShowPlatformPromotionProductMessageBox()
	{
	}

	private void OnToggleIgnoreScreenShotWndClick(bool isChecked)
	{
	}

	private void CheckCustomCmd(string cmd, string[] args)
	{
	}

	private void SwitchVFXCmd()
	{
	}

	private IEnumerator AudioFullPlayTestCoroutine()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitCmdTemplate_003Eb__193_0()
	{
		return null;
	}

	private void _003CInitCmdTemplate_003Eb__193_9(string cmd)
	{
	}

	private UITable2.IUITable2Item _003CInitCmdTemplate_003Eb__193_1()
	{
		return null;
	}

	private void _003CInitCmdTemplate_003Eb__193_10(string cmd, string arg)
	{
	}

	private UITable2.IUITable2Item _003CInitCmdTemplate_003Eb__193_2()
	{
		return null;
	}

	private void _003CInitCmdTemplate_003Eb__193_11(string cmd, string arg1, string arg2)
	{
	}

	private UITable2.IUITable2Item _003CInitCmdTemplate_003Eb__193_3()
	{
		return null;
	}

	private void _003CInitCmdTemplate_003Eb__193_12(string cmd, string arg1, string arg2)
	{
	}

	private UITable2.IUITable2Item _003CInitCmdTemplate_003Eb__193_4()
	{
		return null;
	}

	private void _003CInitCmdTemplate_003Eb__193_13(string cmd, bool arg1)
	{
	}

	private UITable2.IUITable2Item _003CInitCmdTemplate_003Eb__193_5()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitCmdTemplate_003Eb__193_6()
	{
		return null;
	}

	private void _003CInitCmdTemplate_003Eb__193_16(string cmd, string arg1, string arg2, string arg3, string arg4)
	{
	}

	private UITable2.IUITable2Item _003CInitCmdTemplate_003Eb__193_7()
	{
		return null;
	}

	private void _003CInitCmdTemplate_003Eb__193_17(string cmd, bool arg1, float arg2, Component arg3)
	{
	}

	private UITable2.IUITable2Item _003CInitCmdTemplate_003Eb__193_8()
	{
		return null;
	}

	private void _003CInitCmdTemplate_003Eb__193_18(string cmd, string arg1, string arg2, string arg3)
	{
	}

	private void _003CLoadSinglePlayerForceTutorialGame_003Eb__219_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
