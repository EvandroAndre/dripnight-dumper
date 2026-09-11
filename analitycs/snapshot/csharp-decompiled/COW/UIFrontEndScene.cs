using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using InterApp;
using UnityEngine;
using UnityEngine.Playables;
using proto;

namespace COW;

internal class UIFrontEndScene : UICOWBaseScene
{
	public static class BatteryWatcher
	{
		private static bool? _IsBatteryCharging;

		private static bool _IsBatteryHasCharged;

		private static float _BatteryLevel;

		private static float _BeginBatteryLevel;

		private static float _EndBatteryLevel;

		private static int _LobbyBatteryConsumption;

		private const float BATTERY_LEVEL_UPDATE_THRESHOLD = 0.05f;

		public static bool IsBatteryCharging => false;

		public static float BatteryLevel => 0f;

		public static int LobbyBatteryConsumption => 0;

		internal static void Begin()
		{
		}

		internal static void End()
		{
		}

		public static void OnBatteryChanged(bool charging, float batteryLevel)
		{
		}

		private static void OnBatteryChargingChanged(bool charging)
		{
		}

		private static void OnBatteryLevelChanged(float batteryLevel)
		{
		}
	}

	private class FrontEndSpontaneousMessageHandler : OpenedWithParamsProcessor.ISpontaneousMessageHandler
	{
		private static FrontEndSpontaneousMessageHandler _I;

		public static FrontEndSpontaneousMessageHandler I => null;

		private FrontEndSpontaneousMessageHandler()
		{
		}

		public void OnSpontaneousMessage(Dictionary<string, string> msg, bool isSilent)
		{
		}
	}

	private class DownloadPopupLogContext
	{
		public static readonly DownloadPopupLogContext Empty;

		public EventLogger.ClickType ClickType;

		public string ConfirmClickString;

		public string CancelClickString;

		public string CloseClickString;
	}

	private enum EInviteTipsType
	{
		None,
		GroupInvite,
		Friend,
		JoinGroupRequest
	}

	public class HippoCrisisSplitWndParam
	{
		public IHippoCrisisBackPackItemUIData ItemUIData;

		public EHippoInventory.EquipType SourceEquipType;

		public EHippoInventory.EquipType DstEquipType;

		public EDragReleaseResponseAreaType DstAreaType;

		public EHippoCrisisEquipmentSlot SourceEquipmentSlot;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__84_0;

		public static Action<List<AccountInfoBasic>> _003C_003E9__103_0;

		public static Action _003C_003E9__142_0;

		public static Action _003C_003E9__165_0;

		public static Action _003C_003E9__165_1;

		public static Converter<MapModeData, uint> _003C_003E9__252_0;

		public static Action _003C_003E9__307_0;

		public static UIDebugConsoleCommandItem.OnRunCmd _003C_003E9__322_0;

		internal void _003CProcessOpenedByUrl_003Eb__84_0()
		{
		}

		internal void _003COnDeepLink_FriendInvite_003Eb__103_0(List<AccountInfoBasic> accountInfos)
		{
		}

		internal void _003COnShowDownloadPopupInternal_003Eb__142_0()
		{
		}

		internal void _003CReconnectToMatchAfterLogin_003Eb__165_0()
		{
		}

		internal void _003CReconnectToMatchAfterLogin_003Eb__165_1()
		{
		}

		internal uint _003COnOpenGroup_003Eb__252_0(MapModeData x)
		{
			return 0u;
		}

		internal void _003CShowEmulatorErrorWnd_003Eb__307_0()
		{
		}

