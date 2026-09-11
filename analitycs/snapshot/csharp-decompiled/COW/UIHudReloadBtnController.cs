using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudReloadBtnController : UIHudButtonBaseController
{
	private sealed class _003CStartCooldown_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float f;

		public UIHudReloadBtnController _003C_003E4__this;

		private float _003Ct_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CStartCooldown_003Ed__21(int _003C_003E1__state)
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

	private UIHudReloadBtnView m_View;

	private EReloadSetting m_ShowTiming;

	private IEnumerator m_CurrentCoroutine;

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

	protected override void OnUIOpen()
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	protected override void OnBtnDown()
	{
	}

	protected override void OnBtnUp()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnHudSettingChange(object[] param)
	{
	}

	private void OnWeaponReload(object[] data)
	{
	}

	private void OnReloadSpeedChangeAvailable(object[] data)
	{
	}

	private void OnWeaponReloadSpeedChanged(object[] data)
	{
	}

	private void OnWeaponReloadEnd(object[] data)
	{
	}

	private void OnWeaponChanged(object[] data)
	{
	}

	private void OnItemChange(object[] data)
	{
	}

	private void UpdateShowTiming()
	{
	}

	private void UpdateShowHide()
	{
	}

	private void UpdateCd(bool reloading, float cd)
	{
	}

	private IEnumerator StartCooldown(float f)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnUp()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
