using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudUpgradeLinePopOverController : UIBaseController
{
	private sealed class _003CTryAddClickMaskCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudUpgradeLinePopOverController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTryAddClickMaskCoroutine_003Ed__13(int _003C_003E1__state)
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

	private UIHudUpgradeLinePopOverView m_View;

	private List<UIHudUpgradeLineDescItem> m_UpgradeLineDataList;

	private UIWidget m_ClickExtraMaskRegion;

	private UIClickMask m_ClickMask;

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

	public void SetClickExtraMaskRegion(UIWidget region)
	{
	}

	public void SetViewData()
	{
	}

	private void RefreshUpgradeUI()
	{
	}

	private void OpenInventoryUpgradePanel()
	{
	}

	private void OnUpgradeLevelChanged(int level)
	{
	}

	private void OnUpgradeCurLevelGenChanged(int gen)
	{
	}

	private IEnumerator TryAddClickMaskCoroutine()
	{
		return null;
	}

	private void TryAddClickMask()
	{
	}

	private void TryRemoveClickMask()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
