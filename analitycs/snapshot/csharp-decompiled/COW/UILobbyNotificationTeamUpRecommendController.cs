using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UILobbyNotificationTeamUpRecommendController : UILobbyNotificationPopUpContentBaseController
{
	private sealed class _003CShowCommonFriendAndSocialLight_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyNotificationTeamUpRecommendController _003C_003E4__this;

		private bool _003CisBr_003E5__2;

		private RankingStatsSummary _003Cstats_003E5__3;

		private TeamUpRecommendConfigDesc _003Cconfig_003E5__4;

		private UITeamUpRecommendReasonItemController _003Cctrl_003E5__5;

		private bool _003ChasAddLeaderBoardTitle_003E5__6;

		private List<SocialHighLight>.Enumerator _003C_003E7__wrap6;

		private UILeaderBoardTitleIconController _003CweaponTitleCtrl_003E5__8;

		private UISocialHighlightIconController _003ChighLightCtrl_003E5__9;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowCommonFriendAndSocialLight_003Ed__18(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UILobbyNotificationTeamUpRecommendView m_View;

	private UIModelGroup m_ModelGroup;

	private TeamUpRecommendAccountInfo m_TeamUpRecommendAccountInfo;

	private bool m_IsInteracktionButtonClicked;

	private const string PRIMENICKNAMEKEY = "[x1.5][S0][-]{0}";

	private uint m_DelayCall;

	private const uint MAX_REASON_WIDTH = 290u;

	private bool m_ShowReasonReachLimit;

	private List<UIBaseController> m_RecommendReasonCtrls;

	protected override ENotificationPopUpType NotificationType => ENotificationPopUpType.None;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitView()
	{
	}

	protected override UIButton InitInteractionButton()
	{
		return null;
	}

	protected override void OnInteractionBtnClick()
	{
	}

	public override void OnCloseClick()
	{
	}

	public override void OnIgnoreNotification()
	{
	}

	public override void OnOutAnimFinished()
	{
	}

	protected override void OnReset()
	{
	}

	protected override void OnSetViewData(object data)
	{
	}

	private void OnSetViewData(TeamUpRecommendAccountInfo data)
	{
	}

	private IEnumerator ShowCommonFriendAndSocialLight()
	{
		return null;
	}

	private void CheckShowMaxLimit(UIBaseController ctrl)
	{
	}

	private void ShowSmallRecommend()
	{
	}

	private void InviteTeamUpRecommendPlayer()
	{
	}

	private void OnHeadBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInteractionBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnIgnoreNotification()
	{
	}

	public void _003C_003EiFixBaseProxy_OnOutAnimFinished()
	{
	}
}
