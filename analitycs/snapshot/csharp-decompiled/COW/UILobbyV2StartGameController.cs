using System;
using System.Collections;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

public class UILobbyV2StartGameController : UILobbyBaseStartGameController, IUIModelDataChangeObserver
{
	private enum TopConSortType
	{
		TrainingIslandBanner = -1,
		BRCrossMode = 0,
		CSCrossMode = 1,
		NewPlayerFeatureTempUnlock = 2,
		NewPlayerUnlockFeature = 3,
		NewPlayer = 4,
		Veteran = 5,
		AdsCdn = 6,
		ClanWar = 7,
		RankingTipsBubble = 8,
		Max = 99
	}

	public enum ECombinationTipsType
	{
		DailyFirstWin,
		RankProtection,
		IncreaseBtn,
		Max
	}

	private enum MapModeViewType
	{
		LeftPos,
		RightPos
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__143_2;

		public static Converter<MapModeData, uint> _003C_003E9__169_0;

		public static Converter<MapModeData, uint> _003C_003E9__183_0;

		public static Action _003C_003E9__201_2;

		public static Action _003C_003E9__209_0;

		public static Comparison<AdvertDesc> _003C_003E9__271_0;

		public static Comparison<AdvertDesc> _003C_003E9__274_0;

		internal void _003COnEnterGameBtnClick_003Eb__143_2()
		{
		}

		internal uint _003CChangeGroupMode_003Eb__169_0(MapModeData x)
		{
			return 0u;
		}

		internal uint _003CChangeMapMode_003Eb__183_0(MapModeData x)
		{
			return 0u;
		}

		internal void _003CCheckPlayerLimitsAndAutoSelectGroupMode_003Eb__201_2()
		{
		}

		internal void _003CLoadSinglePlayerForceTutorialGame_003Eb__209_0()
		{
		}

		internal int _003CRefreshAdsView_003Eb__271_0(AdvertDesc a, AdvertDesc b)
		{
			return 0;
		}

