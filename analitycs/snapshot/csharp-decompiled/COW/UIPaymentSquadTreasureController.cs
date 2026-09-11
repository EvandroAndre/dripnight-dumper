using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIPaymentSquadTreasureController : UIPaymentController.PaymentTabContentController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<SortedTeamInfo> _003C_003E9__33_0;

		public static Comparison<SquadTreasureAwardDesc> _003C_003E9__37_0;

		public static Comparison<TopUpMember> _003C_003E9__71_0;

		internal int _003CBuildSortedTeamList_003Eb__33_0(SortedTeamInfo a, SortedTeamInfo b)
		{
			return 0;
		}

		internal int _003CInitRewardList_003Eb__37_0(SquadTreasureAwardDesc a, SquadTreasureAwardDesc b)
		{
			return 0;
		}

		internal int _003CRefreshTeammateView_003Eb__71_0(TopUpMember a, TopUpMember b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public UIPaymentSquadTreasureTeamSecondConfirmWindowController confirmWnd;

		public UIPaymentSquadTreasureController _003C_003E4__this;

		internal void _003COnBtnExitClick_003Eb__0()
		{
		}

		internal void _003COnBtnExitClick_003Eb__1()
		{
		}
	}

	private UIPaymentSquadTreasureView m_View;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private List<UIPaymentSquadTreasureTeammateItemController> m_TeammateItemList;

	private UICountDownController m_CountDownCtrl;

	private UICountDownController m_TopupCountDownCtrl;

	private SquadTreasureSettingDesc m_SquadTreasureSetting;

	private UIModelClan m_ModelClan;

	private UIModelFriends m_ModelFriends;

	private UIPaymentSquadTreasureTeamListBoxController m_TeamListCtrl;

	private UIPaymentSquadTreasureFriendListBoxController m_FriendListCtrl;

	private ulong m_CurrentGroupId;

	private ulong m_CurrentGroupInvitationId;

	private uint m_CurFriendInvitionIndex;

	private uint m_CurSortedTeamIndex;

	private List<SortedTeamInfo> m_SortedTeamList;

	private bool m_NeedResortTeams;

	private List<UIPaymentSquadTreasureRewardItemController> m_RewardItemList;

	private List<UIPaymentSquadTreasureTeammateItemController> m_FinishTopUpTeammateItemList;

	private UITipsNormalController m_ClaimBtnTipsCtrl;

	private UITipsNormalController m_TeamListTipsCtrl;

	private uint m_PrivateTeamReminderDelayCall;

	private bool m_IsShowingGuide;

	private bool m_NeedShowTakePhotoBubble;

	private uint m_TakePhotoBubbleDelayCall;

	private const float TAKE_PHOTO_BUBBLE_DISPLAY_TIME = 5f;

	private bool m_IsContentReady;

	private AutoPopup m_SquadTreasurePopup;

	private const float m_TopupFinishEffectTime = 1f;

	private const float m_TopupFinishEffectDelayTime = 0.5f;

	private uint m_TopupFinishEffectDelayCall;

	private uint m_TopupFinishEffectCall;

	private float m_FlyTime;

	private float m_BurstTime;

	private uint m_AnimDelayCall;

	private uint m_BurstVFXDelayCall;

	private uint m_PlayOutVFXDelayCall;

	private GameObject m_VFXObj;

	private ResourceID m_VFXResId;

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

	protected override void OnVisibilityChanged()
	{
	}

	public override void RefreshContent()
	{
	}

	public void OnJoinCurrentTeam()
	{
	}

	private List<SortedTeamInfo> BuildSortedTeamList()
	{
		return null;
	}

	private void EnqueueSquadTreasurePopups()
	{
	}

	private void Update()
	{
	}

	private void InitTeammateItem(uint teammateNum)
	{
	}

	private void InitRewardList(uint rewardNum)
	{
	}

	private void InitEvent()
	{
	}

	private void InitView()
	{
	}

	private void SetContentVisible(bool visible)
	{
	}

	private void InitSortData()
	{
	}

	private void InitBackgroundVFX()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void OnProgressHelpBtnClick()
	{
	}

	private void OnBtnCopyTeamCodeClick()
	{
	}

	private void OnBtnShareClick()
	{
	}

	private void OnBtnExitClick()
	{
	}

	private void OnBtnConfigClick()
	{
	}

	private void OnBtnJoinClick()
	{
	}

	private void OnBtnCountDownTipsClick()
	{
	}

	private void OnBtnTakePhotoClick()
	{
	}

	private void OpenSquadTreasureGroupPhoto()
	{
	}

	private void RefreshCountDown()
	{
	}

	private void RefreshTeammateIconShow()
	{
	}

	private void OnBtnTeamListClick()
	{
	}

	public void OnBtnInviteClick()
	{
	}

	private void OnBtnTopupClick()
	{
	}

	private void OnBtnClaimRewardClick()
	{
	}

	private ESquadTreasureTeamListType GetCurrentTeamListType()
	{
		return ESquadTreasureTeamListType.TeamList;
	}

	private void OnBtnCreateClick()
	{
	}

	private void RefreshMyTeamView()
	{
	}

	private void RefreshRecommendTeamView(ulong teamId)
	{
	}

	private void ShowEmptyView()
	{
	}

	private void RefreshRewardList(uint progress)
	{
	}

	private void RefreshRewardProgress()
	{
	}

	private void RefreshRewardProgress(int progress)
	{
	}

	private void RefreshRewardTeamNumberVFX(uint progress)
	{
	}

	private void RefreshButtonView(TopUpTeam teamInfo)
	{
	}

	private void RefreshTopupCountDown(ulong endTimestamp, bool isTopUpCompleted)
	{
	}

	private void RefreshTeamState(TopUpTeam teamInfo)
	{
	}

	private void RefreshTeammateView(TopUpTeam teamInfo)
	{
	}

	private void RefreshSortedTeamList()
	{
	}

	private ulong GetDisplayTeamId()
	{
		return 0uL;
	}

	private void OnBtnRefreshClick()
	{
	}

	private void OnOpenInviteWnd()
	{
	}

	private void ShowJoinTeamWnd()
	{
	}

	private void PlayRefreshEffect()
	{
	}

	private void PlayTopUpFinishEffect()
	{
	}

	private void PlayTopUpFinishEffectSequence(bool hasNewEffect)
	{
	}

	private void OnCloseTeammateNoticePopupWindow()
	{
	}

	private bool CanClaimReward()
	{
		return false;
	}

	private void RefreshClaimBtnState()
	{
	}

	private void RefreshTakePhotoBtnState(bool isTeamFull)
	{
	}

	private void HideTakePhotoBubble()
	{
	}

	private void ClearCountDown()
	{
	}

	private void CheckTeamPrivateToPublicRemind()
	{
	}

	private bool NeedReminderForPrivateToPublic()
	{
		return false;
	}

	private void ExecuteFlyEffect()
	{
	}

	private void InstantVFXObj()
	{
	}

	private void DestroyVFXObj()
	{
	}

	private void CheckShowGuide()
	{
	}

	private void ShowStep1Guide()
	{
	}

	private bool ShowStep2Guide()
	{
		return false;
	}

	private void RefreshBubblesAfterGuide()
	{
	}

	private void CheckAutoPopupInvitationWnd()
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private bool ShouldShowJoinButtonBubble()
	{
		return false;
	}

	private void UpdateJoinButtonBubble()
	{
	}

	private void ProcessAutoFindTopUpTeamResult(bool isSuccess)
	{
	}

	private void _003CRefreshCountDown_003Eb__53_0()
	{
	}

	private void _003CRefreshTopupCountDown_003Eb__69_0()
	{
	}

	private void _003CRefreshTopupCountDown_003Eb__69_1()
	{
	}

	private void _003CPlayTopUpFinishEffectSequence_003Eb__83_0()
	{
	}

	private void _003CPlayTopUpFinishEffectSequence_003Eb__83_1()
	{
	}

	private void _003CRefreshTakePhotoBtnState_003Eb__87_0()
	{
	}

	private void _003CCheckTeamPrivateToPublicRemind_003Eb__90_0()
	{
	}

	private void _003CExecuteFlyEffect_003Eb__99_0()
	{
	}

	private void _003CExecuteFlyEffect_003Eb__99_1()
	{
	}

	private void _003CExecuteFlyEffect_003Eb__99_2()
	{
	}

	private void _003CShowStep1Guide_003Eb__103_0()
	{
	}

	private void _003CShowStep2Guide_003Eb__104_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}
