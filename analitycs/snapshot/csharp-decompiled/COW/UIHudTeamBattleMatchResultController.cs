using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

internal class UIHudTeamBattleMatchResultController : UIHudMatchResultBaseController
{
	public enum AnimPageTypes
	{
		NormalPage,
		DataPage,
		AvatarPage
	}

	private sealed class _003CDelayCallUpdateBotGameFakeLike_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudTeamBattleMatchResultController _003C_003E4__this;

		public List<TeammateStats> teammates;

		public List<TeammateStats> enemies;

		public MatchStats stats;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayCallUpdateBotGameFakeLike_003Ed__44(int _003C_003E1__state)
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

	private sealed class _003CPlayDataToNormalChangeAnim_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudTeamBattleMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayDataToNormalChangeAnim_003Ed__87(int _003C_003E1__state)
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

	private sealed class _003CPlayNormalToDataChangeAnim_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudTeamBattleMatchResultController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayNormalToDataChangeAnim_003Ed__88(int _003C_003E1__state)
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

	protected UISprite m_LeftTeamInfoBG;

	protected UISprite m_LeftTeamLine01;

	protected UISprite m_LeftTeamLine02;

	protected UISprite m_RightTeamInfoBG;

	protected UISprite m_RightTeamLine01;

	protected UISprite m_RightTeamLine02;

	private const int SCORE_TO_DIVIDING_LINE_WIDTH = 10;

	protected UIHudTeamBattleMatchResultView m_View;

	protected bool HideGradeInfo;

	private Color m_ButtonBlackColor;

	private Color m_ButtonWhiteColor;

	protected bool m_CSTeamIconNewStyle;

	protected const string ANIM_PARAM_TRIGGER_DATAPAGE = "dataPage";

	protected const string ANIM_PARAM_TRIGGER_NORMALPAGE = "normalPage";

	protected const string ANIM_PARAM_TRIGGER_AVATARPAGE = "avatarPage";

	private ulong m_WinMVPPlayerAccountID;

	private ulong m_FailMVPPlayerAccountID;

	private bool m_HasUpdateTeammateInfo;

	protected List<TeammateStats> m_TeammatsStatsList;

	protected List<TeammateStats> m_OpponentsStatsList;

	private MacthAchievementItem.ReplayMatchAchievementItemData achievementData;

	protected UIQuickMatchController m_QuickMatchController;

	private UICommonGuideController m_CommonGuideCtrl;

	private UIHudRankingTipsBubbleController m_RankingTipsCtrl;