		internal void _003CShowDebugBtn_003Eb__322_0(string cmd)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass109_0
	{
		public string share_code;

		public string generation_channel;

		internal void _003COnDeepLink_HudShare_003Eb__0(CSUseHudSettingsShareCodeRes resData)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public object[] data;

		public ResDownloadType type;

		public UIModelOptionalDownload modelOptionalDownload;

		public List<ResourceID> target_id;

		internal void _003COnShowSpeDownloadPopup_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass130_0
	{
		public UIModelFriendObserve modelFriendObserve;

		public UISecondConfirmSmallContoller confirmWnd;

		public uint matchMode;

		public ulong friendAccountID;

		public ulong roomId;

		public uint gameMode;

		internal void _003COnShowFriendObservationPopup_003Eb__0()
		{
		}

		internal void _003COnShowFriendObservationPopup_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass131_0
	{
		public UIModelOptionalDownload model;

		public List<uint> tagList;

		public object[] data;

		public ResDownloadType resType;

		public EventLogger.ClickType clickType;

		public string clickString;

		internal void _003COnShowTagDownloadPopup_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass133_0
	{
		public object[] data;

		public ResDownloadType type;

		internal void _003COnShowNewDownloadPopup_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass142_0
	{
		public UIFrontEndScene _003C_003E4__this;

		public DownloadPopupLogContext logContext;

		public object[] data;

		public List<ResourceID> target_id;

		public UGCSimpleDownloadTask ugcDownloadTask;

		public bool downloadAllResOfGameMode;

		internal void _003COnShowDownloadPopupInternal_003Eb__1()
		{
		}

		internal void _003COnShowDownloadPopupInternal_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass142_1
	{
		public ResDownloadType resType;

		public _003C_003Ec__DisplayClass142_0 CS_0024_003C_003E8__locals1;

		internal void _003COnShowDownloadPopupInternal_003Eb__3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass143_0
	{
		public UIModelOptionalDownload modelOptionalDwonload;

		public UIFrontEndScene _003C_003E4__this;

		public DownloadPopupLogContext logContext;

		public UGCSimpleDownloadTask ugcDownloadTask;

		public List<ResourceID> target_id;

		public bool downloadAllResOfGameMode;

		public object[] data;

		public ResDownloadType resType;

		public UIModelMapOpeningInfo modelMap;

		internal void _003CSocialAreaDownloadAction_003Eb__0()
		{
		}

		internal void _003CSocialAreaDownloadAction_003Eb__1()
		{
		}

		internal void _003CSocialAreaDownloadAction_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass229_0
	{
		public UIFrontEndScene _003C_003E4__this;

		public int width;

		public int height;

		public UINetworkTexture networkTexture;

		public bool needResetLocalScale;

		internal void _003CSetBackground_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass265_0
	{
		public Action cb;

		internal void _003CShowGroupMessageBox_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass330_0
	{
		public string url;

		internal void _003COnQRSacnSecondConfirmWindowOpen_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass336_0
	{
		public UIFrontEndScene _003C_003E4__this;

		public Action onConfirm;

		public UIModelCustomRoom modelCustomRoom;

		internal void _003CStopRoomMatchMaking_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass336_1
	{
		public UIPopupMessageBoxController quitDialog;

		public _003C_003Ec__DisplayClass336_0 CS_0024_003C_003E8__locals1;

		internal void _003CStopRoomMatchMaking_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass96_0
	{
		public UIModelCustomRoom roomModel;

		public ulong roomID;

		public string qr_secret_code;

		internal void _003COnDeepLink_QRCodeRoomInvite_003Eb__0()
		{
		}

		internal void _003COnDeepLink_QRCodeRoomInvite_003Eb__1()
		{
		}
	}

	public Transform OverMaskPanel;

	public Transform UIBGRoot;

	public UITexture BgTexture;

	public GameObject BgEffect;

	public ResourceID BgEffectResId;

	public Animator SpecialBgAni;

	public bool LastPreviewItemUseSpecialRound;

	public UISprite BgDarkMask;

	public Transform Bg2DObjects;

	public UI3DObjectHelper UI3DRootHelper;

	public Camera UI3DCamera;

	public Camera BgCamera;

	public UIPopupMessageBoxController m_MessageBox;

	public UIMatchMakingManager MatchMakingManager;

	private GyroCameraController m_LobbyCamGyro;

	private List<GyroVFXController> m_LobbyVFXGyroList;

	private UICommonPopMenuController m_PopMenuController;

	private UICommonTipsController m_TipsController;

	private UIAvatarWindowController m_AvatarWindowController;

	private UISparkPetAvatarWindowController m_SparkPetAvatarWindowController;

	private UIGameModeMainController m_GameModeMainController;

	public bool OpenedGameModeMainFromNav;

	private UIHighPingTipsBoxController m_HighPingTipsBoxController;

	private UIMicPermissionDenialTipsBoxController m_MicPermissionTipsBoxController;

	private UIAchievementTipsBoxController m_AchievementTipsBoxController;

	private UICommonCountDownBoxController m_CommonCountDownBoxController;

	private UIGachaUnlimitedChestInfoCDNController m_GachaUnlimitedChestInfoCDNController;

	private bool m_IsAutoTaskAchievementDone;

	private bool m_IsOpenHippoCrisisLobby;

	private bool m_IsInTakePhotoMode;

	private uint mDelayShowReconnect;

	private GameObject m_SpecificOverMask;

	private ResourceID m_bgUsedResID;

	private ResourceID m_LobbyBGSpine1;

	private ResourceID m_LobbyBGSpine2;

	private GameObject m_LobbyBG;

	private ResourceID m_CurrentSpineBGResID;

	private PlayableDirector m_LobbyBGPlayableDirector;

	private UIModelInventory m_UIModelInventory;

	private EFrontendBGMType m_CurrentBGMType;

	private EFrontendBGMType m_LastBGMType;

	private const float CHANGE_NAVIGATION_TIME_WINDOW = 15f;

	private List<int> m_HurricaneContinuousPlayBGMLst;

	private UIDebugConsoleCommandItem DebugBtnCtrl;

	private UINavigationTopbarController m_NavigationTopbarController;

	private UIDebugConsoleCommandItem2Popup m_DebugLoadPrefabCtrl;

	private uint m_BGAsyncLoadTicket;

	private UIHudReconnectTipsController m_ReconnectTipsController;

	private UILoginController m_LoginController;

	private UILobbyV2Controller m_LobbyV2Controller;

	private UIPopupWindowController m_OTPWindowCtrl;

	private bool m_HasPausedApplication;

	private ulong m_startLobbyTime;

	private GameObject HCItemLight;

	private GameObject TakePhotoItemLight;

	private UIHudSceneEditOfflineModeMainController m_HudSceneEditOfflineModeMainController;

	private static uint _DelayCallId_ProcessOpenedByUrl;

	private const float _Delay_ProcessOpenedByUrl = 0.5f;

	private const string GO_TO_CLANWAR_MODE_PARAMS = "V2_Team_4_Match_13_Map_99_Game_1";

	private const string GO_TO_CLANWAR_CSMODE_PARAMS = "V2_Team_4_Match_13_Map_99_Game_15";

	private UICSBanPickWindowController m_BanPickWindow;

	private UIMatchMakingWatingController m_MatchmakingWaiting;

	private UIMatchMakingWaitingOptimizedController m_MatchmakingWaitingOptimized;

	private UIRoomMatchMakingWaitingController m_RoomMatchMaking;

	private UIRoomHangupWaitingController m_RoomHangup;

	private GameObject m_RoomHangupContainer;

	private bool m_BRReviewRecordMatchmakingWaitingWasVisible;

	private bool m_BRReviewRecordRoomMatchMakingWasVisible;

	private bool m_BRReviewRecordRoomHangupWasVisible;

	private uint m_AutoMatchGroupingTime;

	private uint m_AutoMatchMakingTime;

	public bool m_IsCancelMatchMakingBanned;

	public bool m_IsClanWarMatchMaking;

	private UINewCollectionTypeTipsBoxManager m_NewCollectionTypeTipsBoxManager;

	public bool IsAutoTaskAchievementDone
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsOpenHippoCrisisLobby
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Is3DCameraFocusBehindScreen()
	{
		return false;
	}

	public void DisableBgCamera()
	{
	}

	public void SetBackCamerasVisible(bool bVisible)
	{
	}

	private static void SetSwapLandscapeOrientationsWhenAutoRotate()
	{
	}

	private static void SetDynamicFontFallbackToNotdefGlyph()
	{
	}

	public virtual void Show()
	{
	}

	private void OnOpenLobby()
	{
	}

	private void TriggerLobbyAutoTaskAfterPush()
	{
	}

	public virtual void SetNavigationTopbarViewData(UINavigationTopbarViewData viewData)
	{
	}

	public Transform GetNavigationTopbarTopRightTransform()
	{
		return null;
	}

	public UINavigationTopbarController GetNavigationTopbar()
	{
		return null;
	}

	public Vector3 GetNavigationTopbarHelpPos()
	{
		return default(Vector3);
	}

	private void OpenNewVault(object[] data)
	{
	}

	public void UpdateLobbyBGMByNewVault(ResourceID res)
	{
	}

	public EFrontendBGMType GetCurrentBGMType()
	{
		return EFrontendBGMType.NONE;
	}

	public void RefeshTopBtnOwnerInfo()
	{
	}

	public void UpdateLobbyBGMResource(string region)
	{
	}

	private void RequestEmote()
	{
	}

	private void OnApplicationPauseEvent(object[] parameters)
	{
	}

	public static void ProcessOpenedByUrl()
	{
	}

	private void CheckRoomID()
	{
	}

	private T GetParam<T>(object[] param, int index)
	{
		return default(T);
	}

	private void OnDeepLink(object[] param)
	{
	}

	private void OnDeepLink_GroupInvite(string group_id, string region, string secret_code)
	{
	}

	private void OnDeepLink_Lobby()
	{
	}

	private void OnDeepLink_Reunion(string uid)
	{
	}

	private void OnDeepLink_LocateClan(string clanId)
	{
	}

	private void OnDeepLink_QRCodeAddFriend(string id)
	{
	}

	private void OnDeepLink_QRCodeAddClan(string id)
	{
	}

	private void OnDeepLink_QRCodeGroupInvite(string group_id, string region, string qr_secret_code)
	{
	}

	private void OnDeepLink_QRCodeRoomInvite(string room_id, string qr_secret_code)
	{
	}

	private void OnDeepLink_ClanMainPage()
	{
	}

	private void OnDeepLink_SquadTreasureMainPage()
	{
	}

	private void OnDeepLink_RelayMart(string discountCode)
	{
	}

	private void OnDeepLink_SquadTreasureTeamInfo(string groupId)
	{
	}

	private void OnDeepLink_QRCodeSquadTreasureTeamInfo(string groupId)
	{
	}

	private void HandleSquadTreasureTeamInfoDeepLink(string groupId)
	{
	}

	private void OnDeepLink_FriendInvite(string inviterUid)
	{
	}

	private void OnDeepLink_BigEvent()
	{
	}

	private void OnDeepLink_SystemCalendar(string ff_event_name, string ff_event_id)
	{
	}

	private bool CanGotoClanByDeepLink(string key)
	{
		return false;
	}

	private void OnDeepLink_LocateRoom(uint roomType, string roomId)
	{
	}

	private void OnDeepLink_UGCMapDetail(string map_code, string region, string lang)
	{
	}

	private void OnDeepLink_HudShare(string share_code, string generation_channel = "")
	{
	}

	public void OnDeepLink_UGCMyWorks()
	{
	}

	private void OnDeepLink_WebView(string url, string style)
	{
	}

	private void OnDeepLink_Gacha()
	{
	}

	private void OnDeeplink_ViewTournamentPage(string url)
	{
	}

	private void OnDeepLink_TournamentSpectate(ulong esportsId)
	{
	}

	private void OnDeepLink_TournamentOfflinePush(ulong esportsId)
	{
	}

	private void OnDeepLink_TournamentOfflineCheckIn(ulong esportsId)
	{
	}

	private void OnDeepLink_ClanWarRecruit()
	{
	}

	private void OnDeepLink_ClanWarNotify()
	{
	}

	private void OnDeepLink_ElitePass()
	{
	}

	private void OnDeepLink_CharactersNew()
	{
	}

	private void OnDeepLink_RebateCard()
	{
	}

	private void OnDeepLink_IAPBundle()
	{
	}

	private void OnDeepLink_Mail()
	{
	}

	private void OnDeeplink_Navigate(uint pos, string param)
	{
	}

	private void ShowMessageBox(object[] data)
	{
	}

	private void ShowIAPMessageBox(object[] data)
	{
	}

	private void OnShowSpeDownloadPopup(object[] data)
	{
	}

	private void OnShowFriendObservationPopup(object[] data)
	{
	}

	private void OnShowTagDownloadPopup(object[] data)
	{
	}

	private void OnCancelDownload()
	{
	}

	private void OnShowNewDownloadPopup(object[] data)
	{
	}

	private void OnShowDownloadNavigation(object[] data)
	{
	}

	private void OnShowDownloadPopup(object[] data)
	{
	}

	private void OnShowDownloadPopupWithLog(object[] data)
	{
	}

	private UGCSimpleDownloadTask GetDownloadPopupTask(object[] data)
	{
		return null;
	}

	private bool GetDownloadPopupAuto(object[] data)
	{
		return false;
	}

	private DownloadPopupLogContext GetDownloadPopupLogContext(object[] data)
	{
		return null;
	}

	private void LogDownloadPopupClick(DownloadPopupLogContext logContext, string clickString)
	{
	}

	private void OnShowDownloadPopupInternal(object[] data, UGCSimpleDownloadTask ugcDownloadTask, bool auto, DownloadPopupLogContext logContext)
	{
	}

	private void SocialAreaDownloadAction(object[] data, ResDownloadType resType, List<ResourceID> target_id, UGCSimpleDownloadTask ugcDownloadTask, bool downloadAllResOfGameMode, DownloadPopupLogContext logContext)
	{
	}

	private void OnShowDownloadPopupOnLogin(object[] data)
	{
	}

	private UITexture FindBGTexture()
	{
		return null;
	}

	private UISprite FindBGDarkMask()
	{
		return null;
	}

	private Transform FindBG2DObjects()
	{
		return null;
	}

	private Camera FindBGCamera()
	{
		return null;
	}

	private Transform FindBGUIRoot()
	{
		return null;
	}

	public GameObject FindUI3DRoot()
	{
		return null;
	}

	protected override Transform FindUIRoot()
	{
		return null;
	}

	public UIRoot FindUIRootV2()
	{
		return null;
	}

	private UI3DObjectHelper FindUI3DRootHelper()
	{
		return null;
	}

	public Camera FindUI3DCamera()
	{
		return null;
	}

	public Camera FindUICamera()
	{
		return null;
	}

	public override void Destory()
	{
	}

	protected override void OnDestory()
	{
	}

	private void OnDestroy_MSDK()
	{
	}

	private void CancelAllUIPetAvatarAsyncLoad()
	{
	}

	private void OnCloseLogin()
	{
	}

	private void CheckReconnectInfo()
	{
	}

	private void ClearReconnectInfo()
	{
	}

	private void OnLastBattleTimeOut()
	{
	}

	private void OnLastBattleNotify(object[] data)
	{
	}

	private void ReconnectToMatchAfterLogin()
	{
	}

	private void StartReconnectToGame()
	{
	}

	private void OnOpenCustomRoom(object[] data)
	{
	}

	private void OnCloseCustomRoom(object[] data)
	{
	}

	private void OnOpenBanPick(object[] data)
	{
	}

	private void OnCloseBanPick(object[] data)
	{
	}

	private void OnReconnectBanPick(object[] data)
	{
	}

	public bool HasRoomMatchMakingWaitingView()
	{
		return false;
	}

	private void StopMatchMaking()
	{
	}

	private void ClearEstimateTime()
	{
	}

	public void HideWaitingControllersForBRReviewRecord()
	{
	}

	public void RestoreWaitingControllersAfterBRReviewRecord()
	{
	}

	private UIMatchMakingWaitingOptimizedController GetMatchMakingWaitingOptimizedController()
	{
		return null;
	}

	private bool IsRoomHangUpVisible()
	{
		return false;
	}

	private void ClearBRReviewRecordWaitingControllerVisibleState()
	{
	}

	public void OnOpenPopMenu(object[] data)
	{
	}

	public void OnOpenClanWarPopMenu(object[] data)
	{
	}

	public void OnOpenBriefBox(object[] data)
	{
	}

	public void OnOpenTips(object[] data)
	{
	}

	public void OnOpenTweenTips(object[] data)
	{
	}

	private void OnStopGroupMatchMaking(object[] data)
	{
	}

	private void OnLobbyTCPDisconnected(object[] data)
	{
	}

	private void OpenFriendWindow(object[] data)
	{
	}

	private void OpenBigEventFriendCallbackWindow(object[] data)
	{
	}

	private void OpenBigEventFriendCallbackAddFriendWindow(object[] data)
	{
	}

	private void OpenFriendWindow_Relationship(object[] data)
	{
	}

	private void OpenFriendWindow_Search(object[] data)
	{
	}

	private void OpenFriendWindow_Request(object[] data)
	{
	}

	private void OpenFriendWindow_BlackList(object[] data)
	{
	}

	private void OnServiceOff(object[] data)
	{
	}

	private void OpenMallV2Window(object[] data)
	{
	}

	private void OpenGift(object[] data)
	{
	}

	public UILobbyNotificationPopUpController OpenNotificationPopUp()
	{
		return null;
	}

	protected void OpenNotificationTipsBox(object[] args)
	{
	}

	private void OnTakePhotoModeEnter(object[] args)
	{
	}

	private void OnTakePhotoModeExit(object[] args)
	{
	}

	private void OpenPetWindow(object[] data)
	{
	}

	private void OpenLiveTvWindow(object[] data)
	{
	}

	private void OpenLeaderBoard(object[] data)
	{
	}

	private void OpenAvatarProfile(object[] data)
	{
	}

	private void OpenAvatarAwaken(object[] data)
	{
	}

	private void OpenGacha(object[] data)
	{
	}

	private void OpenForge(object[] data)
	{
	}

	private void OpenGachaExchange(object[] data)
	{
	}

	private void OpenDrawShopExchange(object[] data)
	{
	}

	private void PopupNextGiftRewards(object[] data)
	{
	}

	private void OnUILobbyBGSwitch(object[] data)
	{
	}

	public bool IsReconnecting()
	{
		return false;
	}

	public bool IsMatchMakingLoading()
	{
		return false;
	}

	private void OnGroupErr()
	{
	}

	public void SetBackground(ResourceID bg, int width, int height, bool isFliphHorizontally, bool needResetLocalScale)
	{
	}

	public void SetBackground(string url, int width = 0, int height = 0, bool isFliphHorizontally = false, bool needResetLocalScale = true, uint endTime = uint.MaxValue)
	{
	}

	public virtual void SetBackgroundActive(bool active)
	{
	}

	public void ResetBackgroundScale()
	{
	}

	private void SetBackgroundSize(int width, int height, bool needResetLocalScale)
	{
	}

	public Vector3 GetBGAdaptationAbout1500X750()
	{
		return default(Vector3);
	}

	public void SetBackGroundMask(bool is_show)
	{
	}

	public void ShowBgEffect(ResourceID resID, Vector3 offset, Vector3 scale, string targetLayer = null)
	{
	}

	public void ShowMallSpecialBgEffect(bool show)
	{
	}

	public void InitGachaUnlimitedChestInfoCDN(Vector3 position)
	{
	}

	public bool RefreshGachaUnlimitedChestInfoCDN(List<AdvertDesc> adList)
	{
		return false;
	}

	public void SetGachaUnlimitedChestInfoCDNVisible(bool visible)
	{
	}

	public void DestroyBgEffect()
	{
	}

	public void DestroyGachaUnlimitedChestInfoCDN()
	{
	}

	private void OnOpenProfile(object[] data)
	{
	}

	private void OnOpenAvatarWindow(object[] data)
	{
	}

	public UIAvatarWindowController AvatarWindow()
	{
		return null;
	}

	private void OnOpenSparkPetAvatarWindow(object[] data)
	{
	}

	private void OnPlaySparkPetAnim(object[] data)
	{
	}

	public UISparkPetAvatarWindowController SparkPetAvatarWindow()
	{
		return null;
	}

	public bool IsSparkPetAvatarWindowCreated()
	{
		return false;
	}

	private void OnOpenMapPanel(object[] data)
	{
	}

	private void OnNeedRefreshMapPanel(object[] data)
	{
	}

	private void OnOpenUGCMapPanel(object[] data)
	{
	}

	private void OnOpenGroup(object[] data)
	{
	}

	private void OnGroupCreateSuccess(object[] param)
	{
	}

	private void OnGroupStateChanged(object[] param)
	{
	}

	private void ControlGroupWait(object[] data)
	{
	}

	private void OpenGroupUI()
	{
	}

	private void OnJoinNtf(object[] data)
	{
	}

	private void OnLeaveNtf(object[] data)
	{
	}

	private void OnRefuseNtf(object[] data)
	{
	}

	public void OnLeaveGroup()
	{
	}

	private void OnDismissNtf(object[] data)
	{
	}

	private bool IsMatchRecommend(object[] data)
	{
		return false;
	}

	private void OnRecommendGroupInviteNtf(object[] data)
	{
	}

	private void ShowGroupMessageBox(string details = "", string title = "", Action cb = null)
	{
	}

	private void OpenClanSearchAssistClan()
	{
	}

	private void OnOpenClanSearchById(object[] param)
	{
	}

	private void OnOpenClan(object[] param)
	{
	}

	private void OnOpenDebtWindow(object[] dat)
	{
	}

	private void OnOpenConnectionReport(object[] param)
	{
	}

	private void OnClanCreated(object[] param)
	{
	}

	private void ShowHttpRequestErrorMessage(object[] param)
	{
	}

	private void OnLobby3DObjectVisibleChange(object[] data)
	{
	}

	private void PlayBGM(object[] data)
	{
	}

	private bool MusiceResourceNeedInOptional(EFrontendBGMType bgmType)
	{
		return false;
	}

	private void EnterCustomRoom(object[] data)
	{
	}

	public bool IsAvatarWindowCreated()
	{
		return false;
	}

	private void OnAvatarInitReady(object[] data)
	{
	}

	private void OnEpCardActive(object[] data)
	{
	}

	private void OnLobby2DObjectVisibleChange(object[] data)
	{
	}

	public void InitBackground2D()
	{
	}

	public void PlayLobbyBGStartAnim(double time)
	{
	}

	private void StopLobbyBGStartAnim()
	{
	}

	public void InitAchievementTipsBox(object[] data)
	{
	}

	private void ReloadCur2DBG(object[] data)
	{
	}

	private void LoadBackground2DObjects(ResourceID spineBGResID, bool reload = false)
	{
	}

	private void InitLobbyGyroCam()
	{
	}

	public void ResetLobbyGyroCam()
	{
	}

	public void PauseLobbyGyroCam()
	{
	}

	private void ResumeLobbyGyroCam()
	{
	}

	public bool IsLobbySupportGyro()
	{
		return false;
	}

	public Vector3 TryGetAvatarPosByMappingGyroOffset(Vector3 originPos)
	{
		return default(Vector3);
	}

	private void ShowPrimeSetShareReleaseLock(int source)
	{
	}

	private void OnHudNormalSettingChanged(object[] data)
	{
	}

	private void OnOpenReplay(object[] data)
	{
	}

	private void OnOpenReportReplay(object[] data)
	{
	}

	private void OnChampionshipMatchEnd(object[] data)
	{
	}

	private void OnShowLevelUpWindow(object[] data)
	{
	}

	public UICommonCountDownBoxController OpenCommonCountDownBox()
	{
		return null;
	}

	public void CloseCommonCountDownBox()
	{
	}

	public UIHighPingTipsBoxController OpenHighPingTipsBox()
	{
		return null;
	}

	public void CloseHighPingTipsBox(bool needPopupAgain = false, UIHighPingPopUpUserChoice choice = UIHighPingPopUpUserChoice.None)
	{
	}

	public void ShowMicPermissionTipsBox()
	{
	}

	public void CloseMicPermissionTipsBox()
	{
	}

	public void SetOverMaskShow(bool isShow)
	{
	}

	public void OnBPUnlock(object[] data)
	{
	}

	private void ShowEmulatorErrorWnd(object[] data)
	{
	}

	private void ShowCommonErrorPopupWnd(object[] data)
	{
	}

	private void ShowAutoTaskCommonError(string message, string title, Action callback)
	{
	}

	public void OnUseSpecialCameraRenderHangOutUI(object[] param)
	{
	}

	private void ShowFullScreenPreview(object[] data)
	{
	}

	private void ShowFullScreenBundlePreview(object[] data)
	{
	}

	private void ShowFullScreenVideoPreview(object[] data)
	{
	}

	private void ShowWeaponPokedexPreview(object[] data)
	{
	}

	public bool IsAvatarVertical()
	{
		return false;
	}

	public bool IsPortraitShow()
	{
		return false;
	}

	private void OnLobbyWeaponRackOpen(object[] data)
	{
	}

	private void OnHDLobbyYardOpen(object[] data)
	{
	}

	private void OnLobbyIceDisplayOpen(object[] data)
	{
	}

	private void OnLobbyVehicleDisplayOpen(object[] data)
	{
	}

	private void OnLobbySkyboardDisplayOpen(object[] data)
	{
	}

	private void ShowDebugBtn(object[] param)
	{
	}

	public bool DebugBtnState()
	{
		return false;
	}

	public bool DebugLoadPrefabState()
	{
		return false;
	}

	private bool NeedHide2DObjectNavigation()
	{
		return false;
	}

	private bool NeedShow2DObjectNavigation_HD()
	{
		return false;
	}

	protected override bool OnCheckGroupNtf()
	{
		return false;
	}

	private void OnShowBigEventFriendReunionDialog(object[] data)
	{
	}

	private void OnQRScanWindowOpen(object[] data)
	{
	}

	private void OnQRSacnSecondConfirmWindowOpen(object[] data)
	{
	}

	private void OnOpenLadderMatchMasterRankUpPopup(object[] data)
	{
	}

	private void OnDisconnectByServer(object[] data)
	{
	}

	public override bool UseUIPreInstancePool()
	{
		return false;
	}

	private void OnStartRoomMatchMaking(object[] data)
	{
	}

	private void OnEndRoomMatchMaking(object[] data)
	{
	}

	public void StopRoomMatchMaking(bool shouldRequestStop = false, Action onConfirm = null)
	{
	}

	private void HideGroupWaitingForRoomMatchMaking()
	{
	}

	private void RestoreGroupWaitingAfterRoomMatchMaking()
	{
	}

	private static void OnScreenShot(object[] data)
	{
	}

	private void OnGroupInviteNtf(object[] data)
	{
	}

	private void OnHalfwayInviteNtf(object[] data)
	{
	}

	private void OnRoomHangup(object[] data)
	{
	}

	public void HideRoomHangUp()
	{
	}

	public void ShowRoomHangUp()
	{
	}

	public bool IsRoomHangUpDragging()
	{
		return false;
	}

	private void OnEndRoomHangup(object[] data)
	{
	}

	private void ShowReconnectTip(bool show)
	{
	}

	public UINewCollectionTypeTipsBoxManager GetNewCollectionTypeTipsBoxManager()
	{
		return null;
	}

	public void ClearNewCollectionTypeTipsBoxManagerRef()
	{
	}

	protected void OnStartOTPProcess(object[] data)
	{
	}

	protected void OnFinishOTPProcess()
	{
	}

	public bool IsGameModeMainOpened()
	{
		return false;
	}

	protected void OnOpenMembershipPurchasedWindow(object[] data)
	{
	}

	protected void OnOpenHippoCrisisLobby(object[] data)
	{
	}

	protected void OnHippoCrisisLobbyVisiableChange(object[] data)
	{
	}

	protected void OnTakePhotoVisibleChange(object[] data)
	{
	}

	protected void OnMapModeChanged()
	{
	}

	protected void OnHippoCrisisLobbySplitWndShow(object[] data)
	{
	}

	private void _003COnLastBattleTimeOut_003Eb__163_0()
	{
	}

	private void _003COnLastBattleTimeOut_003Eb__163_1()
	{
	}

	private void _003CPlayBGM_003Eb__274_0(uint playingID, bool endByCancle, ResourceID resourceID)
	{
	}

	private void _003COnStartRoomMatchMaking_003Eb__334_0()
	{
	}

	private void _003COnStartRoomMatchMaking_003Eb__334_1()
	{
	}

	private void _003COnRoomHangup_003Eb__342_0()
	{
	}

	private void _003COnRoomHangup_003Eb__342_1()
	{
	}

	public Transform _003C_003EiFixBaseProxy_FindUIRoot()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_Destory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_OnCheckGroupNtf()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_UseUIPreInstancePool()
	{
		return false;
	}
}
