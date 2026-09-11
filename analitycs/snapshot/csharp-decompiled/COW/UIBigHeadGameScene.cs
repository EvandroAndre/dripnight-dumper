using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;

namespace COW;

internal class UIBigHeadGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBigHeadGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__6(int _003C_003E1__state)
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

	private bool m_isStartFight;

	private bool m_HasShowTips;

	private UIHudPopupController m_waitTip;

	private uint m_DelayCallId;

	private UIHudBigHeadProgressBarController m_UIHudBigHeadProgressBarController;

	private UIHudBigHeadScoreInfoController m_UIHudBigHeadScoreInfoController;

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	public void SetBigHeadScoreInfoCtrl(UIHudBigHeadScoreInfoController ctrl)
	{
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	private void CloseTip()
	{
	}

	private void ShowBigHeadRandomTeamZone(object[] data)
	{
	}

	private void OnBigHeadStartFight(object[] data)
	{
	}

	private void OnGameLoadingOver(object[] data)
	{
	}

	private void OnIntroClose()
	{
	}

	public override void OnAddPlayer(Player p)
	{
	}

	public uint GetLeadingTeamID()
	{
		return 0u;
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAddPlayer(Player P0)
	{
	}
}