	protected ulong WinMVPPlayerAccountID
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	protected ulong FailMVPPlayerAccountID
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected void UpdateLeftTeamCustomIcon(ResourceID spriteID, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	protected void UpdateRightTeamCustomIcon(ResourceID spriteID, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
	{
	}

	protected void RepositionScoreWidth()
	{
	}

	protected virtual bool UseLongTeamList()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void ShowInFrontEndScene()
	{
	}

	protected override void OnShowAvatarInfoUI()
	{
	}

	protected override void OnChangePageType()
	{
	}

	protected virtual void SetItemOnChangePageType()
	{
	}

	private void UpdateFakeLikes(uint rank, uint kills)
	{
	}

	protected virtual void UpdateInfoTitles()
	{
	}

	private IEnumerator DelayCallUpdateBotGameFakeLike(List<TeammateStats> teammates, List<TeammateStats> enemies, MatchStats stats)
	{
		return null;
	}

	private void UpdateBotGameFakeLike(List<TeammateStats> teammates, List<TeammateStats> enemies, MatchStats stats)
	{
	}

	private bool AlreadyHasTeammateLike(List<TeammateStats> teammates)
	{
		return false;
	}

	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	protected List<UIHudTeamBattleMatchResultDataItemController> GetCurTeamBattleMatchResultDataItem()
	{
		return null;
	}

	protected override void OnShowDetailUI(bool show)
	{
	}

	protected virtual void SetPageTypeAnim(bool show)
	{
	}

	protected override void ShowInFrontEndUpdateBtn()
	{
	}

	protected override int[] GetInfoTypes()
	{
		return null;
	}

	protected override int[] GetInfoTypesData()
	{
		return null;
	}

	protected virtual void UpdateMVPInfo(List<TeammateStats> players, bool win, bool needSetMVPPlayer, bool show = false)
	{
	}

	protected virtual void RefreshDetailDataInfoUIView(List<TeammateStats> players, bool localTeam)
	{
	}

	private void OnClickDataLeftTeamBtn()
	{
	}

	private void OnClickDataRightTeamBtn()
	{
	}

	public void SetDataTeamBtnView(bool isLeft)
	{
	}

	protected virtual Transform GetItemTransform(bool localTeam, int index)
	{
		return null;
	}

	protected virtual Transform GetDataItemTransform(int index)
	{
		return null;
	}

	private CMDBIPLGLGA GetGroupMode()
	{
		return CMDBIPLGLGA.EGROUPMODE_SOLO;
	}

	protected override bool CheckIsWinTeamPlayerForSpectator(BHGGAEEHJCO playerID)
	{
		return false;
	}

	private void UpdateTeamInfo(MatchStats stats)
	{
	}

	private void UpdateClanInfo(MatchStats state)
	{
	}

	private BriefClanInfo GetOpTeamBriefClanInfo(MatchStats stats)
	{
		return null;
	}

	protected virtual void UpdateTeammateInfo(bool localTeam, List<TeammateStats> players)
	{
	}

	protected virtual bool IsSelfShowSreakWin()
	{
		return false;
	}

	protected virtual bool IsOpponentShowSreakWin()
	{
		return false;
	}

	protected virtual bool IsShowBlockBtn()
	{
		return false;
	}

	private void OnClickRatingTips()
	{
	}

	private void OnClickReportBtn()
	{
	}

	private void OnClickAddFriendBtn()
	{
	}

	protected void OnClickLikeBtn()
	{
	}

	private void OnClickBlockBtn()
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

	private void OnClickInviteBtn()
	{
	}

	private void SetInviteBtnIconState()
	{
	}

	protected void InitRewardBtnGrid()
	{
	}

	private void SetBlockBtnActive(bool show)
	{
	}

	private void ShowBlockGuideTips(object[] data)
	{
	}

	private void ExchangeBtnIndex(Transform showBtn, Transform hideBtn)
	{
	}

	private void ResetHQPageSwtichIconState()
	{
	}

	private void SwapDefaultIcon()
	{
	}

	public void SetPageTypeValue(AnimPageTypes pageType)
	{
	}

	protected override IEnumerator PlayDataToNormalChangeAnim()
	{
		return null;
	}

	protected override IEnumerator PlayNormalToDataChangeAnim()
	{
		return null;
	}

	protected override bool SaveReplay()
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

	private void ShowQuickMatchGuide()
	{
	}

	private void OnMatchMakingHide()
	{
	}

	private void OnAnimEvent(object[] data)
	{
	}

	private void ShowSelfBadgeVFX()
	{
	}

	private void ShowGroupMedals(uint[] groupMedals)
	{
	}

	private UIHUDFeedbackGroupItemController GetFeedBackItem()
	{
		return null;
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

	private void UpdateButtonStateByRematchMode()
	{
	}

	private void OnSwitchToPostMatchMode()
	{
	}

	private void OnSwitchToQuickMatchMode()
	{
	}

	private void CacheDefaultSkin()
	{
	}

	private void SetDefaultSkin()
	{
	}

	public override void RefreshUISkinChange()
	{
	}

	private void _003COnUIInit_003Eb__36_0()
	{
	}

	private void _003COnShowDetailUI_003Eb__49_0()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowDetailUI(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowInFrontEndScene()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShowAvatarInfoUI()
	{
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

	public int[] _003C_003EiFixBaseProxy_GetInfoTypesData()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_CheckIsWinTeamPlayerForSpectator(BHGGAEEHJCO P0)
	{
		return false;
	}

	public IEnumerator _003C_003EiFixBaseProxy_PlayDataToNormalChangeAnim()
	{
		return null;
	}

	public IEnumerator _003C_003EiFixBaseProxy_PlayNormalToDataChangeAnim()
	{
		return null;
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

	public void _003C_003EiFixBaseProxy_OnClickNextBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshUISkinChange()
	{
	}
}
