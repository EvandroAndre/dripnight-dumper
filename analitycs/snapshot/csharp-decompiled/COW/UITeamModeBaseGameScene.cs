using System;
using System.Collections;
using System.Collections.Generic;

namespace COW;

internal class UITeamModeBaseGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UITeamModeBaseGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__4(int _003C_003E1__state)
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

	protected UIHudGameShowInfoController m_ShowInfoCtrl;

	protected UIHudTDMLikeShopController m_TDMLikeShopController;

	protected UIHudCSShopEntryController m_TDMShopEntryCtrl;

	protected UIHudTDMLikeShopEntryController m_TDMLikeShopEntryCtrl;

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	protected override void OnOpenHudInPregame()
	{
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	public void OnRefreshTDMLikeShop(object[] data)
	{
	}

	public void OnTDMLikeShopVisibilityChange(object[] data)
	{
	}

	public bool IsBombLikeShopIsShowing()
	{
		return false;
	}

	private void OnShowMatchInfo(object[] param)
	{
	}

	protected virtual void ShowTeamScore(object[] data)
	{
	}

	protected void OnLocalPlayerRevive(object[] data)
	{
	}

	protected virtual void OnLocalPlayerRevive()
	{
	}

	protected virtual bool CanAutoPopShop()
	{
		return false;
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	private void _003COnOpenHudInPregame_003Eb__5_0()
	{
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

	public void _003C_003EiFixBaseProxy_OnOpenHudInPregame()
	{
	}
}
