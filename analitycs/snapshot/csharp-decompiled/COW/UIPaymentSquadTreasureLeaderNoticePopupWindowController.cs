using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIPaymentSquadTreasureLeaderNoticePopupWindowController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<TopUpMember> _003C_003E9__10_0;

		public static Action _003C_003E9__12_0;

		public static Action _003C_003E9__13_0;

		internal int _003CRefreshTeamList_003Eb__10_0(TopUpMember a, TopUpMember b)
		{
			return 0;
		}

		internal void _003COnInviteBtnClick_003Eb__12_0()
		{
		}

		internal void _003COnIAPBtnClick_003Eb__13_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public UIPaymentSquadTreasureLeaderNoticePopupWindowController _003C_003E4__this;

		public Action callback;

		internal void _003CPlayOutVFX_003Eb__0()
		{
		}
	}

	private UIPaymentSquadTreasureLeaderNoticePopupWindowView m_View;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private uint m_PlayOutVFX;

	private uint m_PlayOutVFXDelayCall;

	private List<UIPaymentSquadTreasureTeammateItemController> m_TeamItemCtrlList;

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

	private void RefreshContent()
	{
	}

	private void RefreshTeamName()
	{
	}

	private void RefreshTeamList()
	{
	}

	private void OnOkBtnClick()
	{
	}

	private void OnInviteBtnClick()
	{
	}

	private void OnIAPBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void PlayInVFX()
	{
	}

	private void PlayOutVFX(Action callback = null)
	{
	}

	private void _003CRefreshContent_003Eb__8_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
