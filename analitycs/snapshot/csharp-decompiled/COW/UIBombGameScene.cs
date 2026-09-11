using System;
using System.Collections;
using System.Collections.Generic;
using message;

namespace COW;

internal class UIBombGameScene : UIInGameScene
{
	private sealed class _003COpenCommonHud_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBombGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__5(int _003C_003E1__state)
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

	protected UIHudBombMatchInfoController m_BombMatchInfoInfoCtrl;

	public Dictionary<uint, UIHudBombZoneMarkController> m_BombZoneMarkList;

	private uint m_HideCSShopDelayCallID;

	private uint m_ShowCSShopDelayCallID;

	private FINDOCEEHIL m_CurrentPhase;

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	protected override void ChangeUIFromWaitingToBattleInternal()
	{
	}

	public override void RegisterGameEventHandler()
	{
	}

	public override void Destory()
	{
	}

	private void OnBombNewPhaseStarted(object[] param)
	{
	}

	protected override void ShowCSShop(object[] data)
	{
	}

	protected override void ShowCSShopProcess()
	{
	}

	private bool IsFactionChangeRound()
	{
		return false;
	}

	public void OnPlayerGetBomb(object[] data)
	{
	}

	public void OnBombSettled(object[] data)
	{
	}

	public void OnBombZoneInfoChanged(object[] data)
	{
	}

	protected override Type GetMatchResultType()
	{
		return null;
	}

	public override bool UsePlayerUpMiniMap()
	{
		return false;
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ChangeUIFromWaitingToBattleInternal()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_Destory()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowCSShop(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowCSShopProcess()
	{
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_UsePlayerUpMiniMap()
	{
		return false;
	}
}
