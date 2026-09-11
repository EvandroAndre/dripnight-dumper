using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisOptionController : UIBaseController
{
	private sealed class _003CWaitVehicleUnlockAnimation_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudMetropolisOptionController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitVehicleUnlockAnimation_003Ed__23(int _003C_003E1__state)
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

	private sealed class _003CWaitWeaponUnlockAnimation_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudMetropolisOptionController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitWeaponUnlockAnimation_003Ed__25(int _003C_003E1__state)
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

	private UIHudMetropolisOptionView m_View;

	private Dictionary<int, int> m_FactionCount;

	private bool m_NeedShowWeaponTutorial;

	private bool m_HasShowWeaponTutorial;

	private bool m_NeedShowVehicleTutorial;

	private bool m_HasShowVehicleTutorial;

	private Coroutine m_VehicleUnlockCoroutine;

	private Coroutine m_WeaponUnlockCoroutine;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnClickCallVehicleBtn()
	{
	}

	private void OnClickLeaderboardBtn()
	{
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnClickCallWeaponBtn()
	{
	}

	private void OnAddCoin(int delta)
	{
	}

	private void OnLocalPlayerFactionChange(object[] data)
	{
	}

	private void OnAddLocalPlayer(object[] data)
	{
	}

	private void OnFactionCountUpdate(object[] data)
	{
	}

	private void OnHypeLevelChange(object[] data)
	{
	}

	private void RefreshFactionInfo()
	{
	}

	public void ShowOpenWeaponStoreTutorial()
	{
	}

	public void ShowOpenVehicleStoreTutorial()
	{
	}

	private IEnumerator WaitVehicleUnlockAnimation()
	{
		return null;
	}

	private void StopVehicleUnlockAnimation()
	{
	}

	private IEnumerator WaitWeaponUnlockAnimation()
	{
		return null;
	}

	private void StopWeaponUnlockAnimation()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
