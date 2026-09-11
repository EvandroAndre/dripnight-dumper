using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudAcceleratorController : UIHudVehicleButtonBaseController
{
	private sealed class _003CCheckInputTouch_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudAcceleratorController _003C_003E4__this;

		private bool _003CneedFinish_003E5__2;

		private bool _003Cpressed_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCheckInputTouch_003Ed__4(int _003C_003E1__state)
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

	private UIHudAcceleratorView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private IEnumerator CheckInputTouch()
	{
		return null;
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override bool CanLockInput()
	{
		return false;
	}

	protected override EControlMode ShowInControlMode()
	{
		return EControlMode.Default;
	}

	public override void Show()
	{
	}

	public void SetButtonState(Player.AALGCBFJHJM status)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public bool _003C_003EiFixBaseProxy_CanLockInput()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
