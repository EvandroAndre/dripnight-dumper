using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UILobbyV2Controller : UINavigationController, IUIModelDataChangeObserver, ITipsDelegate
{
	public enum EIAPBundleSubType
	{
		None,
		NormalIAPBundle,
		IAPWeekBundle,
		HDIAPBundle,
		IAPBundleChoose1From3,
		IAPBundleWeb
	}

	public enum ELeftEntranceType
	{
		None,
		NewPlayerSignin,
		PreVeteran,
		VeteranSignin,
		BigEventContainerFlashStore,
		BigEventContainerTemplate,
		LocalActivity
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<GroupMemberInfo, FriendInfo> _003C_003E9__237_0;

		public static EventDelegate.Callback _003C_003E9__464_0;

		public static EventDelegate.Callback _003C_003E9__464_1;

		public static Predicate<MapModeData> _003C_003E9__512_0;

		public static Predicate<MapModeData> _003C_003E9__512_1;

		public static Predicate<MapModeData> _003C_003E9__512_2;

		public static Predicate<MapModeData> _003C_003E9__512_3;

		internal FriendInfo _003COnFastSendGiftBtnClick_003Eb__237_0(GroupMemberInfo teammate)
		{
			return null;
		}

		internal void _003CCreateLobbyGuide_003Eb__464_0()
		{
		}

		internal void _003CCreateLobbyGuide_003Eb__464_1()
		{
		}

		internal bool _003CNewbieSetMapModeGameGuide_003Eb__512_0(MapModeData temp)
		{
			return false;
		}

		internal bool _003CNewbieSetMapModeGameGuide_003Eb__512_1(MapModeData temp)
		{
			return false;
		}

		internal bool _003CNewbieSetMapModeGameGuide_003Eb__512_2(MapModeData temp)
		{
			return false;
		}

		internal bool _003CNewbieSetMapModeGameGuide_003Eb__512_3(MapModeData temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass211_0
	{
		public UILobbyV2Controller _003C_003E4__this;

		public float currentTime;

		internal void _003COnNavigationShowed_003Eb__0()
		{
		}
	}

	private sealed class _003CDelayCreateStartGame_003Ed__195 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyV2Controller _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayCreateStartGame_003Ed__195(int _003C_003E1__state)
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

	private sealed class _003CDelayRefreshActivityEntrance_003Ed__372 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyV2Controller _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRefreshActivityEntrance_003Ed__372(int _003C_003E1__state)
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

	private sealed class _003CInitDelayNoEnsure_003Ed__206 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyV2Controller _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitDelayNoEnsure_003Ed__206(int _003C_003E1__state)
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

	private sealed class _003CRefreshLobbyTips_003Ed__215 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyV2Controller _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshLobbyTips_003Ed__215(int _003C_003E1__state)
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

	private sealed class _003CTryRecoverNinthUI_003Ed__212 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyV2Controller _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTryRecoverNinthUI_003Ed__212(int _003C_003E1__state)
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

	private sealed class _003CWaitForBigEventEntranceOpen_003Ed__367 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint openTime;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForBigEventEntranceOpen_003Ed__367(int _003C_003E1__state)
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

	private sealed class _003CWaitFrameForAnimation_003Ed__492 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyV2Controller _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitFrameForAnimation_003Ed__492(int _003C_003E1__state)
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

	private UITakePhotoController m_UITakePhotoController;

	private bool m_TakePhotoChangedTopbar;

	private UILobbyV2View m_View;

	private UILobbyV2InGameView m_ViewInGame;

	private UIGameAssistantLobbyBubbleController m_InGameAssistBubbleCtrl;

	private UIGameAssistantLobbyRankingTipsBubbleController m_InGameRankingTipsBubbleCtrl;

	private UIModelUser m_ModelUser;

	private UIModelActivity m_ModelActivity;

	private UIModelChat m_ModelChat;

	private UIModelLobbyAds m_ModelLobbyAds;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelPeriodicLadderMatch m_ModelPeriodicLadderMatch;

	private UIModelHippoCrisisLadderMatch m_ModelHippoCrisisLadderMatch;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private UIModelMatch m_ModelMatch;

	private UIModelAnnoucementReward m_ModelAnnoucementReward;

	private UIModelIAPBundle m_ModelIAPBundle;

	private UIModelGacha m_ModelGacha;

	private UIModelIchis m_ModelIchis;

	private UIModelDrawShop m_ModelDrawShop;

	private UIModelLocalization m_ModelLocalization;

	private UIModelLuckyWheel m_ModelLuckyWheel;

	private UIModelRelayMart m_ModelRelayMart;

	private UIModelMysteryMall m_ModelMysteryMall;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIModelFlashStore m_ModelFlashStore;

	private UIModelBigEvent m_ModelBigEvent;

	private UIModelNewPlayerV3 m_ModelNewPlayer;

	private UIModelPreVeteran m_ModelPreVeteran;

	private UIModelVeteran m_ModelVeteran;

	private UIModelGroup m_ModelGroup;

	private UIModelRecruit m_ModelRecruit;

	private UIModelPayment m_ModelPayment;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelCollection m_ModelCollection;

	private UIModelProfile m_ModelProfile;

	private UIModelInventory m_ModelInventory;

	private UIModelWeaponSkinUpgrader m_ModelWeaponSkinUpgrader;

	private UIModelAvatarProfile m_ModelAvatarProfile;

	private UIModelAvatar m_ModelAvatar;

	private UIModelBooyahPass m_ModelBooyahPass;

	private UIModelCredit m_ModelCredit;

	private UIModelRelationShip m_ModelRelationShip;

	private UIModelNewVault m_ModelNewVault;

	private UIModelLobbyEventBubble m_ModelLobbyEventBubble;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelMall m_ModelMall;

	private UIModelLiveTv m_ModelLiveTv;

	private UIModelShoppingMall m_ModelShopppingMall;

	private UIModelLogin m_ModelLogin;

	private UIModelCDNAd m_ModelCDNAd;

	private UIModelNewPlayerUnlockFeature m_ModelNewPlayerUnlockFeature;

	private UIModelSparkPet m_ModelSparkPet;

	private UIModelGameAssistantIntroduction m_ModelGameAssistantIntroduction;

	private UIModelRankingTips m_ModelRankingTips;

	private UIActivityMasterController.ActivityCategory m_ActivityCategory;

	private string m_EventsIconDefaultName;

	private GameObject m_EventVFX;

	private string m_EventAnim;

	public bool NeedShowVeteranIcon;

	public string EventsIconName;

	private string m_BuildIcon;

	private Color32 m_StoreIconDefaultColor;

	private Color32 m_GachaIconDefaultColor;

	private Color32 m_DrawShopIconDefaultColor;

	private Color32 m_EventIconDefaultColor;

	private Color32 m_StoreLabelDefaultColor;

	private Color32 m_GachaLabelDefaultColor;

	private Color32 m_DrawShopLabelDefaultColor;

	private Color32 m_EventLabelDefaultColor;

	private uint m_MessageDispearCallID;

	private int m_MessageLabelOrigWidth;

	private Dictionary<uint, uint> m_HideoutIAPBundlePriorityDict;

	private HashSet<uint> m_IAPBundleSubSet;

	private UILobbyV2HideoutController m_HideoutController;

	private UILobbyIAPBundleController m_LobbyIAPBundleController;

	private UILobbyV2IAPBundleChoose1From3Controller m_IAPBundleChoose1From3Controller;

	private UILobbyV2IAPBundleWebController m_IAPBundleWebController;

	private Dictionary<uint, uint> m_RevenuePriorityDict;

	private Dictionary<uint, uint> m_LobbyRightRevenuePriorityDict;

	private UILobbyV2LobbyGachaBtnController m_LobbyGachaBtnController;

	private UILobbyDrawShopBtnController m_LobbyDrawShopBtnController;

	private UILobbyV2PurchaseEventBtnController m_PurchaseEventBtnController;

	private UILobbyV2RelayMartEntranceController m_RelayMartBtnController;

	private UILobbyV2MysteryMallBtnController m_MysteryMallBtnController;

	private UILobbyV2BigEventTemplateController m_BigEventTemplateRevenueBtnController;

	private UILobbyV2BigEventTemplateController m_BigEventTemplateBigEventeBtnController;

	private UILobbyV2FlashStoreBtnController m_FlashStoreRevenueBtnController;

	private UILobbyV2FlashStoreBtnController m_FlashStoreBigEventBtnController;

	private UILobbyV2PaymentController m_PaymentController;

	private UILobbyV2LocalActivityController m_LocalActivityController;

	private UIStandardAdsController m_AdsController;

	private Dictionary<uint, ulong> m_DictRevenueEntranceTypeToPaymentEndTime;

	private Dictionary<uint, uint> m_DictRevenueEntranceTypePaymentType;

	private bool m_HaveBigEvent;

	private bool m_HaveBigEventTemplete;

	private Dictionary<int, UIBigEventLobbyEntranceBaseController> m_BigEventEntranceDict;

	private Coroutine m_WaitForEntranceOpenCoroutine;

	public static int OpenFrameCount;

	private bool m_DisableOnPopupWindowListChange;

	private UILobbyV2NewPlayerSigninController m_NewPlayerSigninController;

	private UILobbyV2PreVeteranController m_PreVeteranController;

	private UILobbyV2VeteranSigninController m_VeteranSigninController;

	private UILobbyV2ResidentFriendListController m_ResidentFriendListController;

	private UIControllerContext m_StartGameContext;

	private UILobbyV2StartGameController m_StartGameController;

	private UILoginAge18Controller m_LobbyAge18LogoCtrl;

	private UILobbyV2InviteGroupBoxController m_InviteBox;

	private UILobbyV2SubSystemController m_SubSystemController;

	private UIHudPetAnimLobbyController m_PetAnimController;

	private UIEmoteShowPanelController m_EmotePanelController;

	private UIClanWarV2BarragePanelController m_ClanWarBarragePanel;

	private UIGroupMemberFastMessageWindowController m_GroupMemberFastMessageWindowCtrl;

	private UICommonGuideController m_CommonGuideCtrl;

	public const string RANK_UNLOCK_TIPS = "rank_unlock_tips_lobbyV2";

	private bool m_LateShowAvatarLimitExpireWnd;

	private bool m_IsStartDownloadEquipedOrOwnedOptionalDownload;

	private static List<string> UI3DOBJECT_NAMES;

	private static List<string> UI3DOBJECT_NAMES_NOSHADOW;

	private GameObject m_LobbyVfx;

	private const string LOBBY_NEW_SCREEN_VFX_NAME = "UIFX_Screen";

	private Transform m_LobbyFaultScreenTrans;

	private Animation[] m_RecordAnimation;

	private string m_LobbyV2AnimationType;

	private bool m_LobbyStateChange;

	private bool m_HasGrowthFundAutoTask;

	private bool m_RequestTopupEvent;

	private bool m_HaveRevenueEntrance;

	private bool m_HaveLobbyRightRevenueEntrance;

	private bool m_HaveHideoutIAPBundle;

	private bool m_HideoutIAPBunldeIsHideoutFirst;

	private bool m_HaveRefreshShoppingMallEntrance;

	private uint m_HideoutIAPBunldeDelayCallID;

	private uint m_NoticeRecruitDelayCallID;

	private uint m_NoticeChangeTeamDelayCallID;

	private bool m_NeedRefreshLobby;

	private bool m_IsSubSystemShow;

	private float m_LastLobbyLocationUploadTime;

	public const string AVATAR_EMOTESHOW_GUIDE = "AVATAR_EMOTESHOW_GUIDE";

	public const string PET_ACTION_GUIDE = "PET_ACTION_GUIDE";

	public const string VETERAN_ICON = "FF_UI_Veteran_powerIcon01";

	private UILobbyV2SpecialBtnController m_SpecialBtnCtrl;

	private UILobbyV2GroupLeftEntranceController m_GroupLeftEntranceCtrl;

	private UILobbyV2GroupLeftBottomEntranceController m_GroupLeftBottomEntranceCtrl;

	private UILobbyV2SpecialEntranceController m_SpecialEntranceCtrl;

	private Coroutine m_DelayCreateStartGame;

	private uint m_TeamUpDelayCall;

	private UINewbieRecruitPanelController m_NewbieRecruitPanelCtrl;

	private uint m_NewbieRecruitTickCall;

	private uint m_NewbieRecruitDisappearCall;

	private bool m_HasRequestedNewbieRecommend;

	private bool m_IsNewbieRecruitInGroupState;

	private bool m_InstantShowGuideFlag;

	private const int CDNWIDTH = 256;

	private const int CDNHEIGHT = 107;

	private const int GRIDDOTWIDTH = 37;

	private const int GRIDDOTHEIGHT = 6;

	private const int DOTWIDTH = 34;

	private const int DOTHEIGHT = 6;

	private const string LOBBY_BANNER_DOT_ENABLE_SPRITE_NAME = "FF_UI_Lobby_BannerTab01";

	private const string LOBBY_BANNER_DOT_DISABLE_SPRITE_NAME = "FF_UI_Lobby_BannerTab02";

	private readonly Vector3 LeftBottomGroupPositionWithFFCenterHide;

	private readonly Vector3 LeftBottomGroupPositionWithFFCenterShow;

	private Transform BigEventContainer;

	private Transform BigEventContainerFlashStore;

	private Transform BigEventContainerTemplate;

	private Transform LocalActivity;

	private Transform NewPlayerSignin;

	private Transform PreVeteran;

	private Transform VeteranSignin;

	private GameObject LeftBottomBtnGroupGO;

	private Transform LobbyGacha;

	private Transform LobbyDrawShop;

	private Transform PurchaseEvent;

	private Transform RelayMart;

	private Transform MysteryMall;

	private Transform FlashStore;

	private Transform BigEventTemplate;

	private Coroutine m_TryRecoverNinthUICoroutine;

	private ERevenueEntranceType m_RevenueEntranceType;

	private ERevenueEntranceType m_RevenueEntranceLobbyRightTypeFirst;

	private ERevenueEntranceType m_RevenueEntranceLobbyRightTypeSecond;

	private static bool m_StartToLeave;

	private List<uint> m_LobbyV2TipsTypes;

	private List<uint> m_LobbyV2LeftGroupTipsTypes;

	private List<uint> m_LobbyV2LeftBottomGroupTipsTypes;

	private UITipsNormalController m_ChatRedTipsCtrl;

	private UITipsNormalController m_NewChatRedTipsCtrl;

	private UITipsNormalController m_SubSystemEntranceTipsCtrl;

	private UITipsNormalController m_BPTipsCtrl;

	private UITipsNormalController m_StoreTipsCtrl;

	private UITipsNormalController m_GachaTipsCtrl;

	private UITipsNormalController m_DrawShopTipsCtrl;

	private UITipsNormalController m_MissionTipsCtrl;

	private UITipsNormalController m_EventTipsCtrl;

	private UITipsNormalController m_WeaponSkinTipsCtrl;

	private UITipsNormalController m_LabEntranceCtrl;

	private UITipsNormalController m_BuildSystemTipsCtrl;

	private bool m_bIsShowingCSGuide;

	private readonly int BEFORE_STARTGAME_GUIDE_TIME;

	private uint m_StartGameGuideCall;

	private uint m_DelayShowMask;

	private Queue<Action> m_NewbieGuideQueue;

	private bool m_NewbieGuideTriggered;

	public static bool IsUILobbyInGame => false;

	public uint ActivityCategory => 0u;

	public UILobbyV2StartGameController StartGameController => null;

	public UILobbyV2InviteGroupBoxController InviteBox => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private IEnumerator DelayCreateStartGame()
	{
		return null;
	}

	private void InjectComponentsFromView()
	{
	}

	private void InitInGameAssistBubble()
	{
	}

	private void HideInGameAssistBubble()
	{
	}

	private void RefreshInGameAssistBubble()
	{
	}

	private void RefreshInGameRankingTipsBubble()
	{
	}

	private void HideInGameRankingTipsBubble()
	{
	}

	private void CreateStartGame()
	{
	}

	private void OnDisable()
	{
	}

	private void UrgentCreateStartGame()
	{
	}

	private void NotifyStartGame()
	{
	}

	private IEnumerator InitDelayNoEnsure()
	{
		return null;
	}

	private void CreateLobbyAge18Logo()
	{
	}

	private void EnsureSparkPetLobbyModelObserved()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void RefreshAssistBubble()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private IEnumerator TryRecoverNinthUI()
	{
		return null;
	}

	private void TakePhotoChangeUI(bool isShow)
	{
	}

	private void UpdateHyperBookEntranceRedPointByUnlockOrDraw()
	{
	}

	private IEnumerator RefreshLobbyTips()
	{
		return null;
	}

	public override void OnNavigationClosed()
	{
	}

	private void ShowFirstGuideMatchGuide(object[] data)
	{
	}

	private void OnServerConfirmed(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override List<string> GetNeedShowUI3dObjectNames()
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

	private void OnVaultBtnClick()
	{
	}

	private void OnWeaponSkinBtnClick()
	{
	}

	private void OnBuildBtnClick()
	{
	}

	private void OnLabEntranceBtnClick()
	{
	}

	private void OnChatRecruitBtnClick()
	{
	}

	public void OnRecruitTeammateBtnClick()
	{
	}

	private void OnNoticeChangeTeamBtnClick()
	{
	}

	private bool GetNoticeChangeTeamOpenMapBonus(uint matchMode)
	{
		return false;
	}

	private uint GetNoticeChangeTeamSpecialModeEventId(uint gameMode, uint matchMode)
	{
		return 0u;
	}

	private void OnChatBtnClick()
	{
	}

	private void OnChatMessageBtnClick()
	{
	}

	private void OnFastSendGiftBtnClick()
	{
	}

	private void OnChatMessageLabelScrollFinish()
	{
	}

	private void OnBooyahPassBtnClick()
	{
	}

	private void OnMissionBtnClick()
	{
	}

	private void OnEventsBtnClick()
	{
	}

	private void OnStoreBtnClick()
	{
	}

	private void OnGachaBtnClick()
	{
	}

	private void OnDrawShopBtnClick()
	{
	}

	private void OnSubSystemEntranceBtnClick()
	{
	}

	private void OnBtnClickLog(string log)
	{
	}

	private void OnLadderMatchEnter(object[] data)
	{
	}

	private bool IsLadderMatchLevelSatisfied()
	{
		return false;
	}

	private void OnLobbyV2RefreshRevenueEntrance(uint entranceType)
	{
	}

	private void OnLobbyV2RefreshLeftEntrance(uint entranceType)
	{
	}

	private void OnLobbyV2RefreshHideoutIAPBundleEntrance(object[] data)
	{
	}

	private void OnMallQuit(object[] data)
	{
	}

	private void OnRefreshGroupModeUI(object[] data)
	{
	}

	public void OnLeftBtnAndEntranceRepositon()
	{
	}

	private void OnGroupStateChange(bool inTeam)
	{
	}

	private void OnLeftContainerActiveChange(bool active)
	{
	}

	private void OnLeftBottomContainerActiveChange(bool active)
	{
	}

	private void OnLeftGroupActiveChange(bool active)
	{
	}

	private void OnLeftBottomGroupActiveChange(bool active)
	{
	}

	private void OnChatGroupInfoChange()
	{
	}

	private void OnGroupStateChangeResetTopRightEntrance(bool inTeam)
	{
	}

	private void OnGroupStateChangeResetWidgetSize(int width, int height)
	{
	}

	private void OnGroupStateChangeResetLeftTopEntrance(bool inTeam)
	{
	}

	private void OnGroupStateChangeResetEntrance(bool inTeam)
	{
	}

	private void OnSetLobbyObjectVisibleState(object[] data)
	{
	}

	private void OnGameModeVisibleChange()
	{
	}

	private void OnOpenSetting(object[] data)
	{
	}

	private void OnPetHideActionPanel()
	{
	}

	private void OnShowAvatarEmotePanel(object[] data)
	{
	}

	private void InitCenterEmotePanelClickState()
	{
	}

	private void ChangeCenterEmotePanelClickState(bool state)
	{
	}

	private void OnCenterEmoteEmotePanelClick()
	{
	}

	private void OnPetShowActionClick(object[] data)
	{
	}

	private void OnTouchLocalAvatar(object[] param)
	{
	}

	private void OnCloseEmotePanel(object[] param)
	{
	}

	private void OnRoomHangup(object[] param)
	{
	}

	private void OnRoomHangupEnd(object[] param)
	{
	}

	private void CheckPetLobbyAction()
	{
	}

	private void OpenAvatarLimitExpireWindow()
	{
	}

	private void CheckAutoDownloadOptionalDownloadOwneOrEquipedClothes()
	{
	}

	private void ShowHideResidentFriendList(object[] data)
	{
	}

	private void RefreshRoomInfo()
	{
	}

	private void RefreshOptionalDownload()
	{
	}

	private void RefreshAvatarCloth()
	{
	}

	private void RefreshAvatarTransformer()
	{
	}

	private void RefreshTailorEffect()
	{
	}

	private void RefreshBackFromPaymentShowSecondRecharge()
	{
	}

	private void RefreshRelationShareSkillTips()
	{
	}

	public void TrySetCompatibleLoginView()
	{
	}

	private void SetPreCloseView(object[] data)
	{
	}

	private void SetCompatibleLoginView(object[] data)
	{
	}

	private void RefreshHDIPMusic(object[] data)
	{
	}

	private void UpdateLobbyMusic()
	{
	}

	private void InitDefaultParam()
	{
	}

	private void InitMask()
	{
	}

	private void InitLobbyV2ABTest()
	{
	}

	private void InitLeftEntranceGroup()
	{
	}

	private void RefreshStoreView()
	{
	}

	private void RefreshGachaView()
	{
	}

	private void RefreshDrawShopView()
	{
	}

	private void RefreshBooyahPassView()
	{
	}

	private void RefreshMissionView()
	{
	}

	private void RefreshEventsView()
	{
	}

	private bool RefreshReleastNotesBtn()
	{
		return false;
	}

	private bool RefreshFestivalBtn(EventTabType festivalIconType)
	{
		return false;
	}

	private uint GetLeftButtonGroupActiveEntranceNumber()
	{
		return 0u;
	}

	private void RefreshLeftBottomBtnGroupSpriteBgScale(bool isGroup)
	{
	}

	private void CrossFadeEventAnimator()
	{
	}

	private void DestoryEventVFXObj()
	{
	}

	private void RefreshVaultView()
	{
	}

	private void RefreshWeaponSkinView()
	{
	}

	private void RefreshBuildView()
	{
	}

	private void RefreshBuildIcon()
	{
	}

	private void RefreshVeteranEventsIcon(bool isNeedShowEventSkinTimeLine)
	{
	}

	private void RefreshLabEntranceView()
	{
	}

	private void RefreshSubSystemView()
	{
	}

	private void RefreshAllEntranceView()
	{
	}

	private void RefreshUnlockVFXEntrance()
	{
	}

	private void UpdateLevelEntrance(LevelEntranceDataManager.EntranceIdType entranceType)
	{
	}

	private void UpdateLeftBottomBtnGroupPosition(bool isShow)
	{
	}

	private void RefreshLatestMessage()
	{
	}

	private void RefreshChatRedTips()
	{
	}

	private void InitHideoutIAPBundle()
	{
	}

	private void AddHideoutIAPBunldeEntrance(uint eRevenueEntranceType, uint IAPBundleSubType = 0u)
	{
	}

	private void RemoveHideoutIAPBunldeEntrance(uint eRevenueEntranceType, uint IAPBundleSubType = 0u)
	{
	}

	private void TryShowHideoutIAPBunldeEntrance()
	{
	}

	private void PlayHideoutIAPBunldeTween()
	{
	}

	private void PlayHideoutTween()
	{
	}

	private void PlayIAPTween()
	{
	}

	private void UpdateHideoutAds()
	{
	}

	private void RefreshHideoutAds()
	{
	}

	private void UpdateIAPBundleActivityState()
	{
	}

	private void RefreshIAPBundleActivityState()
	{
	}

	private void OnRefreshIAPBundleActivityState()
	{
	}

	private void InitRevenueContainer()
	{
	}

	private void InitLobbyRightRevenueContainer()
	{
	}

	private void AddRevenueEntrance(uint eRevenueEntranceType)
	{
	}

	private void RemoveRevenueEntrance(uint eRevenueEntranceType)
	{
	}

	private void RefreshRevenueContainer(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void TryShowRevenueEntrance()
	{
	}

	private void TryShowLobbyRightRevenueEntrance()
	{
	}

	private void ClearLobbyRightRevenueEntrance()
	{
	}

	private void ShowTwoRevenueEntrances()
	{
	}

	private Transform GetEntranceContainerByType(ERevenueEntranceType entranceType)
	{
		return null;
	}

	private void ShowSingleRevenueEntrance()
	{
	}

	private void TryShowRevenueEntranceDetail(uint entranceType)
	{
	}

	private void RefreshLobbyGacha()
	{
	}

	private void RefreshDrawShop()
	{
	}

	private void RefreshPurchaseEvent()
	{
	}

	private void RefreshRelayMart()
	{
	}

	private void RefreshNewBieGacha()
	{
	}

	private void RefreshMysteryMall()
	{
	}

	private void RefreshPayment(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void RefreshFirstTimePayment()
	{
	}

	private void RefreshSecondTimePayment()
	{
	}

	private void RefreshGrowthFundV2Payment()
	{
	}

	private void RefreshOtherTypePayment(uint revenueEntranceType, UIModelPayment.PaymentButtonStyle paymentButtonType, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private uint GetPaymentData(UIModelPayment.PaymentButtonStyle paymentType, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
		return 0u;
	}

	private void RefreshBigEventTemplateByRevEntrance()
	{
	}

	private void RefreshBigEventTemplateByBigEventEntrance()
	{
	}

	private void RefreshFlashStoreByRevEntrance(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void RefreshFlashStoreByBigEventEntrance()
	{
	}

	private void RefreshAllBigEventEntrance(object[] data)
	{
	}

	private IEnumerator WaitForBigEventEntranceOpen(uint openTime)
	{
		return null;
	}

	private void RefreshNewPlayerSignin()
	{
	}

	private void RefreshPreVeteran(object[] data)
	{
	}

	private void RefreshVeteran()
	{
	}

	private void RefreshLocalActivityEntranceByTwoTypeBigEventEntrance()
	{
	}

	private IEnumerator DelayRefreshActivityEntrance()
	{
		return null;
	}

	private void RefreshActivityEntrance()
	{
	}

	private void RefreshShoppingMallEntrance(bool force = false)
	{
	}

	private void RefreshShoppingMallAdsBanner()
	{
	}

	private List<UIModelLobbyAds.AdInfo> GetLobbyShoppingMallBannerAdRes()
	{
		return null;
	}

	public void CloseInviteBoxWithUIEffect()
	{
	}

	public void CloseInviteBoxWithOutUIEffect()
	{
	}

	private void ShowInviteGroupBox()
	{
	}

	public void OpenInviteGroupBox(GroupInviteMemberType defaultInviteType = GroupInviteMemberType.Friend)
	{
	}

	private void OnInviteClick()
	{
	}

	private void OpenGameAssistTodayBattleReport()
	{
	}

	public void OnInGameReturnToLobby()
	{
	}

	public void StartReturnFromInGameAutoTask()
	{
	}

	private bool NeedStartReturnFromInGameAutoTask()
	{
		return false;
	}

	private bool CheckIsWorkShopAndEnterSceneEdit()
	{
		return false;
	}

	public void StartLoginAutoTask()
	{
	}

	private void BlockTasksForPriorityTask()
	{
	}

	private void OnBeginToGotoYard(object[] data)
	{
	}

	private void ResetPanels()
	{
	}

	private void Update()
	{
	}

	private void TryInitTips()
	{
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	private void InitCommonTipsCtrl(ETipsType type, int num)
	{
	}

	private void InitSoloTipsCtrl(ETipsType type, int num)
	{
	}

	private void InitTipsCtrl(ref UITipsNormalController ctrl, Transform trans, TipsIconType iconType, ETipsType eTipsType = ETipsType.None)
	{
	}

	private void RefreshWeaponSysNewTip()
	{
	}

	private void RefreshSubSystemLiveTip()
	{
	}

	private bool CanShowSubSystemLiveTip()
	{
		return false;
	}

	private void RefreshSubSytemRedPoint()
	{
	}

	private void RefreshBuildSystemTips()
	{
	}

	private void RefreshNewbiePresetGiftTips()
	{
	}

	private void CheckRankExchangeMallTips()
	{
	}

	private void CheckGachaFreeTips(object[] data = null)
	{
	}

	private void CheckDrawShopFreeTips(object[] data = null)
	{
	}

	private void RefreshLobbyGachaTips()
	{
	}

	private void RefreshLobbyGachaIchisCollectionRewardTips()
	{
	}

	private void RefreshLobbyDrawShopTips()
	{
	}

	public void RefreshLobbyBPRedTips()
	{
	}

	private void RefreshLobbyLoadoutBubble()
	{
	}

	public void HandleReturnToLobby()
	{
	}

	public void OnEventDataReady(LobbyEventType lobbyEventType, bool needRefresh = true)
	{
	}

	public void RefreshBubble(object[] objs)
	{
	}

	private bool IsBigEventTemplateEntranceShowed()
	{
		return false;
	}

	private void ResetBigEventTemplateEntranceIntro()
	{
	}

	private bool RefreshBigEventTemplateEntranceIntro()
	{
		return false;
	}

	private void ResetBigEventBubble()
	{
	}

	private bool IsBigEventBubbleCanShow()
	{
		return false;
	}

	private bool NeedShowBigEventIntro()
	{
		return false;
	}

	private void ResetLobbyGachaBubble()
	{
	}

	private bool ShowLobbyGachaIntroIfNeed()
	{
		return false;
	}

	private bool ShowLobbyDrawShopIntroIfNeed()
	{
		return false;
	}

	private bool IsLobbyDrawShopBubbleCanShow()
	{
		return false;
	}

	private void ResetLobbyDrawShopBubble()
	{
	}

	private bool IsLobbyGachaBubbleCanShow()
	{
		return false;
	}

	private void ResetBooyahPassBubble()
	{
	}

	private void ResetNewBieOfferBubble()
	{
	}

	private void ResetFlashStoreBubble()
	{
	}

	private bool IsFlashStoreBubbleCanShow()
	{
		return false;
	}

	private bool NeedShowFlshStoreIntro()
	{
		return false;
	}

	private bool NeedShowBooyahPassBubble()
	{
		return false;
	}

	private bool NeedShowNewBieOfferBubble()
	{
		return false;
	}

	private void ResetPreVeteranBubble()
	{
	}

	private bool IsPreVeteranBubbleCanShow()
	{
		return false;
	}

	private bool IsBooyahPassBubbleCanShow()
	{
		return false;
	}

	private bool IsNewBieOfferBubbleCanShow()
	{
		return false;
	}

	private bool ShowPreVeteranBubble()
	{
		return false;
	}

	private bool ShowVeteranBubble()
	{
		return false;
	}

	private bool IsVeteranBubbleCanShow()
	{
		return false;
	}

	private void ResetVeteranBubble()
	{
	}

	private bool ShowNewPlayerSigninIntroIfNeed()
	{
		return false;
	}

	private bool IsNewPlayerBubbleCanShow()
	{
		return false;
	}

	private void ResetNewPlayerBubble()
	{
	}

	private void OnClickStandardAds(object[] data)
	{
	}

	private void OnGetLoginAccountInfo()
	{
	}

	public bool HasGuideInLobby()
	{
		return false;
	}

	private void CreateLobbyGuide()
	{
	}

	private void OnCloseCommonGuide(object[] data)
	{
	}

	private void OnShowLobbyStartGameGuide(object[] data)
	{
	}

	private void OnShowPresetV3Guide(object[] data)
	{
	}

	private void OnShowLobbyModeEntranceGuide(object[] data)
	{
	}

	private void ShowPresetStartGameGuide()
	{
	}

	private void OnShowLobbyRankUnlockGuide(object[] data)
	{
	}

	private void ShowLobbyRankUnlockGuide(NewbieGuideId guideId, bool useBackendFlag)
	{
	}

	public void OnShowCSGameGuide(object[] data)
	{
	}

	private void OnClickCSGameGuide()
	{
	}

	private void OnGroupEnter(object[] param)
	{
	}

	private void OnStartMatchmakingHideNoticeChangeTeam(object[] param)
	{
	}

	private void OnGroupDismissHideNoticeChangeTeam(object[] param)
	{
	}

	private void OnGroupLeaveHideNoticeChangeTeam(object[] param)
	{
	}

	private void OnEndMatchmakingRefreshNoticeChangeTeam(object[] param)
	{
	}

	private void OnCloseTakePhoto(object[] objects)
	{
	}

	private void OnGroupQuit()
	{
	}

	private void PlayLobbyV2AnimationByType(string type)
	{
	}

	private void RecoverLobbyV2Animation()
	{
	}

	private AnimationState GetAnimStateByType(string type)
	{
		return null;
	}

	private void PlayGroupTween()
	{
	}

	private void InitTweenMask()
	{
	}

	private void InitLobbyVFX()
	{
	}

	private void FindLobbyVFXChild()
	{
	}

	private bool NeedShowLobbyFaultVFX()
	{
		return false;
	}

	private static bool IsFaultVFXAvailable()
	{
		return false;
	}

	private static bool IsFaultVFXNeeded(Type preNavigationType)
	{
		return false;
	}

	private bool RefreshLobbyFaultVFX()
	{
		return false;
	}

	private IEnumerator WaitFrameForAnimation()
	{
		return null;
	}

	private static bool PlayTransferTweenAlphaIfCleanAssets()
	{
		return false;
	}

	private void RefreshReturnVFX()
	{
	}

	private void StartNewbieGuide(object[] args)
	{
	}

	private void StopNewbieGuide(object[] args)
	{
	}

	private void NewbiePathGuideProgressUpdate(object[] args)
	{
	}

	private void OnStopLobbyGuide()
	{
	}

	public static void PrepareStartGuide()
	{
	}

	public void PrepareStopGuide(object[] data)
	{
	}

	private void NewbieRankGameGuide()
	{
	}

	private void NewbieMiguelGuide(int avatarId)
	{
	}

	private void NewbieNonPVEGuide()
	{
	}

	private void NewbieGachaGuide()
	{
	}

	private void NewbieLoadoutGuide()
	{
	}

	private void NewbieNonMatchAndNonRankGuide()
	{
	}

	private void NewbieSetMapModeGameGuide(ENewbieGuideType guideType)
	{
	}

	private void BindAccountGuide()
	{
	}

	public Vector3 GetLivTvPosForSplash()
	{
		return default(Vector3);
	}

	private void OnRefreshShoppingMallEntrance(object[] data)
	{
	}

	private void RefreshNoticeRecruitState(object[] data)
	{
	}

	private void RefreshNoticeChangeTeamState(object[] data)
	{
	}

	private void HideNoticeChangeTeam()
	{
	}

	private void SetNoticeChangeTeamVisible(bool visible, bool showCD = false)
	{
	}

	private void RefreshNoticeChangeTeamCDLabel()
	{
	}

	private void FinishNoticeChangeTeamQuickJoinCD(bool resetQuickJoin, bool showNormalImmediately)
	{
	}

	private bool CanShowNoticeChangeTeam(bool checkQuickJoinClick = true)
	{
		return false;
	}

	private void RefreshRelayMartEntranceAnim()
	{
	}

	private void InitSpecialBtnView()
	{
	}

	private void OpenSpecialBtnCtrl()
	{
	}

	public void RefreshBarragePanel()
	{
	}

	public void StartBarrage(bool IsClanWarOpen)
	{
	}

	public void CancelBarrage()
	{
	}

	public IBigEventTemplateLobbyIconBanner GetBigEventTemplateLobbyIconBanner()
	{
		return null;
	}

	public UIBigEventLobbyEntranceBaseController GetBigEventLobbyIconBanner(int eventId)
	{
		return null;
	}

	private void AddTaskInLobbyNavigationShowed(UINavigationData navigationData)
	{
	}

	private void RefreshNewbieRecruitByGroupInfo(bool forceRefreshInGroup = false)
	{
	}

	private void StartNewbieRecruitTick()
	{
	}

	private void StopNewbieRecruitTick()
	{
	}

	private void OnNewbieRecruitTick()
	{
	}

	private bool CanProcessNewbieRecruit()
	{
		return false;
	}

	private bool HasOnlineFriendsForNewbieRecruit()
	{
		return false;
	}

	private void LogNewbieTeamFloatingWindow(GroupNewbieRecruitTeamNtf ntf)
	{
	}

	private void ShowNewbieRecruitPanel(GroupNewbieRecruitTeamNtf ntf)
	{
	}

	private void StartNewbieRecruitDisappearTimer()
	{
	}

	private void HideNewbieRecruitPanel()
	{
	}

	private void ResetNewbieRecruitState()
	{
	}

	private void ShowTeamUpRecommend(object[] data)
	{
	}

	public void ShowTakePhoto()
	{
	}

	public void ShowHidePetInTakePhoto(bool show)
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	public bool IsTakePhotoState()
	{
		return false;
	}

	public UITakePhotoController GetTakePhotoController()
	{
		return null;
	}

	public Transform GetStartGameMainTransform()
	{
		return null;
	}

	public override void OnCloseAllPopupWindows()
	{
	}

	private void _003COnDataChanged_003Eb__224_0()
	{
	}

	private void _003CDelayRefreshActivityEntrance_003Eb__372_0()
	{
	}

	private void _003COnBeginToGotoYard_003Eb__390_0()
	{
	}

	private void _003CNewbieRankGameGuide_003Eb__506_0()
	{
	}

	private void _003CNewbieRankGameGuide_003Eb__506_1()
	{
	}

	private void _003CNewbieNonMatchAndNonRankGuide_003Eb__511_0()
	{
	}

	private void _003CNewbieNonMatchAndNonRankGuide_003Eb__511_1()
	{
	}

	private void _003CRefreshNoticeRecruitState_003Eb__516_0()
	{
	}

	private void _003CRefreshNoticeChangeTeamState_003Eb__517_0()
	{
	}

	private void _003CStartNewbieRecruitDisappearTimer_003Eb__540_0()
	{
	}

	private void _003CShowTeamUpRecommend_003Eb__543_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnCloseAllPopupWindows()
	{
	}
}
