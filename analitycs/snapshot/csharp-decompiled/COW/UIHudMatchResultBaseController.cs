using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHudMatchResultBaseController : UIHudResultShowBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__194_0;

		public static Predicate<TeammateStats> _003C_003E9__229_0;

		public static Predicate<uint> _003C_003E9__231_0;

		public static Converter<TeammateStats, FriendInfo> _003C_003E9__256_0;

		internal void _003CReturnToLobby_003Eb__194_0(HttpErrorCode errorCode, object res)
		{
		}

		internal bool _003CCheckAndPopTeammateRecommand_003Eb__229_0(TeammateStats info)
		{
			return false;
		}

		internal bool _003CCheckAndPopFriendRecommand_003Eb__231_0(uint type)
		{
			return false;
		}

		internal FriendInfo _003COnClickFastSendGiftBtn_003Eb__256_0(TeammateStats teamMate)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass229_0
	{
		public TeammateStats res;

		internal bool _003CCheckAndPopTeammateRecommand_003Eb__1(TeammateStats info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass280_0
	{
		public UIHudMatchResultBaseController _003C_003E4__this;

		public UGCMatchStats ugcMatchStates;

		internal bool _003CMatchStatsValidationForUGC_003Eb__0(UGCTeamStats item)
		{
			return false;
		}

		internal bool _003CMatchStatsValidationForUGC_003Eb__1(UGCPlayerStats item)
		{
			return false;
		}
	}

	private sealed class _003CDelayCallFakeThumUpForBRTutorial_003Ed__201 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<ulong> AIPlayerIDs;

		public int nums;

		private int _003Ccount_003E5__2;

		private int _003Ci_003E5__3;

		private int _003CAIPlayerIdIndex_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayCallFakeThumUpForBRTutorial_003Ed__201(int _003C_003E1__state)
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

	private sealed class _003CDelayCallFakeThumUpForCSTutorial_003Ed__202 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<ulong> AIPlayerIDs;

		private int _003Ccount_003E5__2;

		private int _003Ci_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayCallFakeThumUpForCSTutorial_003Ed__202(int _003C_003E1__state)
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

	private sealed class _003CDelayGoToMvp_003Ed__223 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudMatchResultBaseController _003C_003E4__this;

		private uint _003CmaxFrameToWait_003E5__2;

		private int _003CcurrentFrame_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayGoToMvp_003Ed__223(int _003C_003E1__state)
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

	private sealed class _003CPlayDataToNormalChangeAnim_003Ed__248 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudMatchResultBaseController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayDataToNormalChangeAnim_003Ed__248(int _003C_003E1__state)
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

	private sealed class _003CPlayNormalToDataChangeAnim_003Ed__249 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudMatchResultBaseController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayNormalToDataChangeAnim_003Ed__249(int _003C_003E1__state)
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

	protected const string ANIM_PARAM_BOOL_OPEN = "open";

	protected const string ANIM_PARAM_TRIGGER_CLOSE = "close";

	protected const string ANIM_PARAM_BOOL_DETAIL = "detail";

	protected const string ANIM_PARAM_BOOL_SKIPANI = "SkipAni";

	protected const string ANIM_PARAM_BOOL_DATA = "data";

	private const int AUTO_SHOW_DETAIL_COUNTDOWN = 20;

	private const int AUTO_RETURN_LOBBY_COUNTDOWN = 30;

	private const int DETAIL_BUTTON_CLICK_INTERVAL = 1;

	public const int MAX_AVATAR_COUNT = 4;

	public const int MAX_PENTA_AVATAR_COUNT = 5;

	public const string RESULT_DATA_BTN_ICON = "UI_Result_Data_icon";

	public const string RESULT_OVERVIEW_BTN_ICON = "UI_BG_TeamBattle_icon_file";

	protected EMatchResultPageType m_PageType;

	protected const string REPLAYTIPS_BACKGROUND_CLICK = "KEY_REPLAYTIPS_BACKGROUND_CLICK";

	protected const string REPLAYTIPS_SAVE_1 = "T_30_Z_RP_SAVE";

	protected const string REPLAYTIPS_SAVE_2 = "T_39_Z_RP_SAVE2";

	private const string ShowedPopMatchFeedbackKey = "ShowedPopMatchFeedback";

	protected float m_CountDownTime;

	private float m_CurrentDetailClickTime;

	protected bool m_NoFoundMatchResult;

	private bool m_IsShowUIData;

	protected bool m_HasShowDetailUI;

	protected bool m_IsShowDetailUI;

	private bool m_IsLowSetting;

	private bool m_HasPopedAddFriendTips;

	private bool m_IsLastUGCMatchResultNotify;

	protected bool m_IsNeedPopMatchFeedback;

	protected UIHudMatchFeedBackController m_UIMatchFeedBackController;

	private uint m_InstantSurveyDelayCall;

	private bool m_WaitingInstantSurveyData;

	protected UIHUDAIChatParentController m_HUDAIChatParentController;

	private bool m_IsBr;

	protected bool IsFirstShowRatingVFX;

	private int m_SavedGameCameraCullingMask;

	private TeammateStats m_MVPPlayerData;

	protected bool m_BiaoqianState;

	private List<int> m_InfoTypeList;

	private List<int> m_InfoTypeListData;

	protected int[] InfoTypeForUGC;

	private List<UIHudMatchResultItemBaseController> m_ItemCtrlList;

	private List<UIMatchResultProfileInfoController> m_ProfileInfoCtrlList;

	protected UIHudMatchResultItemBaseController m_SelfItemCtrl;

	protected Dictionary<ulong, ExtraPlayerDataForMatchResult> m_PlayerMatchResultDataMap;

	protected Dictionary<string, ExtraPlayerDataForMatchResult> m_ExtraMatchResultDatasForBot;

	private bool m_IsShowFastSendGift;

	private bool m_IsShowClanPopWnd;

	private bool m_HasWatchRewardVideo;

	private bool m_IsSubscribeWorkshop;

	protected UIHudMatchResultStateMachine m_StateMachine;

	private Camera m_ResultBGCamera;

	private Camera m_ResultAvatarCamera;

	private UIMaleAvatar m_MVPAvatar;

	protected UIHudMatchResultPosterTipsController m_PosterTipsCtrl;

	protected UIBaseView BaseView;

	protected Transform BaseCallSignContainer;

	protected UILabel GameModeTxt;

	protected UILabel GameMapTxt;

	protected Animator MatchResultAni;

	protected UITexture BGInFrontEndScene;

	protected GameObject MaskBG;

	protected UILabel MatchIdAndAccountId;

	protected GameObject EmulatorIcon;

	private GameObject m_ShareInfoContainer;

	protected Transform m_ProfileFormationTran;

	private UIButton m_ShareBtn;

	private UITable m_BottomLeftTable;

	private UIBaseController m_Age18LogoCtrl;

	private UIButton m_DetailBtn;

	private UIButton m_DataBtn;

	private UIButton m_NextBtn;

	private UIButton m_ModeNextBtn;

	protected UIButton m_ReplayBtn;

	protected UIButton m_BRMatchReviewBtn;

	private bool m_IsBRMatchReviewBtnActiveBeforeScreenshot;

	private UIGrid m_HQPageSwtichBtnGrid;

	protected UIButton m_AvatarPageBtn;

	protected UIButton m_NormalPageBtn;

	protected UIButton m_DataPageBtn;

	protected UIButton m_ReportBtn;

	protected UIButton m_BlockBtn;

	protected UIButton m_MatchFeedBackBtn;

	protected bool IsShowMatchFeedBackBtn;

	protected GameObject PosterShareIcon;

	protected GameObject NormalShareIcon;

	private UIGrid m_BattleTagGrid;

	protected ResourceID SoundDetailIn;

	protected ResourceID SoundDetailOut;

	protected GameObject WorkShopGo;

	protected UILabel NextBtnTime;

	protected UILabel NextBtnLabel;

	protected UIColor NextBtnColor;

	protected UILabel ResultDesc;

	protected GameObject ResultDescExRoot;

	protected UILabel ResultDescEx;

	protected GameObject ModeSuccessContainer;

	protected GameObject ModeFailedContainer;

	protected GameObject RankInfoContainer;

	protected UIGrid RewardBtnGrid;

	private UIButton m_FastSendGiftBtn;

	protected UIHudMatchResultHighlightTipsController HighlightTipsCtrl;

	private UIHudMatchResultLikePopupController likectrl;

	private bool m_LikeSwitch;

	private float m_likeInterval;

	private float m_likeTimeSendStamp;

	private float m_showTimeStamp;

	private float m_showTimeInterval;

	private List<ulong> m_ShowlikeAccountIds;

	private List<ulong> m_likeAccountIds;

	private List<ulong> m_allAccountIds;

	protected HashSet<ulong> m_hasShowLikeAccountIdsSet;

	private uint m_showlikesLimit;

	private uint showlikesLimitConfig;

	private ulong m_localPlayerID;

	protected bool isTeamMode;

	private const string Team_COLOR = "2993FFFF";

	private const string Oppo_COLOR = "DD6C2EFF";

	private const string Normal_COLOR = "FFBA00FF";

	protected UIHudMatchResultWorkShopPanelController m_WorkShopCtrl;

	private uint m_QuestionId;

	protected bool hasAdjusted;

	public bool HasPopedAddFriendTips
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public TeammateStats MVPPlayerData
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	protected List<int> InfoTypeList => null;

	protected List<int> InfoTypeListData => null;

	protected List<UIHudMatchResultItemBaseController> ItemCtrlList => null;

	protected Dictionary<ulong, ExtraPlayerDataForMatchResult> ExtraPlayerDataMap => null;

	protected GameObject ShareInfoContainer
	{
		set
		{
		}
	}

	protected UIButton ShareBtn
	{
		set
		{
		}
	}

	protected UITable BottomLeftTable
	{
		set
		{
		}
	}

	protected UIButton DetailBtn
	{
		set
		{
		}
	}

	protected UIButton DataBtn
	{
		set
		{
		}
	}

	protected UIButton NextBtn
	{
		set
		{
		}
	}

	protected UIButton ModeNextBtn
	{
		set
		{
		}
	}

	protected UIButton ReplayBtn
	{
		set
		{
		}
	}

	protected UIButton BRMatchReviewBtn
	{
		set
		{
		}
	}

	protected UIGrid HQPageSwtichBtnGrid
	{
		set
		{
		}
	}

	protected UIButton AvatarPageBtn
	{
		set
		{
		}
	}

	protected UIButton NormalPageBtn
	{
		set
		{
		}
	}

	protected UIButton DataPageBtn
	{
		set
		{
		}
	}

	protected UIButton ReportBtn
	{
		set
		{
		}
	}

	protected UIButton BlockBtn
	{
		set
		{
		}
	}

	protected UIButton MatchFeedBackBtn
	{
		set
		{
		}
	}

	protected UIGrid BattleTagGrid
	{
		set
		{
		}
	}

	protected UIButton FastSendGiftBtn
	{
		set
		{
		}
	}

	public List<int> GetCurrentInfoTypeList()
	{
		return null;
	}

	protected virtual bool IsShowReplayBtn()
	{
		return false;
	}

	protected virtual bool IsShowBRMatchReviewBtn()
	{
		return false;
	}

	protected virtual bool NeedCountDown()
	{
		return false;
	}

	public void Update()
	{
	}

	public void GenerateMatchResultForSpectator()
	{
	}

	protected override void OnUIInit()
	{
	}

	private void RestoreGameCameraCullingMask()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void InitLikeInfo()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void CreateAge18Logo()
	{
	}

	protected sealed override void OnMatchStatsChange(MatchStats stats, MatchIncome income)
	{
	}

	public sealed override void CreateProfileCallSign(AvatarProfileInfo data, int index)
	{
	}

	protected sealed override void PrepareShowAvatarData(out List<PlayerData> avatarData, out List<AvatarProfileInfo> profileData)
	{
		avatarData = null;
		profileData = null;
	}

	private void PrepareShowAvatarDataInternal(out List<PlayerData> avatarData, out List<AvatarProfileInfo> profileData)
	{
		avatarData = null;
		profileData = null;
	}

	protected virtual AvatarProfileInfo GetAvatarProfileData(PlayerData data)
	{
		return null;
	}

	protected virtual void AdjustCountDownLabelPos()
	{
	}

	private bool IsNotShowMatchResultAvatar()
	{
		return false;
	}

	private bool IsShowHQPageSwtichBtn()
	{
		return false;
	}

	protected virtual bool IsShowDetailBtn()
	{
		return false;
	}

	private bool IsGameModeHasDataPage()
	{
		return false;
	}

	private void PrepareShowAvatarDataInternalForUGC(out List<PlayerData> avatarData, out List<AvatarProfileInfo> profileData)
	{
		avatarData = null;
		profileData = null;
	}

	protected sealed override void ReturnToLobby()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	protected virtual bool IsShowWin()
	{
		return false;
	}

	protected void RepositionRewardBtnGrid()
	{
	}

	public static TeamTotalStats CalcTeamTotalStatsInfo(List<TeammateStats> players)
	{
		return default(TeamTotalStats);
	}

	protected void UpdateFakeLike(uint rank, uint kills = 0u)
	{
	}

	private IEnumerator DelayCallFakeThumUpForBRTutorial(int nums, List<ulong> AIPlayerIDs)
	{
		return null;
	}

	private IEnumerator DelayCallFakeThumUpForCSTutorial(List<ulong> AIPlayerIDs)
	{
		return null;
	}

	protected void UpdateInfoTitle(UILabel infoTxt, int index)
	{
	}

	protected void UpdateInfoTitle(UISprite infoSprite, int index)
	{
	}

	public void UpdateInfoTitleForUGC(UILabel label, int index)
	{
	}

	protected T OpenPlayerItemUI<T>(Transform parent, TeammateStats data, bool single) where T : UIHudMatchResultItemBaseController
	{
		return null;
	}

	public T OpenPlayerItemUI<T>(Transform parent, UGCPlayerStats stats, bool single) where T : UIHudMatchResultItemBaseController
	{
		return null;
	}

	protected void FillTeammateStatsToPlayerData(TeammateStats stats, PlayerData player)
	{
	}

	protected virtual uint GetKillCount(TeammateStats stats)
	{
		return 0u;
	}

	protected virtual uint GetDamage(TeammateStats stats)
	{
		return 0u;
	}

	protected void FillMatchStatsToPlayerData(MatchStats stats, PlayerData player)
	{
	}

	protected ExtraPlayerDataForMatchResult GetExtraPlayerDataForMatchResult(ulong accountID)
	{
		return null;
	}

	public ulong[] GetAllOtherPlayerAccountIds()
	{
		return null;
	}

	public bool IsAllTeammatesInSamePreFormedGroup()
	{
		return false;
	}

	public bool IsShowInviteBtn()
	{
		return false;
	}

	private void SetMapAndModeInfo()
	{
	}

	protected virtual bool CanUpdateCountDown()
	{
		return false;
	}

	private void CreateExtraPlayerDataForAllPlayers(MatchStats stats)
	{
	}

	protected void ResetInfoTypeList()
	{
	}

	public void ShowMatchResultInHistoryRecord(MatchRecordPersonal matchRecord)
	{
	}

	protected void ShowMatchResultUIData(MatchIncome income, MatchStats stats)
	{
	}

	protected void GoToMvp()
	{
	}

	protected IEnumerator DelayGoToMvp()
	{
		return null;
	}

	protected virtual void ShowInFrontEndScene()
	{
	}

	protected virtual void ShowInFrontEndUpdateBtn()
	{
	}

	private void OnStateMachineFinish()
	{
	}

	private bool IsResultOptApplyOpen()
	{
		return false;
	}

	private void ShowAvatarInfoUI()
	{
	}

	private void CheckAndPopTeammateRecommand()
	{
	}

	private TeammateStats BuildTestBehaviour(MatchStats matchStats)
	{
		return null;
	}

	private void CheckAndPopFriendRecommand()
	{
	}

	private void ShowAIChatView()
	{
	}

	private bool CheckAndShowMatchFeedback()
	{
		return false;
	}

	private void CheckAndShowInstantSurvey()
	{
	}

	private void ShowInstantSurveyAtMatchResult()
	{
	}

	private bool ShouldBlockInstantSurveyByInvitationTips()
	{
		return false;
	}

	private void OnInstantSurveyDataUpdate()
	{
	}

	private void CancelInstantSurveyDelayCall()
	{
	}

	private PlayerData GetCanRecommonedData()
	{
		return null;
	}

	protected virtual void OnClickNextBtn()
	{
	}

	protected virtual void OnClickModeNextBtn()
	{
	}

	private void OnClickReplayBtn()
	{
	}

	protected virtual bool SaveReplay()
	{
		return false;
	}

	private void ShowSaveReplayTips(string strContent)
	{
	}

	private void OnClickDetailsBtn()
	{
	}

	private void OnClickDataBtn()
	{
	}

	private void OnClickNormalPageBtn()
	{
	}

	protected virtual IEnumerator PlayDataToNormalChangeAnim()
	{
		return null;
	}

	protected virtual IEnumerator PlayNormalToDataChangeAnim()
	{
		return null;
	}

	protected virtual void OnClickDataPageBtn()
	{
	}

	private void RefreshFeedBackBtn()
	{
	}

	private void OnClickMatchFeedBackBtn()
	{
	}

	protected virtual void OnFeedBackWndShow()
	{
	}

	private void HideFeedBackBtn()
	{
	}

	private void OnClickAvatarPageBtn()
	{
	}

	private void OnClickFastSendGiftBtn()
	{
	}

	protected virtual bool GetDataBtnVisibility()
	{
		return false;
	}

	protected void ShowDetailUI()
	{
	}

	protected virtual void RefreshBtnState()
	{
	}

	protected void HideDetailUI()
	{
	}

	private void CheckNeedShowRewardBtn()
	{
	}

	private void OnFastSendGiftPanelClose(object[] data)
	{
	}

	private void ShowClanMatchResult(object[] data)
	{
	}

	public void SetTimeCutDown(object[] data)
	{
	}

	protected virtual void SetResultDescTextByRank(MatchStats stats)
	{
	}

	private int SortSpectator(SpectatorInteractionInfo a, SpectatorInteractionInfo b)
	{
		return 0;
	}

	private void AddExtraPlayerDataForMatchResult(ulong accountID, ulong localPlayerID, bool isFriend = false, string region = "", string nickName = "", bool isSameTeam = true, List<SpectatorInteractionInfo> spectatorDataList = null)
	{
	}

	private void OnMatchResultNoResultFound(object[] data)
	{
	}

	private void OnMatchResultLikeCountChange(object[] data)
	{
	}

	private void OnMVPLikeButtonPress(object[] data)
	{
	}

	private void HandleExtraPlayerDataOnMVPLikeButtonPress(ExtraPlayerDataForMatchResult extraData)
	{
	}

	private void SendLikeAccountIds()
	{
	}

	private void OnMatchResultFakeLikeRec(object[] data)
	{
	}

	private void OnMatchResultLikeRec(object[] data)
	{
	}

	private void OnMatchResultShowProfileInfo(bool isShow)
	{
	}

	protected void FindOnePersonSendFakeLikeFromList(List<TeammateStats> likeList, ulong myAccountID)
	{
	}

	private void ShowLikeListPopup()
	{
	}

	private void ShowLikePopup(string msg)
	{
	}

	private void CreateMVPAvatarInMatchResult(List<PlayerData> players, bool win)
	{
	}

	private bool MatchStatsValidationForUGC()
	{
		return false;
	}

	protected virtual void RefershMatchAchievementIcon(MatchStats stats)
	{
	}

	protected virtual int SortPlayerData(PlayerData player1, PlayerData player2)
	{
		return 0;
	}

	protected virtual int SortTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return 0;
	}

	public static int SortMatchTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return 0;
	}

	protected virtual bool NeedReSortByTeamIndex()
	{
		return false;
	}

	protected void ReSortByTeamIndex(List<TeammateStats> list)
	{
	}

	protected int SortTeammateDataByTeamIndex(TeammateStats player1, TeammateStats player2)
	{
		return 0;
	}

	protected virtual int[] GetInfoTypes()
	{
		return null;
	}

	protected virtual int[] GetInfoTypesData()
	{
		return null;
	}

	protected int[] GetInfoTypesForUGC(UGCMatchStats stats)
	{
		return null;
	}

	protected virtual void OnChangePageType()
	{
	}

	protected virtual void RefreshDetailUI(MatchStats stats)
	{
	}

	protected virtual void OnShowDetailUI(bool show)
	{
	}

	protected virtual void OnShowAvatarInfoUI()
	{
	}

	protected virtual void OnUpdate(float delta)
	{
	}

	protected virtual List<PlayerData> CreateShowAvatarPlayerData()
	{
		return null;
	}

	protected virtual EMatchResultIsWin CheckIsWin(MatchStats stats)
	{
		return EMatchResultIsWin.Win;
	}

	protected EMatchResultIsWin CheckIsWinForUGC(MatchStats stats)
	{
		return EMatchResultIsWin.Win;
	}

	public virtual void CloseReportAndBlock()
	{
	}

	protected virtual bool CheckIsWinTeamPlayerForSpectator(BHGGAEEHJCO playerID)
	{
		return false;
	}

	protected virtual bool IsNeedShowAvatar()
	{
		return false;
	}

	protected override void OnShareBtnClick()
	{
	}

	public static string SetMatchResultPlayerInfoString(UISprite sprite, EMatchResultPlayerInfoType type)
	{
		return null;
	}

	public BriefClanInfo GetMyTeamBriefClanInfo(MatchStats stats)
	{
		return null;
	}

	private void RefeshShareBtnIcon(MatchStats stats)
	{
	}

	public static string SetMatchResultPlayerInfoString(UILabel label, EMatchResultPlayerInfoType type)
	{
		return null;
	}

	public virtual void RefreshUISkinChange()
	{
	}

	private void _003COnUIOpen_003Eb__180_0(bool res)
	{
	}

	private bool _003CPrepareShowAvatarDataInternal_003Eb__185_1(PlayerData item)
	{
		return false;
	}

	private AvatarProfileInfo _003CPrepareShowAvatarDataInternal_003Eb__185_0(PlayerData x)
	{
		return null;
	}

	private bool _003CPrepareShowAvatarDataInternalForUGC_003Eb__193_0(UGCTeamStats item)
	{
		return false;
	}

	private bool _003CPrepareShowAvatarDataInternalForUGC_003Eb__193_1(UGCPlayerStats x)
	{
		return false;
	}

	private bool _003CPrepareShowAvatarDataInternalForUGC_003Eb__193_2(PlayerData item)
	{
		return false;
	}

	private bool _003CIsAllTeammatesInSamePreFormedGroup_003Eb__214_0(TeammateStats t)
	{
		return false;
	}

	private void _003CCheckAndShowInstantSurvey_003Eb__234_0()
	{
	}

	private bool _003CSetResultDescTextByRank_003Eb__265_0(UGCTeamStats item)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShareBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnMatchStatsChange(MatchStats P0, MatchIncome P1)
	{
	}

	public void _003C_003EiFixBaseProxy_PrepareShowAvatarData(out List<PlayerData> P0, out List<AvatarProfileInfo> P1)
	{
		P0 = null;
		P1 = null;
	}

	public void _003C_003EiFixBaseProxy_ReturnToLobby()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
