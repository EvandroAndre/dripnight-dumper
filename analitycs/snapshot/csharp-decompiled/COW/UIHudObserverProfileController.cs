using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudObserverProfileController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__82_0;

		public static Action _003C_003E9__82_1;

		internal void _003CSetControllerCursorEvent_003Eb__82_0()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__82_1()
		{
		}
	}

	private UIHudObserverProfileView m_View;

	private UIBaseProfileInfoController m_Profile;

	private BHGGAEEHJCO m_TargetPlayerID;

	private ulong m_TargetUserID;

	private string m_LockRegion;

	private string m_TargetPlayerName;

	private UITimeLabelHelper m_TimeHelper;

	private bool m_ShowReviveCountDown;

	private bool m_ShowingRevive;

	private bool m_ShowingBackBtn;

	private bool m_ShowingQuickMatch;

	private Vector3 m_oriOBDropButtonPosition;

	private Vector3 m_OBDropButtonPosition;

	private TweenAlpha tweenAlpha;

	private TweenPosition tweenPosition;

	private EventDelegate m_Delegate;

	private int m_BuyReviveTimes;

	private bool m_HaveSetFateRandomRevive;

	private List<uint> m_OpenQuickGameModeList;

	private UIQuickMatchController m_QuickMatchController;

	private UIQuickMatchController m_QuickMatchBigController;

	private bool m_NeedMoveUpSwitch;

	private bool m_HasMoveUpSwitch;

	private UIModelMatch m_ModelMatch;

	private bool m_NeedFirstShowGift;

	private UIMatchMakingManager m_MatchMakingManager;

	private UIModelFriendObserve m_ModelFriendObserver;

	private UIModelRankingTips m_ModelRankingTips;

	private bool m_IsFriendObserver;

	private bool m_IsTargetFriend;

	private bool m_IsTrackTeammateFriend;

	private bool m_IsUseCustomReviveRoot;

	private UIHudCabinWaitingWishController m_HudCabinWaitingWishController;

	private UIHudObserverInteractionController m_ObserverInterCtrl;

	private UIHudRankingTipsBubbleController m_RankingTipsCtrl;

	private bool m_DelayCreateQuickMatch;

	private bool m_NeedShowAskRevive;

	private bool m_ShowingAskRevive;

	private bool m_IsTargetTeammate;

	private bool m_TrainingGameEnableAutoRevive;

	private bool m_AutoReviveHasChangeTopContentHeight;

	private bool m_AutoReviveHasChangeSwitchObserverHeight;

	private bool m_IsBooyahPostInit;

	private VisualInstanceHolder m_RatingFXHolder;

	private ERatingLevel m_CurrentRatingLevel;

	private bool m_HasNotiGSAutoRevive;

	private void OnEnable()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void ShowReviveSelectUI(int totalPendingTime)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void RefreshSomeUIVisable()
	{
	}

	public void UpdateInteractionCD()
	{
	}

	public void OnObserverSwitch(object[] data)
	{
	}

	private void OnGulagRefreshObserverReviveUI()
	{
	}

	private void InitObserverInteraction()
	{
	}

	private void SetFateRandomCanRevive(FHLHFAJMBOD game, int secs)
	{
	}

	private void OnDropClick()
	{
	}

	private void OnPostMatchBtnSmallDropClick()
	{
	}

	private void onReportClick()
	{
	}

	private void OnReviveClick()
	{
	}

	private void BuySoloRevive()
	{
	}

	public void OnOpenReviveUI(object[] param)
	{
	}

	private void StartReviveCountDown()
	{
	}

	private void OnCountDownFinished()
	{
	}

	private void OnReviveDelayStart()
	{
	}

	private void OnReviveDelayFinished()
	{
	}

	private void OnObserverInfoListVisibleChanged(object[] data)
	{
	}

	private void OnTrainingZoneChanged(object[] data)
	{
	}

	private void OnWishListNodeClick()
	{
	}

	public void WishListHide()
	{
	}

	private void OnMatchEnd(object[] data)
	{
	}

	private void OnFateRandomRevivePosSync(object[] data)
	{
	}

	private void OnQuitRevive(object[] data)
	{
	}

	private void RefreshQuickNextBtn()
	{
	}

	private void SetRankingTipsBubble()
	{
	}

	private void ParseOpenQuickMatchGameModeList()
	{
	}

	public void SetMoveUpSwitch()
	{
	}

	private void OnBooyahPostInit()
	{
	}

	public void SwitchCustomReviveType(bool isUseCustomRevive)
	{
	}

	public UIBaseController OpenCommonRevivePanle(Type uiType)
	{
		return null;
	}

	protected override void SetControllerCursorEvent(Action OnShow, Action OnHideOrDestory)
	{
	}

	private void OnBriefMatchResult()
	{
	}

	private void RefreshRatingUI()
	{
	}

	private void SetRatingUIFX(ERatingLevel ratingLevel)
	{
	}

	private void OnRatingFXCreated(GameObject obj)
	{
	}

	private void ReleaseRatingFX()
	{
	}

	private void OnExpandKillDetail(bool state)
	{
	}

	private void SetBottomBtnState()
	{
	}

	private void RefreshCanAskReviveState()
	{
	}

	private void OnSafeZoneStageIdChanged()
	{
	}

	private void RefreshAskReviveButtonState()
	{
	}

	private void OnAskReviveCountDownFinished()
	{
	}

	private void OnClickAskReviveButton()
	{
	}

	private bool TryHandleReviveBoxAskRevive(NAHFMFGGCDN levelObjectMgr, BHGGAEEHJCO askRevivePlayerID)
	{
		return false;
	}

	private void SendAskReviveQuickChatAndResetCD()
	{
	}

	private void SetDropButtonActive(bool actived)
	{
	}

	private void OnPlatformHeadpicGetted()
	{
	}

	private void UpdateButtonStateByRematchMode(bool forceQuickMatchMode = false)
	{
	}

	private void OnSwitchToPostMatchMode()
	{
	}

	private void OnSwitchToQuickMatchMode()
	{
	}

	private void MoveUpTopContentByAutoReviveBtn(bool isReset = false)
	{
	}

	private void OnClickTrainingGameAutoReviveButton()
	{
	}

	private void CancelAutoReviveCountDown()
	{
	}

	private bool IsTrainingGameEnableAutoRevive()
	{
		return false;
	}

	private void OnCancelAutoRevive()
	{
	}

	private void NotifyGSAutoRevive()
	{
	}

	private bool IsPlayerInGulagRevive()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
