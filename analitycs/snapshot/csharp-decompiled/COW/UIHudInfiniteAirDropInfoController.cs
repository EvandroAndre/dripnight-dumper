using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInfiniteAirDropInfoController : UIBaseController
{
	private sealed class _003CDoPlayTip_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudInfiniteAirDropInfoController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDoPlayTip_003Ed__16(int _003C_003E1__state)
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

	private sealed class _003CPlayDropEffect_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject lockObj;

		public GameObject refreshObj;

		public GameObject vfxObj;

		public UIHudInfiniteAirDropInfoController _003C_003E4__this;

		public UISprite dropIcon;

		public int dropId;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayDropEffect_003Ed__13(int _003C_003E1__state)
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

	private sealed class _003CPlayStepChange_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudInfiniteAirDropInfoController _003C_003E4__this;

		private GameObject _003CstepEffect_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayStepChange_003Ed__18(int _003C_003E1__state)
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

	private const uint VISIBILITY_STATE_DETECTIVE_SCAN_WARNING = 67108864u;

	private UIHudInfiniteAirDropInfoView m_View;

	private bool m_PlayerIn;

	private int m_currTime;

	private uint m_BindId;

	private InteractiveState m_CurrentState;

	private int m_CurrentStep;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnDetectiveScanWarningStateChanged(bool showing)
	{
	}

	private void OnLeftDropChanged(object[] param)
	{
	}

	private void OnMiddleDropChanged(object[] param)
	{
	}

	private void OnRightDropChanged(object[] param)
	{
	}

	private IEnumerator PlayDropEffect(UISprite dropIcon, GameObject lockObj, GameObject vfxObj, GameObject refreshObj, int dropId)
	{
		return null;
	}

	private void SetDropIcon(UISprite dropIcon, int DropId)
	{
	}

	private void PlayGetDropTip(int dropId)
	{
	}

	private IEnumerator DoPlayTip()
	{
		return null;
	}

	private void OnStepChanged(object[] param)
	{
	}

	private IEnumerator PlayStepChange()
	{
		return null;
	}

	private void ChangeStep(int step)
	{
	}

	private void OnTimeChanged(object[] param)
	{
	}

	private void SetTime(int time)
	{
	}

	private void OnPlayerActiveChanged(object[] param)
	{
	}

	private void OnPlayerCountChanged(object[] param)
	{
	}

	private void PlayerCountChange(int value)
	{
	}

	private void OnStateChanged(object[] param)
	{
	}

	private void OnVisibleChanged(GEvent param)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void ResetView()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
