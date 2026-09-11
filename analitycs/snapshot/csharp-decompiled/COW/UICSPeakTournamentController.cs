using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UICSPeakTournamentController : UIBaseController, IUIModelDataChangeObserver
{
	private UICSPeakTournamentView m_View;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private List<UICSPeakTournamentLevelRewardItemController> m_RewardItemCtrlList;

	private uint m_Level;

	private UICSRankStarIconController m_CSRankStarIconCtrl;

	private UICSRankStarIconController m_BeforeFirstSeasonCSRankStarIconCtrl;

	private GameObject m_SquadRecruitAvailableGO;

	private GameObject m_SquadRecruitCannotGoMatch;

	private bool m_CanShowWeaponGloryBuff;

	private GameObject m_CenterBgVfx;

	private GameObject m_CenterRankVfx;

	private GameObject m_CenterRank01Vfx;

	private GameObject m_CenterRank02Vfx;

	private GameObject m_CenterRank03Vfx;

	private uint m_CenterBgTicket;

	private uint m_CenterrankTicket;

	private uint m_CenterRank01Ticket;

	private uint m_CenterRank02Ticket;

	private uint m_CenterRank03Ticket;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private bool IsShortSeason()
	{
		return false;
	}

	private bool IsNotShortSeason()
	{
		return false;
	}

	private bool IsShortSeasonAndNotOpen()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void InitUIData()
	{
	}

	private void InitSquadRecruitAvailable()
	{
	}

	private void InitSeasonLabel(string seasonName, bool squadAvailable = false)
	{
	}

	private void InitTopLeftTitleData()
	{
	}

	private string GetSeasonOpenTimeLabelText(CSPeakTournamentSeasonInfoDesc seasonInfo = null)
	{
		return null;
	}

	private void RefreshSeasonTitleClosedView()
	{
	}

	private void RefreshSeasonEndCountDownView(ulong endTime)
	{
	}

	private void InitRewardUIData()
	{
	}

	private void InitCenterCSPeakPointsData()
	{
	}

	private void InitCenterCDN()
	{
	}

	private void InitBGCDN()
	{
	}

	private void OnRankVfxLoaded(uint ticket, bool succeeded, Object obj)
	{
	}

	private void CancelAsyncResLoad()
	{
	}

	private void InitCSPeakDisplayCheckBox()
	{
	}

	private void OnSelectBtnChanged()
	{
	}

	private void InitBottomGoMatchBtn()
	{
	}

	private void RefreshSeasonClosedBottomGoMatchBtn()
	{
	}

	private void RefreshCannotGoMatchCountDownLabel()
	{
	}

	private void InitBottomPeakEnergy()
	{
	}

	private void InitTopRightButtons()
	{
	}

	private void RefreshCommonSeasonTopRightButtons()
	{
	}

	private void RefreshSeasonClosedTopRightButtons()
	{
	}

	private void RefreshWeekLeaderBoardTip()
	{
	}

	private void CheckAndShowShowWebviewToturialBeforeFirstSeason()
	{
	}

	private void OnGoMatchBtnClick()
	{
	}

	private void OnHistoryBtnClick()
	{
	}

	private void OnTop10LeaderBoardBtnClick()
	{
	}

	private void OnHallOfFameBtnClick()
	{
	}

	private void OnLeaderBoardBtnClick()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnPeakEnergyHelpBtnClick()
	{
	}

	private void OnViewAllBtnClick()
	{
	}

	private void OnRuleBtnClick()
	{
	}

	private void OnWeaponGloryBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void CheckAndRequestHistoryBtnVisible()
	{
	}

	private void _003CRefreshSeasonEndCountDownView_003Eb__25_0()
	{
	}

	private void _003CInitBottomGoMatchBtn_003Eb__44_2()
	{
	}

	private void _003CInitBottomGoMatchBtn_003Eb__44_0()
	{
	}

	private void _003CInitBottomGoMatchBtn_003Eb__44_1()
	{
	}

	private void _003CRefreshCannotGoMatchCountDownLabel_003Eb__46_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
