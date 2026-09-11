using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHudNormalMatchResultController : UIHudMatchResultBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<TeammateStats> _003C_003E9__73_0;

		internal bool _003CGetAllTeamRatingPoint_003Eb__73_0(TeammateStats x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public ulong aid;

		internal bool _003CGetPlayerRatingPoint_003Eb__0(TeammateStats x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public PlayerData player1;

		public PlayerData player2;

		internal bool _003CSortPlayerData_003Eb__0(TeammateStats x)
		{
			return false;
		}

		internal bool _003CSortPlayerData_003Eb__1(TeammateStats x)
		{
			return false;
		}
	}

	private sealed class _003CDelayCallUpdateBotGameFakeLike_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudNormalMatchResultController _003C_003E4__this;

		public MatchStats stats;

		public List<TeammateStats> teammateList;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayCallUpdateBotGameFakeLike_003Ed__24(int _003C_003E1__state)
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

	protected UIHudNormalMatchResultView m_View;

	protected List<TeammateStats> m_TeammateStats;

	private bool m_HasUpdateTeammates;

	private bool m_AnyPlayerHasBadge;

	private bool mbShowAchievementPreview;

	private MacthAchievementItem.ReplayMatchAchievementItemData achievementData;

	private UIQuickMatchController m_QuickMatchController;

	private UIHUDAIChatParentController m_UIHUDAIChatParentCtrl;

	private Color m_ButtonBlackColor;

	private Color m_ButtonWhiteColor;

	private UICommonGuideController m_CommonGuideCtrl;

	private UIHudRankingTipsBubbleController m_RankingTipsCtrl;

	protected bool m_IsShowItemIndex;

	private float[] InfoTitleNormalPosX;

	private float[] InfoTitleHasBadgePosX;

	protected float[] BRDataTitlePosX;

	private UIHudAvatarAttributeBoxController m_AttributeBox;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnShowAvatarInfoUI()
	{
	}

	protected override EMatchResultIsWin CheckIsWin(MatchStats stats)
	{
		return EMatchResultIsWin.Win;
	}

	protected override void OnChangePageType()
	{
	}

	private void UpdateFakeLikes(uint rank)
	{
	}

	private IEnumerator DelayCallUpdateBotGameFakeLike(MatchStats stats, List<TeammateStats> teammateList)
	{
		return null;
	}

	private void UpdateBotGameFakeLike(MatchStats stats, List<TeammateStats> teammateList)
	{
	}

	protected virtual void UpdateInfoTitles()
	{
	}

	protected void ChangeTitleInfoTxtPos()
	{
	}

	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	protected override void OnShowDetailUI(bool show)
	{
	}

	protected override void ShowInFrontEndUpdateBtn()
	{
	}

	protected override int[] GetInfoTypes()
	{
		return null;
	}

	private float GetPlayerRatingPoint(ulong aid)
	{
		return 0f;
	}

	protected override int SortPlayerData(PlayerData player1, PlayerData player2)
	{
		return 0;
	}

	protected override int SortTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return 0;
	}

	public static int SortNormalMatchTeammateData(TeammateStats player1, TeammateStats player2)
	{
		return 0;
	}

	protected override bool NeedReSortByTeamIndex()
	{
		return false;
	}

	protected TeammateStats ConstructSelfTeammateData(MatchStats stats, MatchIncome income)
	{
		return null;
	}

	protected virtual UIHudNormalMatchResultItemController BuildPlayerItem(Transform parent, TeammateStats player, bool single)
	{
		return null;
	}

	private void UpdatePlayerListInfo(List<TeammateStats> players)
	{
	}

	private Transform GetItemTransform(int index)
	{
		return null;
	}

	private void ShowAvatarAttributeBox(List<uint> showAttributes)
	{
	}

	private void ResetHQPageSwtichIconState()
	{
	}

	private void OnAchievementPreviewCloseCallback(object[] args)
	{
	}

	protected override bool CanUpdateCountDown()
	{
		return false;
	}

	private void ShowReportAndBlockBtn()
	{
	}

	private void ShowBlockGuideTips(object[] data)
	{
	}

	protected override bool SaveReplay()
	{
		return false;
	}

	protected virtual bool IsShowReportAndBlockBtn()
	{
		return false;
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	protected override void OnClickNextBtn()
	{
	}

	private void OnPostMatchBtnSmallDropClick()
	{
	}

	private void OnClickReportBtn()
	{
	}

	private bool IsReporteeAlreadyReported(ulong matchId, ulong accountId)
	{
		return false;
	}

	private bool HasAnyPotentialReportees(MatchStats stats)
	{
		return false;
	}

	private CandidateReporteeData CreateCandidateReporteeData(MatchStats matchStats, string name, ulong accountId, BHGGAEEHJCO playerID, CandidateReporteeType type)
	{
		return null;
	}

	private TeammateStats FindReporteeStats(MatchStats matchStats, ulong accountId)
	{
		return null;
	}

	private TeammateStats FindReporteeStats(List<TeammateStats> stats, ulong accountId)
	{
		return null;
	}

	private void OpenNewReportWnd()
	{
	}

	private void OnClickBlockBtn()
	{
	}

	private void OnClickInviteBtn()
	{
	}

	private void OnGroupJoinNtf(object[] data)
	{
	}

	private void OnGroupLeaveNtf(object[] data)
	{
	}

	private void RefreshInviteBtnVisibility()
	{
	}

	private void SetInviteBtnActive()
	{
	}

	private void ShowQuickMatchGuide()
	{
	}

	private void OnMatchMakingHide()
	{
	}

	private void ShowGroupMedals(uint[] groupMedals)
	{
	}

	private UIHUDFeedbackGroupItemController GetFeedBackItem()
	{
		return null;
	}

	private void OnAnimEvent(object[] data)
	{
	}

	private void RefreshBRRankRatingGuide()
	{
	}

	protected float GetAllTeamRatingPoint()
	{
		return 0f;
	}

	private void ShowSelfBadgeVFX()
	{
	}

	private void OnShowFeedbackEndIcon()
	{
	}

	private void RefreshRankingTipsBubble()
	{
	}

	private void OnHideRankingTipsBubble()
	{
	}

	protected void HidePostMatchPlayAgainGuide()
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

	private void _003COnShowDetailUI_003Eb__29_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnClickNextBtn()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowDetailUI(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowAvatarInfoUI()
	{
	}

	public EMatchResultIsWin _003C_003EiFixBaseProxy_CheckIsWin(MatchStats P0)
	{
		return EMatchResultIsWin.Win;
	}

	public void _003C_003EiFixBaseProxy_OnChangePageType()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowInFrontEndUpdateBtn()
	{
	}

	public int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	public int _003C_003EiFixBaseProxy_SortPlayerData(PlayerData P0, PlayerData P1)
	{
		return 0;
	}

	public int _003C_003EiFixBaseProxy_SortTeammateData(TeammateStats P0, TeammateStats P1)
	{
		return 0;
	}

	public bool _003C_003EiFixBaseProxy_NeedReSortByTeamIndex()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_CanUpdateCountDown()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_SaveReplay()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
