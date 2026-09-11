using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudMatchEndShowTimeController : UIHudMatchEndShowTimeControllerBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__28_0;

		public static Action _003C_003E9__28_1;

		internal void _003CSetControllerCursorEvent_003Eb__28_0()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__28_1()
		{
		}
	}

	protected UIHudMatchEndShowTimeViewExt m_View;

	private UIQuickMatchController m_QuickMatchController;

	private UIModelMatch m_ModelMatch;

	private UIMatchMakingManager m_MatchMakingManager;

	private UIHudRankingTipsBubbleController m_RankingTipsCtrl;

	private bool m_NeedOpenCSPeakBriefResult;

	private ERatingLevel m_CurrentRatingLevel;

	private VisualInstanceHolder m_RatingFXHolder;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected virtual void CreateView()
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

	protected override void OnVisibilityChanged()
	{
	}

	protected virtual void ShowSkinBooyahView(bool win)
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	protected virtual void OnProcessAnimEvt(string animEvt)
	{
	}

	protected virtual void FillMatchResultInfo(bool win, int rank = 0)
	{
	}

	protected virtual void PlayAnimation()
	{
	}

	private bool NeedHideObserverHud()
	{
		return false;
	}

	protected virtual void FillTeamScoreInfo(bool isTeamA, int leftScore, int rightScore, int localFactionID)
	{
	}

	private void UpdateClanShowInfo(int leftScore, int rightScore)
	{
	}

	private void ShowTeamIcon(bool isTeamA)
	{
	}

	private bool NeedShowDefeatedGameMode()
	{
		return false;
	}

	public void ShowShowResultBtn(bool show)
	{
	}

	public void RefreshShowResultBtn()
	{
	}

	private void LogClickReturnToMatchResult()
	{
	}

	private void OnPostMatchBtnSmallDropClick()
	{
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

	private void RefreshRatingUIInternal(ERatingLevel ratingLevel, float ratingPoint)
	{
	}

	private void SetLabelActive(UILabel label, bool active)
	{
	}

	private void SetSpriteActive(UISprite sprite, bool active)
	{
	}

	private void SetRatingNumText(UILabel label, float ratingPoint)
	{
	}

	public void DebugTestRatingLevel(int level, float ratingPoint)
	{
	}

	private void SetRatingUIFX(ERatingLevel ratingLevel)
	{
	}

	private void ReleaseRatingFX()
	{
	}

	protected virtual void RefreshCSPeakCon()
	{
	}

	private void SetCSPeakBooyahVFX()
	{
	}

	private void TryReleaseCSPeakBooyahVFX()
	{
	}

	private void OnCSPeakMatchResult()
	{
	}

	private void OpenCSPeakMatchResult(object[] param)
	{
	}

	public override void OnHandleInvalidTimeMatch()
	{
	}

	protected virtual void ShowGroupMedals(List<byte> groupMedals)
	{
	}

	protected UIHUDFeedbackGroupItemController GetFeedBackItem()
	{
		return null;
	}

	private void RefreshRankingTipsBubble()
	{
	}

	private void OnHideRankingTipsBubble()
	{
	}

	private void UpdateButtonStateByRematchMode()
	{
	}

	private void OnSwitchToPostMatchMode()
	{
	}

	private void OnSwitchToQuickMatchMode()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHandleInvalidTimeMatch()
	{
	}
}
