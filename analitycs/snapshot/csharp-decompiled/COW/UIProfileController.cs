using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public class UIProfileController : UIPreviewNavigationController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__187_0;

		internal void _003CCreateHistoryTab_003Eb__187_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass189_0
	{
		public UIProfileController _003C_003E4__this;

		public StandardSubTabItemViewData replaySubTabData1;

		public StandardTabItemViewData replayTabData;

		public int albumIndex;

		internal void _003CCreateRecordingsTab_003Eb__0()
		{
		}

		internal void _003CCreateRecordingsTab_003Eb__2()
		{
		}

		internal void _003CCreateRecordingsTab_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass191_0
	{
		public UIProfileController _003C_003E4__this;

		public StandardTabItemViewData creditTabData;

		internal void _003CCreateHonorScoreTab_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass235_0
	{
		public UIProfileController _003C_003E4__this;

		public ulong iSubTab;

		internal void _003CShowReplayKit_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass237_0
	{
		public UIProfileController _003C_003E4__this;

		public ulong iSubTab;

		internal void _003CShowReplay_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass358_0
	{
		public ulong currentAccountId;

		internal bool _003CShowEmotes_003Eb__0(TeammateEmoteInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass359_0
	{
		public ulong accountId;

		internal bool _003CPlayEmote_003Eb__0(TeammateEmoteInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass374_0
	{
		public UIProfileController _003C_003E4__this;

		public uint sparkStage;

		public uint collabStage;

		public uint[] appearanceItemIdsSelf;

		public uint[] appearanceItemIdsCollab;

		public proto.EFriend.SparkState stateSelf;

		public proto.EFriend.SparkState stateCollab;

		public uint selfLoginStreakDays;

		public uint collabLoginStreakDays;

		public uint colorIDSelf;

		public uint colorIDCollab;

		internal void _003CCreateSparkPetAvatar_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass427_0
	{
		public EShareLadderIconType iconType;

		public UIProfileController _003C_003E4__this;

		internal void _003COnShareReady_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass427_1
	{
		public EShareLadderIconType iconType;

		public UIProfileController _003C_003E4__this;

		internal void _003COnShareReady_003Eb__3()
		{
		}
	}

	private sealed class _003CMoveAvatarPerFrame_003Ed__332 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIProfileController _003C_003E4__this;

		public float destPos;

		private float _003CavatarPosX_003E5__2;

		private float _003CdeltaX_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMoveAvatarPerFrame_003Ed__332(int _003C_003E1__state)
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

	private sealed class _003CMoveObjectPerFrame_003Ed__333 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform trans;

		public float destPos;

		public UIProfileController _003C_003E4__this;

		private float _003CposX_003E5__2;

		private float _003CdeltaX_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMoveObjectPerFrame_003Ed__333(int _003C_003E1__state)
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

	private sealed class _003CMovePetPerFrame_003Ed__331 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIProfileController _003C_003E4__this;

		public float destPos;

		private float _003CposX_003E5__2;

		private float _003CdeltaX_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CMovePetPerFrame_003Ed__331(int _003C_003E1__state)
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

	private sealed class _003CShowAvatarAndPlayAnimDelay_003Ed__353 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIProfileController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowAvatarAndPlayAnimDelay_003Ed__353(int _003C_003E1__state)
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

	private bool PetIsActiveAfterTakePhoto;

	private AutoPopup m_AutoPopup;

	private UIProfileView m_View;

	private UIModelProfile m_Model;

	private UIModelCSLadderMatch m_CsLaddermodel;

	private UIModelLadderMatch m_LadderModel;

	private UIModelPeriodicLadderMatch m_PeriodicLaddermodel;

	private UIModelCSPeakTournamentLadderMatch m_CSPeakTournamentLaddermodel;

	private UIModelWeaponPower m_WeaponPowerModel;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private UIModelLeaderBoardTitle m_LeaderBoardTitleModel;

	private UIModelSparkPet m_ModelSparkPet;

	private UIModelPreVeteran m_ModelPreVeteran;

	private UIModelHuntingGround m_ModelHuntingGround;

	private UIModelEvoPass m_ModelEvoPass;

	private UIModelProfileCustom m_ModelCustom;

	private UIModelQRCode m_ModelQRCode;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private List<UIHistoryTeammateController> m_HistoryTeammate;

	private List<uint> m_GameModeListShowKDRatio;

	private ProfileFullTab m_ChooseTab;

	private ProfileShowMatchMode m_ChooseShowMatchMode;

	private const int m_FightTypeAll = 3;

	private const int m_TrendALL = 3;

	public static int SHOW_EP_LIMIT;

	public const string LADDER_MATCH = "TXT_OB5_HISTORY_RANK";

	public const string CASUAL_MATCH = "TXT_OB5_HISTORY_CASUAL";

	public const string ROOM_MATCH = "TXT_OB7_ZJS_CUSTOM_TITLE";

	public const string SAVE_REPLAY_KEY = "SAVE_REPLAY_KEY_OB49";

	public const uint POSITIVE_DELTA_COLOR = 4284678115u;

	public const uint NEGATIVE_DELTA_COLOR = 4294912512u;

	public const int RankLeadBoardSize = 100;

	private ulong m_AccoutId;

	private ClanInfo m_ClanInfo;

	private int[] m_EwardrobeTypeList;

	private List<UIProfileFightDataItemController> m_ProfileFightDataListController;

	private UIProfileFightDataItemController m_CurrentShowFightDataController;

	private UIProfileFightDataItemController m_PeriodicFightDataController;

	private uint[] m_DefaultClothes;

	private float m_ScreenshotbgoriginWidth;

	private float m_ScreenshotlineoriginWidth;

	private UINavigationUtil.UINavagationProfileType m_profileType;

	private UIButton m_LastButton;

	private ELive.FollowerType m_CurrentType;

	private BaseItemInfo m_PinItemInfo;

	private UIEmoteShowPanelController m_EmotePanelController;

	private UITakePhotoController m_UITakePhotoController;

	private UIReplayNodeController m_ReplayController;

	private UIProfileCreditController m_CreditController;

	private UIProfileReportController m_ReportController;

	private UIReplayKitNodeController m_ReplayKitController;

	private UIProfileAlbumController m_AlbumController;

	private UIProfileWeaponNodeController m_WeaponTitleController;

	private UIProfileWishListController m_WishListController;

	private UIProfileCraftlandController m_CraftlandController;

	private UIUGCCreatorLevelIconController m_CreatorLevelIconCtrl;

	private UIStandardDrawerTabRemakeController m_TabCtrl;

	private bool IsShowAlbumGuide;

	private bool m_BtnMarryState;

	private bool m_BtnPrimeState;

	private bool m_BtnStreamingState;

	private bool m_BtnAddfriendState;

	private bool m_BtnShareBtnState;

	private bool m_BtnCreditState;

	private bool m_BtnCreatorLvState;

	private bool m_BtnGameBuffState;

	private bool m_BtnCustomProfileBtnState;

	private bool m_BtnQRCodeState;

	private bool m_BtnLimitedTimeRankState;

	private bool m_FightBrMenuState;

	private bool m_FightCsMenuState;

	private bool m_Deslabel1State;

	private bool m_ProfileNodeALlShareState;

	private bool m_ProfileNodeRulteState;

	private bool m_HistoryGotoButton;

	private bool isShowMarry;

	private bool isFromBoard;

	private UIPopMenuSmallControler m_ModeCsMenu;

	private UIPopMenuSmallControler m_ModeBrMenu;

	private string m_SelectBr;

	private string m_SelectCS;

	private List<PopMenuData> m_ModeBRMenuList;

	private List<PopMenuData> m_ModeCSMenuList;

	private List<string> m_ModeStrBRMenuList;

	private List<string> m_ModeStrCSMenuList;

	private Dictionary<string, uint> m_ModeStrCSMenuListToSubMode;

	private string m_SelectedOnLineTime;

	private string m_SelectedActiveTime;

	private string m_SelectedModePrefer;

	private MatchRecordPersonal m_MatchData;

	private string[] HistoryProfileItemAnimationArr;

	private List<Transform> HistoryProfileItemTranform;

	private Vector3 clonePos;

	private bool m_HasPlayedProfileEnterTeamAnimtion;

	private bool m_IsOccupationSharing;

	private bool m_PlayCommonVfx;

	private bool m_PlayCsVfx;

	private bool m_IsUserSelf;

	private bool m_IsFirstShowLevelUpBubble;

	private ulong m_UserAccountId;

	private ulong m_ClickReplayMatchID;

	private bool m_GoposSet;

	private ulong m_GoposSubType;

	private bool m_FirstEnter;

	private UILeaderBoardTitleCommonController m_LeaderBoardTitleCommonCtrl;

	private UIProfilePlayerPreferenceSettingPopWndController m_UIProfilePlayerPreferenceSettingPopWndCtrl;

	private List<MacthAchievementItem> mlistMacthAchievementItems;

	private uint replayDelayKey;

	private UIModelAchievement m_ModelAchievement;

	private UIModelCollection m_ModelCollection;

	private UIModelClan m_ModelClan;

	private UIModelPrime m_ModelPrime;

	private UIModelRole m_ModelRole;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private bool m_OpenRecentVisitor;

	private bool m_OpenQRCodeProfile;

	private UIProfileSkinPreviewComponentController m_SkinPreviewComponentCtrl;

	private List<uint> m_ClothIDList;

	private List<uint> m_ClothIDWithoutSetList;

	private uint m_WeaponSkinID;

	private uint m_GroupAnimID;

	private HashSet<uint> m_EffectUnlockItemList;

	private bool m_IsNeedGotoCraftlandTab;

	private ProfileTab m_ChoosenMainTab;

	private int? m_ChoosenSubTab;

	private static uint m_RequestShowBoardDataOrder;

	private UILaunchTagFrameController m_LaunchTag;

	private uint m_ShareDelayCall;

	private UILimitedTimeRankIconController m_LimitedTimeRankIcon;

	private const string m_CreditLevelChangeTabKey = "CreditLevelChangeTabKey";

	private bool m_GoToSettingFromPrime;

	private bool m_HasPlayPrimeIn;

	private GameObject m_PrimeInAnimObj;

	private Animation m_PrimeInAnim;

	private float m_PrimeInAnimShowTime;

	private uint m_PrimeInAnimDestroyDelayCall;

	public bool InSkinPreview;

	private UITipsNormalController m_TipsCtrl;

	private UISparkPetAvatarWindowController m_SparkPetAvatarWindowController;

	public static List<Type> InterestedModel;

	private static List<string> UI3DOBJECT_NAMES;

	private UIProfileHistoryNodeController m_HistoryNode;

	private UIUtils.ScreenshotType m_CurrentScreenshotType;

	private GameObject m_CacheHeroicBREffect;

	private GameObject m_CacheHeroicCSEffect;

	private uint m_RecentVisitorNewAddNum;

	private float AVATAR_PREVIEW_BORDER_ORIGINAL;

	private float AVATAR_PREVIEW_BORDER_RIGHT;

	private float AVATAR_PREVIEW_BORDER_MID;

	private float PET_PREVIEW_BORDER_MID;

	private float PET_PREVIEW_BORDER_LEFT;

	private float PERSONAL_SHOW_NODE_ORIGINAL;

	private float PERSONAL_SHOW_NODE_RIGHT;

	private float BG_ORIGINAL;

	private float BG_RIGHT;

	private float BG_MID;

	private Coroutine m_MovingBGCoroutine;

	private Coroutine m_MovingAvatarCoroutine;

	private Coroutine m_MovingPetCoroutine;

	private bool m_IsSkinPreviewShow;

	private uint m_AvatarId;

	private bool m_NeedSwitchAvatar;

	private uint m_CurrentSelectItemId;

	private const uint m_Rate = 3u;

	private const float m_LeftTabItemLength = 214f;

	private bool m_PreviewAvatarGunHidden;

	private uint m_ShowAvatarAndPlayAnimDelayCall;

	private uint m_ShowOrHideCreatedAvatarDelayCall;

	private uint m_AddEmoteHandlerDelayCall;

	private uint m_InitAbReadyStateDelayCall;

	private bool m_IsAvatarCreating;

	private float m_PetLobbyScale;

	private UIMaleAvatar m_Avatar;

	private UIPetAvatar m_PetAvatar;

	private uint m_AsyncCreateSelfPetTicket;

	private uint m_CreatePetAvatarDelayCall;

	private uint m_CreateSparkPetAvatarDelayCall;

	private UIProfileOccupationController m_OccupationCtrl;

	private UIProfileCustomCellGridController m_LeftGridCtrl;

	private UIProfileCustomCellGridController m_RightGridCtrl;

	private UIProfilePersonProfileInfoController m_PersonBoardCtrl;

	private bool m_IsCustomProfilePreviewShow;

	private bool m_IsCustomProfileLeftInfoReady;

	private bool m_IsCustomProfileRightInfoReady;

	private bool m_NeedRefreshCustomProfileRightData;

	private uint m_ShareDelayCallProfileCustomGuide;

	private float AVATAR_PREVIEW_BORDER_LEFT;

	private float BG_LEFT;

	private const float PERSONAL_SHOW_NODE_LEFT = -466f;

	private const float PERSONAL_SHOW_NODE_SIZE = 474f;

	private const string CLOSE_BTN_NAME = "UI_Common_Window_Close_Icon";

	private const string RETURN_BTN_NME = "UI_Icon_Return";

	private bool m_IsSharing;

	private Vector3 SHARE_AVATAR_POSITION_COMMMON;

	private Vector3 SHARE_PET_POSITION_COMMON;

	private Vector3 SHARE_PET_POSITION_HISTORY_OFFSET;

	private bool ShouldMaskProfileData => false;

	public UIProfilePersonProfileInfoController PersonBoardCtrl => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public static void BeforeInit(ulong accountID, UINavigationUtil.UINavagationProfileType profileType)
	{
	}

	private void OnHistoryDetailClick()
	{
	}

	private void GenerateModeBrMenu()
	{
	}

	private void OnModeBrMenuSelect(object obj)
	{
	}

	private void GenerateModeCSMenu()
	{
	}

	private void OnModeCSMenuSelect(object obj)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void RefreshSparkPetSocialAreaLight()
	{
	}

	private void TakePhotoChangeUI(bool isShow)
	{
	}

	private void InitTabWithChooseTab(bool chooseMainTab)
	{
	}

	private void SetReplayTabVisible()
	{
	}

	private void SetCraftlandTabVisible(bool visible)
	{
	}

	private void SetTabVisible(bool visible, ProfileTab profileTab)
	{
	}

	private void TrySendLangr(AccountPersonalShowInfo info)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnSendShowTimeEvent(ref string eventLogKey, ref EventLogger.EventPageDetentionTime eventLog)
	{
	}

	private void RefreshProfileNodeUI(object[] data)
	{
	}

	private void ChooseFirstTab()
	{
	}

	public void ChooseMainTab(ProfileTab tabIndex)
	{
	}

	private void ChooseSubTab(ProfileTab tabIndex, int subTabIndex)
	{
	}

	public void ShowPrimeIn()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void OnCloseTakePhoto(object[] objects)
	{
	}

	private void OnShowProfileCreditRules()
	{
	}

	private void OnProfileNodeAllShare()
	{
	}

	private void OnTakePhotoBtnClick()
	{
	}

	public void ShowHidePetInTakePhoto(bool show)
	{
	}

	private void OnRecentVisitorBtnClick()
	{
	}

	private void OnPersonalQRCodeBtnClick()
	{
	}

	private void OnHistoryGotoBtnClick()
	{
	}

	private void OnPhotoWallBtnClick()
	{
	}

	private void OnAddFriendCountLimitReject(object[] data)
	{
	}

	public override List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	private void CreateTabCtrl()
	{
	}

	private void CreateAllTab()
	{
	}

	private void Update()
	{
	}

	private void SetTabView()
	{
	}

	private void SetBannedStateTabVisible()
	{
	}

	private void CreateGalleryTab()
	{
	}

	private void ClearAlbumGuide()
	{
	}

	private void CreateOverViewTab()
	{
	}

	private void CreateHistoryTab()
	{
	}

	private StandardSubTabItemViewData CreateAlbumSubTabData()
	{
		return null;
	}

	private void CreateRecordingsTab()
	{
	}

	private void CreateCarftlandTab()
	{
	}

	private void CreateHonorScoreTab()
	{
	}

	private void CreateWishListTab()
	{
	}

	private void CreateWeaponTitleTab()
	{
	}

	private void SetProfileFightDataVisible(ProfileFullTab profileFullTab)
	{
	}

	private void ShowCsNodeALLbtn()
	{
	}

	private void OnShowAvatarEmotePanel(object[] data)
	{
	}

	private void OnUpdateLegPos()
	{
	}

	private void OnCloseEmotePanel(object[] data)
	{
	}

	private void RefreshProfileFightListVfxState(bool show, int index)
	{
	}

	private void ShowDetailDataPanelAnimation(object[] data)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void ShowPersonalProfile(uint type)
	{
	}

	private void OnAddFriend()
	{
	}

	private void SendShareBtnClickLog()
	{
	}

	private void ShowCreditIcon()
	{
	}

	private void ShowCreatorLvIcon()
	{
	}

	private void ShowLimitedTimeRankIcon()
	{
	}

	private void ShowGameBufIcon()
	{
	}

	private void ShowVBadgeIcon()
	{
	}

	public void RefreshPrimeBg(EProfileBgType type)
	{
	}

	private void RefreshPrimeIcon()
	{
	}

	private void RefreshSimulatorIcon()
	{
	}

	private void OnSimulatorIconClick()
	{
	}

	private void ShowMarryInfo()
	{
	}

	private void ShowEquippedLaunchTag()
	{
	}

	private void ShowAccountBannedInfo()
	{
	}

	private void UpdateBannedAccountClanInfo(bool request = true)
	{
	}

	private void UpdateBannedAccountClanIconAndName()
	{
	}

	private void UpdateBannedInfo()
	{
	}

	private void ShowPersonalBoard()
	{
	}

	private void ShowPersonalAvatar(bool force = false)
	{
	}

	private void RefreshUserInfo()
	{
	}

	private void UpdateHeadshot()
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshTeammateFriendBtnShow()
	{
	}

	public UINavigationUtil.UINavagationProfileType GetProfileType()
	{
		return UINavigationUtil.UINavagationProfileType.ProfileDefault;
	}

	private void ShowHistoryRecord()
	{
	}

	public void ShowRankHistory(UINavigationUtil.UINavagationProfileType _profileType = UINavigationUtil.UINavagationProfileType.ProfileDefault)
	{
	}

	public void ShowCredit(UINavigationUtil.UINavagationProfileType _profileType, ulong iSubTab)
	{
	}

	public void ShowWeaponTitle()
	{
	}

	public void ShowLeaderBoardTitleProfile()
	{
	}

	public void ShowCraftland()
	{
	}

	public void ShowWishList()
	{
	}

	public void ShowReplayKit(ulong iSubTab)
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	public void ShowReplay(ulong iSubTab)
	{
	}

	private void CloseAllNode()
	{
	}

	private void _ShowRankHistory()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	private void RestoreBtnState()
	{
	}

	private void RestoreBtnState2()
	{
	}

	private void ResetBtnState2()
	{
	}

	private void ResetBtnState()
	{
	}

	private void ShowOrHidePreview(bool flag)
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnTeamModeBtnClick()
	{
	}

	private void OnTotalBtnClick()
	{
	}

	private void OnCasualBtnClick()
	{
	}

	private void SetDefaultClick()
	{
	}

	private void OnCsLifeClick()
	{
	}

	private void OnCsBtnClick()
	{
	}

	private void OnRankCsBtnClick()
	{
	}

	private void OnCsPeakTournamentClick()
	{
	}

	private void ShowPeriodicRankModeData(object[] param)
	{
	}

	private void RefreshCurrentVisibleProfileStats()
	{
	}

	private void RefreshCurrentBRProfileStats()
	{
	}

	private void RefreshCurrentCSProfileStats()
	{
	}

	private void RefreshCurrentPeriodicProfileStats()
	{
	}

	private void ShowCSRankModeData(uint matchmode)
	{
	}

	private void ShowCSPeakTournamentModeData()
	{
	}

	private void OnRankBtnClick()
	{
	}

	private void RefreshProfileTeamModestate(int type)
	{
	}

	private void OnCreditIconClick()
	{
	}

	private void OnCreatorLvClick()
	{
	}

	private void OnGotoCreatorLvProfile()
	{
	}

	private void OnVBadgeIconClick()
	{
	}

	private void OnLimitedTimeRankIconClick()
	{
	}

	private void OnGameBufIconClick()
	{
	}

	private bool IsClanWar(uint matchMode, uint gameMode)
	{
		return false;
	}

	private void PlayAnimByAnimClip(int index)
	{
	}

	private void InitAnimState()
	{
	}

	private void InitProfileGridTransform()
	{
	}

	private void ResetProfileState()
	{
	}

	private void RefreshRecentVisitorNewAddNum()
	{
	}

	private void ShowSelfLeaderBoardTitle()
	{
	}

	private bool CheckLeaderboardTitleGuideData()
	{
		return false;
	}

	private void ShowLeaderboardTitleGuide()
	{
	}

	private void ShowFriendLeaderBoardTitle()
	{
	}

	private void ShowOtherSparkPet()
	{
	}

	public bool ShouldShowSparkPetInProfile()
	{
		return false;
	}

	public UISparkPetAvatarWindowController GetSparkPetAvatarWindow()
	{
		return null;
	}

	private void RefreshProfileSparkPetVisibility()
	{
	}

	private void HideLobbySparkPet()
	{
	}

	private void ShowLobbySparkPet()
	{
	}

	public override bool NavigationCanAccess()
	{
		return false;
	}

	public bool IsUserSelf()
	{
		return false;
	}

	private void OnLeaderBoardTitleClick()
	{
	}

	private void ShowProfilePlayerPreferenceSettingPopWnd()
	{
	}

	private void RefreshAccountId(ulong accountId)
	{
	}

	private void OnChangeAvatarRefreshProfile()
	{
	}

	private void OnFinishGroupAnim()
	{
	}

	private void OnRefreshCallsign()
	{
	}

	private void RefreshLeftTopBar(ulong account, bool showProfile)
	{
	}

	private void OnPersonSignatureReportBtnClick()
	{
	}

	private void OnSkinPreviewBtnClick()
	{
	}

	private void OnSkinPreviewWithdrawArrowClick()
	{
	}

	private void ShowSkinPreview()
	{
	}

	public void ShowPreviewUI(uint itemID)
	{
	}

	private void SetPreviewAvatarGunPose(bool holding)
	{
	}

	private void ClickDefaultClothStyle(uint itemId)
	{
	}

	private void MovePet(float destPosX, bool instant = false)
	{
	}

	private void MoveAvatar(float destPos, bool instant = false)
	{
	}

	private void MoveUI(float bgPos, float nodePos, bool instant = false, bool onlyMoveBgObj = false)
	{
	}

	private void OnPersonShowNodeTweenPosFinish()
	{
	}

	private IEnumerator MovePetPerFrame(float destPos)
	{
		return null;
	}

	private IEnumerator MoveAvatarPerFrame(float destPos)
	{
		return null;
	}

	private IEnumerator MoveObjectPerFrame(Transform trans, float destPos)
	{
		return null;
	}

	private void SetAvatarPos(float x)
	{
	}

	private void SetObjectPosX(Transform trans, float x)
	{
	}

	private bool OutfitHasSet()
	{
		return false;
	}

	private void RefreshPreviewAvatarAndHideUI(object[] param)
	{
	}

	private void OnUpdatePersonInfo(object[] data)
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public override bool IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	public FrontEndPreviewComponent_Profile GetFrontEndPreviewComponentInternal()
	{
		return null;
	}

	protected override FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	protected override bool NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}

	private void GetAvatarData(AccountPersonalShowInfo info)
	{
	}

	private void UpdatePreviewBroder()
	{
	}

	private void UpdateAvatar(AccountPersonalShowInfo info)
	{
	}

	private IEnumerator ShowAvatarAndPlayAnimDelay()
	{
		return null;
	}

	private void ShowAvatarAndPlayAnim()
	{
	}

	private void ShowOrHideCreatedAvatar()
	{
	}

	private void AddEmoteHandler()
	{
	}

	private void InitAbReadyState()
	{
	}

	private void ShowEmotes(GEvent _data)
	{
	}

	private void PlayEmote(UIMaleAvatar avatar, ulong accountId, uint emoteId, List<TeammateEmoteInfo> teammateEmoteInfoList, EDuoEmoteStage eDuoEmoteStage, EmoteExtralInfo extralInfo)
	{
	}

	private void ShowLocalAvatarTransformer(GEvent _data)
	{
	}

	private void StopEmote(ulong accountId)
	{
	}

	private void CreatePetAvatar()
	{
	}

	private void CreatePetAvatarInternal()
	{
	}

	private void OnSelfOwnedPetCreated(uint ticket, UIPetAvatar petAvatar)
	{
	}

	public Camera GetPetCamera()
	{
		return null;
	}

	private void SetAvatarPet()
	{
	}

	private void CancelAsyncResLoad()
	{
	}

	private void CreateSparkPetAvatar(uint sparkStage, uint collabStage, uint[] appearanceItemIdsSelf, uint[] appearanceItemIdsCollab, proto.EFriend.SparkState stateSelf, proto.EFriend.SparkState stateCollab, uint selfLoginStreakDays = 0u, uint collabLoginStreakDays = 0u, uint colorIDSelf = 1u, uint colorIDCollab = 1u)
	{
	}

	private void CreateSparkPetAvatarInternal(uint sparkStage, uint collabStage, uint[] appearanceItemIdsSelf, uint[] appearanceItemIdsCollab, proto.EFriend.SparkState stateSelf, proto.EFriend.SparkState stateCollab, uint selfLoginStreakDays = 0u, uint collabLoginStreakDays = 0u, uint colorIDSelf = 1u, uint colorIDCollab = 1u)
	{
	}

	private void SetOccupationTabVisible()
	{
	}

	private void CreateOccupationTab()
	{
	}

	private bool CanShowCSPeakOccupation()
	{
		return false;
	}

	public void StartPrepareOccupaitonShare()
	{
	}

	private void OnOccupaitonShareReady(UIStatedAvatar s)
	{
	}

	public void OccupationShareFinished()
	{
	}

	private void GetOccupationInfo()
	{
	}

	public void ShowOccupation(ulong subType)
	{
	}

	public void ShowSettingWndFromPrime()
	{
	}

	private void TryGotoOccupationPos()
	{
	}

	private ProfileDataPunishSwitchConfig GetCustomProfilePunishConfig()
	{
		return null;
	}

	private void RefreshCustomProfilePunishState()
	{
	}

	private void OnPersonBtnCustomProfilePreviewClick()
	{
	}

	private void OnPersonBtnCustomProfilePreviewReturnClick()
	{
	}

	private void OnPersonBtnCustomProfileEditClick()
	{
	}

	private void SetCustomProfilePreviewUIState(bool isPreview)
	{
	}

	private void InitCustomProfile(bool isLeft)
	{
	}

	private void RefreshPersonalBoard()
	{
	}

	private void SetCloseButtonSprite(string spriteName)
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	private void SyncCustomProfilePreviewState()
	{
	}

	private void RequestProfileCustomData(bool needLeft, bool needRight)
	{
	}

	private void RefreshCustomProfile(bool isLeft)
	{
	}

	private void HideCustomProfile(bool isLeft)
	{
	}

	private void RefreshAvatarAndUIPosition()
	{
	}

	private void ShowProfileCustomGuide()
	{
	}

	private bool ProfileCustomExtendBtnGuide()
	{
		return false;
	}

	private void ProfileCustomEditBtnGuide()
	{
	}

	private void OnProfileCustomEditBtnGuideClose()
	{
	}

	public void StartPrepareShare()
	{
	}

	private void OnShareReady(UIStatedAvatar s)
	{
	}

	public void ShareFinished()
	{
	}

	private void SetDragEventListenerEnable(bool enable)
	{
	}

	public Camera GetPreviewCamera()
	{
		return null;
	}

	public bool GetIfInCustom()
	{
		return false;
	}

	public bool IsTakePhotoState()
	{
		return false;
	}

	private void ShowAlbumGuide()
	{
	}

	public UIMaleAvatar GetCreatedAvatar()
	{
		return null;
	}

	private void ShowPetLobbyAction(object[] param)
	{
	}

	private void ReplayFightDataItemAnimations()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnReceiveAuthorInfo(WorkshopAuthorInfo info)
	{
	}

	private void CheckUserSelfCraftlandTabVisibility(WorkshopAuthorInfo info)
	{
	}

	private void _003CShowPrimeIn_003Eb__165_0()
	{
	}

	private void _003CCreateGalleryTab_003Eb__184_0()
	{
	}

	private void _003CCreateOverViewTab_003Eb__186_0()
	{
	}

	private void _003CCreateOverViewTab_003Eb__186_1()
	{
	}

	private void _003CCreateOverViewTab_003Eb__186_2()
	{
	}

	private void _003CCreateHistoryTab_003Eb__187_1()
	{
	}

	private void _003CCreateAlbumSubTabData_003Eb__188_0()
	{
	}

	private void _003CCreateCarftlandTab_003Eb__190_0()
	{
	}

	private void _003CCreateWishListTab_003Eb__192_0()
	{
	}

	private void _003CCreateWeaponTitleTab_003Eb__193_0()
	{
	}

	private void _003CCreateOccupationTab_003Eb__378_0()
	{
	}

	private void _003CCreateOccupationTab_003Eb__378_1()
	{
	}

	private void _003CCreateOccupationTab_003Eb__378_2()
	{
	}

	private void _003COnShareReady_003Eb__427_0()
	{
	}

	private void _003COnShareReady_003Eb__427_1()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSendShowTimeEvent(ref string P0, ref EventLogger.EventPageDetentionTime P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}

	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public bool _003C_003EiFixBaseProxy_NavigationCanAccess()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	public FrontEndPreviewComponent _003C_003EiFixBaseProxy_GetFrontEndPreviewComponent()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_NeedRecoverPreviewOnNavigationShowed()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
