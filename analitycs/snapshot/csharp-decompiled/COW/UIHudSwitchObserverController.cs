using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudSwitchObserverController : UIBaseController
{
	private sealed class _003CRefreshReviveTipsEffect_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudSwitchObserverController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshReviveTipsEffect_003Ed__9(int _003C_003E1__state)
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

	private UIHudSwitchObserverView m_View;

	private Coroutine m_ReviveTips;

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

	private void RefreshSwitchSprite()
	{
	}

	private void OnSwitchPrevBtnClick()
	{
	}

	private void ShowReviveTips()
	{
	}

	private void ShowNormalReviveTips()
	{
	}

	private IEnumerator RefreshReviveTipsEffect()
	{
		return null;
	}

	private void OnSwitchNextBtnClick()
	{
	}

	private void RefreshSpeceatorTipsKey()
	{
	}

	private void OnObserverInfoListVisibleChanged(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void OnObserverSwitch(object[] data)
	{
	}

	private void OnQuitRevive(object[] data)
	{
	}

	private bool CanSwitch()
	{
		return false;
	}

	public void ChangeLocalPosition(Vector3 pos)
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
}
