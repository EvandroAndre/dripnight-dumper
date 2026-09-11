using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudNewCSShopWeaponDetailController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public AGACNOCEEFP weapondata;

		internal bool _003CRefreshWeaponDetail_003Eb__0(WeaponTabData data)
		{
			return false;
		}
	}

	private sealed class _003CWaitAnimAndHide_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudNewCSShopWeaponDetailController _003C_003E4__this;

		public bool showDetailBtn;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitAnimAndHide_003Ed__12(int _003C_003E1__state)
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

	private uint m_CurItemId;

	private List<UIHudInventoryTagController> m_TagCtrls;

	private UIHudNewCSShopWeaponDetailView m_View;

	private bool m_HasPlayOpenAnim;

	private UIHudWeaponPropertyListHelper m_PropertyListHelper;

	private uint m_CurDisplayWeaponItemId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	public void ShowAndPlayAnim()
	{
	}

	public void HideAndPlayAnim(bool showDetailBtn)
	{
	}

	private IEnumerator WaitAnimAndHide(bool showDetailBtn)
	{
		return null;
	}

	public void ShowDetail(uint itemId)
	{
	}

	private AGACNOCEEFP GetDisplayWeaponData(uint itemId)
	{
		return null;
	}

	private AGACNOCEEFP GetWeaponDataByItemId(uint itemId)
	{
		return null;
	}

	private KCNBOBHHAPL GetCurrentReplacerData(uint replacerItemId)
	{
		return null;
	}

	private uint GetCurrentReplacerTargetWeaponId(Player localPlayer, OMELKCOGCBK invMgr)
	{
		return 0u;
	}

	public void ShowDetail(string title, string desc)
	{
	}

	private void RefreshItemDetail(HENEHAGJCLI itemData)
	{
	}

	private void RefreshWeaponDetail(AGACNOCEEFP weapondata)
	{
	}

	private void ResetTag()
	{
	}

	private void ResetProperty(bool needClearItem)
	{
	}

	private void RefreshAllPropertyReinforcedIcons()
	{
	}

	private void OnSyncReinforceItems()
	{
	}

	private void OnReinforceItemChanged(uint itemId)
	{
	}

	private void RefreshWeaponPropertyLayout()
	{
	}

	private uint GetCurrentReinforceItemId(AGACNOCEEFP displayWeaponData)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