		internal int _003CRefreshTrainingIslandBanner_003Eb__274_0(AdvertDesc a, AdvertDesc b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass143_0
	{
		public UIMatchMakingManager matchMakingManager;

		public UILobbyV2StartGameController _003C_003E4__this;

		internal void _003COnEnterGameBtnClick_003Eb__0()
		{
		}

		internal void _003COnEnterGameBtnClick_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass192_0
	{
		public UILobbyV2StartGameController _003C_003E4__this;

		public MapModeData mapModeData;

		public CMDBIPLGLGA groupMode;

		internal void _003CRefreshBonusEventInfo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass201_0
	{
		public UILobbyV2StartGameController _003C_003E4__this;

		public MapModeData cachedMap;

		internal void _003CCheckPlayerLimitsAndAutoSelectGroupMode_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass201_1
	{
		public List<uint> playerLimitList;

		public _003C_003Ec__DisplayClass201_0 CS_0024_003C_003E8__locals1;

		internal void _003CCheckPlayerLimitsAndAutoSelectGroupMode_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass218_0
	{
		public UGCSimpleDownloadTask resDownloadTask;

		public UILobbyV2StartGameController _003C_003E4__this;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass218_1
	{
		public UIModelMapOpeningInfo.PGCMapInfo pgcMapInfo;

		public UILobbyV2StartGameController _003C_003E4__this;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass218_2
	{
		public uint mainTagID;

		public UILobbyV2StartGameController _003C_003E4__this;

		public Action _003C_003E9__6;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__6()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass218_3
	{
		public UGCSimpleDownloadTask resDownloadTask;

		public _003C_003Ec__DisplayClass218_2 CS_0024_003C_003E8__locals1;

		public Action _003C_003E9__5;

		internal void _003CRefreshOptionalMapResDownloader_003Eb__4()
		{
		}

		internal void _003CRefreshOptionalMapResDownloader_003Eb__5()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass240_0
	{
		public uint mapID;

		internal bool _003CGetAlternativePeriodicMapData_003Eb__0(uint t)
		{
			return false;
		}
	}

	private sealed class _003CCloseGroupModePanel_003Ed__157 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public UILobbyV2StartGameController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCloseGroupModePanel_003Ed__157(int _003C_003E1__state)
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

	private sealed class _003CCloseMapModePanel_003Ed__186 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public UILobbyV2StartGameController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCloseMapModePanel_003Ed__186(int _003C_003E1__state)
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

	private UILobbyV2StartGameView m_View;

	private const string MAP_MODE_TIPS = "map_mode_tips";

	private const string MAP_MODE_WTA_TIPS = "map_mode_wta_tips";

	private ulong m_LastChangePublicTime;

	private uint m_StartGameCoolDownResumeDelayID;

	private BitArrayBoolean m_GroupModeSelectEnable;

	public bool m_IntraTeamDuel;

	public CMDBIPLGLGA m_GroupMode;

	private CMDBIPLGLGA m_CachedGroupMode;

	private bool m_IsCurrentMapModeIsPeriodicMapMode;

	private bool m_FirstOpenModesPanel;

	private bool m_HasChangeStartIconSkin;

	private bool m_AutoChangeToGroup;

	private bool m_IsNeedSetModeAfterLeaveFromHCLobby;

	private Dictionary<uint, string> m_LabelDescripsDic;

	private Dictionary<uint, List<ResourceID>> m_SpriteResIdsDic;

	private List<ResourceID> m_RankProtectResIDs;

	private bool m_OnlyChooseProtectionMap;

	private bool m_HasDailyFirstWin;

	private bool m_HasRankProtection;

	private bool m_HasBonusEvent;

	private bool m_HasDoubleWinTips;

	private bool m_ShowSeasonYearCloseVFX;

	private const int MapModeViewRightLabelWidth = 200;

	private const int MapModeViewLeftLabelWidth = 276;

	private float m_TimeCloseNewPlayerUnlockFeatureBanner;

	private uint m_CloseNewPlayerUnlockFeatureBannerDelayCall;

	private string m_defaultStartIcon;

	private string m_LastPlayingAnim;

	private UICountDownController m_BanMatchCDCtrl;

	private int m_OriginalModesBgHeight;

	private uint m_DelayCallForBonusBtn;

	private const uint GroupModeSelectNormalLogic = 1u;

	private const uint GroupModeSelectUGCLogic = 2u;

	private Action m_OnAfterCreateGroupSuccess;

	private UIModelUser m_ModelUser;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelPeriodicLadderMatch m_UIModelPeriodicLadderMatch;

	private UIModelGroup m_ModelGroup;

	private UIModelFriends m_ModelFriends;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelSeasonYear m_ModelSeasonYear;

	private UIModelSeasonReplay m_ModelSeasonReplay;

	private UIModelInventory m_ModelInventory;

	private UIModelHuntingGround m_ModelHuntingGround;

	private UIModelOnlineMatch m_ModelOnlineMatch;

	private UIModelVeteran m_ModelVeteran;

	private UIModelMatch m_ModelMatch;

	private UIModelNewPlayerV3 m_ModelNewPlayer;

	private UIModelRankingTips m_ModelRankingTips;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UIModelNewPlayerUnlockFeature m_ModelNewPlayerUnlockFeature;

	private UILobbyGroupV2Controller m_GroupCtrl;

	private UINewDownloadInfoController m_OptionalMapResDownloader;

	private GameObject m_RankProtectSheildVFX;

	private UICommonGuideController m_HgSnowGuideCtrl;

	private UICommonGuideController m_CraftlandGuideCtrl;

	private UILobbyLoadoutController m_LoadoutController;

	private UIStandardAdsController m_AdsController;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	private UICSPeakTournamentRankIconController m_CSPeakTournamentRankIconController;

	private bool m_IsSceneEditObserved;

	private List<UIModelLobbyAds.AdInfo> m_ListAdInfo;

	private const uint TrainingIslandBannerAdId = 79000004u;

	private List<AdvertDesc> m_ListAdDesc;

	private UITipsNormalController m_SeasonYearTipsCtrl;

	private UINewPlayerV3LobbyBannerController m_NewPlayerV3LobbyBannerCtrl;

	private UICrossMatchModeBannerController m_CrossMatchModeBannerCtrl;

	private UINewPlayerUnlockFeatureBannerController m_NewPlayerUnlockFeatureBannerCtrl;

	private UIGroupRankingTipsBubbleController m_GroupRankingTipsBubbleCtrl;

	private const int CDNWIDTH = 280;

	private const int CDNHEIGHT = 58;

	private const int GRIDDOTWIDTH = 26;

	private const int GRIDDOTHEIGHT = 6;

	private const int DOTWIDTH = 22;

	private const int DOTHEIGHT = 6;

	private const int InviteGroupBoxPanelDepth = 30;

	private bool m_HasInitDefaultMode;

	public new bool ShowBigTeamMode;

	private bool m_MapRPActive;

	private bool m_BonusRewardActive;

	private bool m_ChampionshipBonusRewardActive;

	private bool m_NeedShowFirstGuideMatchGuide;

	private UILobbyV2StartGameUIFXController m_StartGameUIFXController;

	private UILobbyV2StartGameTeamModesPanelController m_StartGameTeamModesPanelController;

	private Func<bool> m_HasGuideInLobby;

	private bool m_NeedChangePanelDepth;

	private int CustomPanelDepth;

	private Vector3 m_DefaultAdsContainerPos;

	private Vector3 m_DefaultVeteranProtectPos;

	private Vector3 m_DefaultGroupRankingTipsTransFromPos;

	private Vector3 m_DefaultNewPlayerConPos;

	private bool m_NeedPlayMapModeSelectedUIFX;

	private bool m_IsInClanWarTeam;

	private static readonly List<Type> s_BaseInterestedModel;

	public static List<EventNotify> InterestedEvent;

	private MapModeData m_SelectedMapData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UIButton LadderBtn => null;

	public UIWidget LadderBtnGuideWidget => null;

	public Transform LadderBtnGuideTransform => null;

	public UIButton EnterGameBtn => null;

	public UIWidget EnterGameGuideWidget => null;

	public UIWidget LoadOutGuideWidget => null;

	public UIWidget MapModeBtnWidget => null;

	public UIButton UIButtonmapModeBtn => null;

	public UISprite UITeamModeBG => null;

	public UIWidget CsGuideWidget => null;

	public GameObject MapModeTipsAnim => null;

	public GameObject LoadOutContainer => null;

	public UILobbyLoadoutController LoadoutController => null;

	private UILobbyV2StartGameTeamModesPanelController StartGameTeamModesPanelController => null;

	private MapModeViewType CurrentMapModeViewType => MapModeViewType.LeftPos;

	private bool ShowCraftlandNode => false;

	public static List<Type> InterestedModel => null;

	private TopConSortType CurTopConSortType => TopConSortType.BRCrossMode;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private static bool ShouldObserveSceneEditForSelectedMap(UIModelMapOpeningInfo modelMap)
	{
		return false;
	}

	private static bool ShouldPrelistenSceneEdit()
	{
		return false;
	}

	private static bool ShouldShowUGCUpdateBanner()
	{
		return false;
	}

	private void EnsureSceneEditObserved()
	{
	}

	protected override void OnUIInit()
	{
	}

	public void AfterInit(bool init = false)
	{
	}

	private void ProcessNewbieProcess()
	{
	}

	private void DelayRefresh()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnEnterGameBtnClick()
	{
	}

	private void OnTeamModeBtnClick()
	{
	}

	public void OnMapModeBtnClick()
	{
	}

	private void OpenMapMode(object[] data)
	{
	}

	private void OnPentaBtnClick()
	{
	}

	private void OnSquardBtnClick()
	{
	}

	private void OnDuoBtnClick()
	{
	}

	private void OnSoloBtnClick()
	{
	}

	private void OnResDownloaderClick(uint mapConfigId)
	{
	}

	private void OnTalentBtnClick()
	{
	}

	private void OnInRoomBtnClick()
	{
	}

	private bool IsOpenHippoCrisisLobby()
	{
		return false;
	}

	private void OnBanMatchBtnClick()
	{
	}

	private void OnInHippoCrisisBtnClick()
	{
	}

	private IEnumerator CloseGroupModePanel(float seconds)
	{
		return null;
	}

	private void CloseGroupModePanel()
	{
	}

	private void UpdateSelectedGroupModeUI()
	{
	}

	private void UpdateSelectedMapModeUIInternal(bool init = false)
	{
	}

	private void UpdateSelectedMapModeUI()
	{
	}

	private void RefreshRankProtectIconInfo(MapModeData selectedMap)
	{
	}

	private void RefreshGroupCtrl()
	{
	}

	private void RefreshNewMapProtection()
	{
	}

	private void OnIncreaseBtnClick()
	{
	}

	private void RefreshHgSnowGuide()
	{
	}

	private void RefreshLWIntraTeamDuelGuide()
	{
	}

	private void RefreshHuntingGroundUI(bool fromDataChange = false)
	{
	}

	private void ChangeGroupMode(CMDBIPLGLGA mode, tcp.EGroup.CreateFromType fromType = tcp.EGroup.CreateFromType.CreateFromType_OWNSELF, bool intraTeamDuel = false, bool allowShowPunish = true)
	{
	}

	private void OnleaveFromHCLobby()
	{
	}

	private void OnDismissNtf(object[] data)
	{
	}

	private void OnLeaveNtf(object[] data)
	{
	}

	private void OnRoomMatchMakingTimeout(object[] data)
	{
	}

	public void SetDefaultMode()
	{
	}

	public void RefreshDefaultUI()
	{
	}

	private void ShowMapModetip(object[] data)
	{
	}

	private void OnCraftlandBtnClick()
	{
	}

	private void OnCraftlandDetailBtnClick()
	{
	}

	private void OnSlayDragonBuffBtnClick()
	{
	}

	private void ChangePublicState(object[] args)
	{
	}

	private void ChangeGroupMode(object[] args)
	{
	}

	private void RevertGroupMode(CMDBIPLGLGA mode)
	{
	}

	private bool ChangeMapMode(MapModeData mapData, bool needAutoExpandGroup = false)
	{
		return false;
	}

	private void AutoSelectGroup()
	{
	}

	private void RevertMapMode(MapModeData mapData)
	{
	}

	private IEnumerator CloseMapModePanel(float seconds)
	{
		return null;
	}

	private void CloseMapModePanel(bool init = false)
	{
	}

	private void CloseModeSelectionPanels(object[] data)
	{
	}

	private void OpenGroupUI(bool init = false)
	{
	}

	private void CheckAndStartFirstGuideMatch()
	{
	}

	public void CloseGroupV2Ctrl()
	{
	}

	public void RefreshBonusEventInfo(MapModeData mapModeData, CMDBIPLGLGA groupMode)
	{
	}

	private void SetIncreaseBtnView()
	{
	}

	private void RefreshGameLobbyEnterStyle(object[] data)
	{
	}

	private void RefreshStartBtnView(string lobbyStartIcon)
	{
	}

	public void RefreshCachedUISelectedData(object[] data)
	{
	}

	private bool QuitToSolo()
	{
		return false;
	}

	private bool CheckGroupMode()
	{
		return false;
	}

	public override bool CheckIntraTeamDuel()
	{
		return false;
	}

	public override bool CheckPlayerLimits(CMDBIPLGLGA groupMode, bool showTips = true)
	{
		return false;
	}

	private bool CheckPlayerLimitsAndAutoSelectGroupMode(CMDBIPLGLGA groupMode, bool needAutoExpandGroup = false)
	{
		return false;
	}

	private bool IsSoloSupported(MapModeData mapData, bool showTips = true)
	{
		return false;
	}

	private bool HasNoGuideInLobby()
	{
		return false;
	}

	private bool CheckMapAvailability()
	{
		return false;
	}

	private void RefreshBanMatchView()
	{
	}

	private void OnEndMatchMaking(object[] data)
	{
	}

	private void SetOverMaskShow(bool show)
	{
	}

	private void CheckAndStartSinglePlayerForceTutorialGame()
	{
	}

	private void LoadSinglePlayerForceTutorialGame()
	{
	}

	public void RefreshGroupLeaderView(object[] objs)
	{
	}

	private void SetShowSeasonYearReturnVFX(object[] objs)
	{
	}

	private void EnableModeSelectionButtons(bool v)
	{
	}

	private void UpdateUGCMask(bool showModeMask)
	{
	}

	private void OnMatchmakingHide()
	{
	}

	private void OnMatchmakingShow()
	{
	}

	private void OnRoomHangupEndShow(object[] data)
	{
	}

	private void OnRoomHangupHide(object[] data)
	{
	}

	private void RefreshOptionalMapResDownloader(object[] data)
	{
	}

	private void OnHGDifficultyChoose(uint mapDifficulty, uint gameMode)
	{
	}

	private void ShowHGDifficultyChoose(object[] param)
	{
	}

	private void ChangeGroupUIState()
	{
	}

	private void OpenPVEDifficultyChooseUI(uint gameMode)
	{
	}

	private void OnMapModeSelected(object[] param)
	{
	}

	private void OnMapModeSelectedPlayUIFX()
	{
	}

	private void OnGameModeVisibleChange(object[] data)
	{
	}

	public void StartFirstGuideMatchmakingSolo(bool isTutorialBr, bool isTutorialCS)
	{
	}

	private void OptionalDownloadStateChange()
	{
	}

	private void ShowSeasonRedPoint()
	{
	}

	private void RefreshLadderRedPointVisible()
	{
	}

	private void ShowSeasonYearReturnVFX()
	{
	}

	private void SetShowSpecialMissionCloseVFX(object[] data)
	{
	}

	private void OnEnterClanWarTeam(object[] data)
	{
	}

	private void OnExitClanWarTeam(object[] data)
	{
	}

	private void OnGroupQuit()
	{
	}

	private bool CheckIsMapAvailabe()
	{
		return false;
	}

	private void RefreshInHippoCrisisState()
	{
	}

	private void RefreshStartBtnColor()
	{
	}

	private MapModeData GetAlternativePeriodicMapData()
	{
		return null;
	}

	private void OnGroupCreateSuccess(object[] param)
	{
	}

	private void OnJoinNtf(object[] data)
	{
	}

	private void OnUICloseCreateRoom(object[] data)
	{
	}

	private void OnGroupInfoSync(object[] data)
	{
	}

	private void OnGroupChangeGroupModeNtf(object[] data)
	{
	}

	private void OnCreateGroupFail(object[] data)
	{
	}

	private void OnCompatibleLoginStart(object[] data)
	{
	}

	public void RefreshRightBottomGroupModeUI()
	{
	}

	private void OnRoomOpen(object[] param)
	{
	}

	private void OnWorkShopMapSelected(object[] data)
	{
	}

	private void OnWorkshopRequestInfo(object[] data)
	{
	}

	private void OnFefreshAfterRestartMatchMaking(object[] data)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshLoadoutView()
	{
	}

	private void RefreshDailyFirstWin()
	{
	}

	private void RefreshDoubleWinTips()
	{
	}

	private void RefreshBonusIcons()
	{
	}

	private void RefreshNormalViewAndBonusVeiwIconForDownload()
	{
	}

	private void RefreshLadderContainerView()
	{
	}

	private void RefreshCraftLandDetailBtn()
	{
	}

	private void RefreshMapModeView()
	{
	}

	private void TryRefreshCSCrossModeView()
	{
	}

	private void TryRefreshBRCrossModeView()
	{
	}

	private void OnLadderBtnClick()
	{
	}

	private void RefreshAdsView()
	{
	}

	private bool IsShowAdsContainer()
	{
		return false;
	}

	private bool IsShowTrainingIslandBanner()
	{
		return false;
	}

	private void RefreshTrainingIslandBanner()
	{
	}

	private void OnClickStandardAds(object[] data)
	{
	}

	private void RefreshGamePattern()
	{
	}

	private void RefreshGameModeSelectedText()
	{
	}

	private void RefreshVeteranProtectUI()
	{
	}

	private void RefreshCSPeakGameModeLabel()
	{
	}

	private void Update()
	{
	}

	private bool IsShowVeteranProtect()
	{
		return false;
	}

	private void RefreshRankProtectShieldVFX(bool isShow)
	{
	}

	private bool IsShowCSRankProtectShieldVFX()
	{
		return false;
	}

	private bool IsShowBRRankProtectShieldVFX()
	{
		return false;
	}

	private void RefreshDefaultLabelText()
	{
	}

	public void NewbieMatchGameGuide(object[] args)
	{
	}

	public void SetGuideInLobbyFunc(Func<bool> hasHasGuideInLobbyFunc)
	{
	}

	private void RefreshTopContainerView()
	{
	}

	private void ResetTopConUI(TopConSortType type, bool isRankingTipsCache = false)
	{
	}

	private void ResetDefaultPos()
	{
	}

	private void CancelCloseNewPlayerUnlockFeatureBannerDelayCall()
	{
	}

	private void RefreshNewPlayerUnlockFeatureBanner()
	{
	}

	private void RefreshNewPlayerFeatureTempUnlockView()
	{
	}

	private bool CheckAndRefreshGroupRankingTips()
	{
		return false;
	}

	private void ForceCreateAndShowGroupRankingTipsBubbleForDebug()
	{
	}

	private void RefreshCrossModeBanner(DLBMPCCFKKM matchMode)
	{
	}

	private void RefreshNewPlayerUI()
	{
	}

	private void RefreshClanWarNode()
	{
	}

	private void RefreshCraftlandNode(TopConSortType dualType = TopConSortType.Max)
	{
	}

	private void ShowCraftlandGuide(object[] data)
	{
	}

	private void InitDefaultPos()
	{
	}

	public void SetPanelDepth(int depth)
	{
	}

	private void PlayNormalVeiwAnimationByIndex(int index)
	{
	}

	public void PlayInAnim(bool isSkipLast = false)
	{
	}

	public void PlayOutAnim(bool isSkipLast = false)
	{
	}

	public Transform GetMainTransform()
	{
		return null;
	}

	private void _003CCheckAndStartFirstGuideMatch_003Eb__190_0()
	{
	}

	private void _003CRefreshBanMatchView_003Eb__205_0()
	{
	}

	private void _003CLoadSinglePlayerForceTutorialGame_003Eb__209_1()
	{
	}

	private void _003CRefreshOptionalMapResDownloader_003Eb__218_0()
	{
	}

	private void _003CRefreshOptionalMapResDownloader_003Eb__218_3()
	{
	}

	private void _003CRefreshOptionalMapResDownloader_003Eb__218_7()
	{
	}

	private bool _003COnWorkShopMapSelected_003Eb__250_0(uint a)
	{
		return false;
	}

	private void _003CNewbieMatchGameGuide_003Eb__286_0()
	{
	}

	private void _003CRefreshNewPlayerUnlockFeatureBanner_003Eb__294_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public bool _003C_003EiFixBaseProxy_CheckIntraTeamDuel()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_CheckPlayerLimits(CMDBIPLGLGA P0, bool P1)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
