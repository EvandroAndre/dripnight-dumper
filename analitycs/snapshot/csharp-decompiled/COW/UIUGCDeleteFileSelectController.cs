using System;
using GCommon;

namespace COW;

internal class UIUGCDeleteFileSelectController : UIPopupWindowController
{
	private UIUGCDeleteFileSelectView m_View;

	private bool m_SelectedLocal;

	private uint m_SelecetedSlot;

	private Action<bool> m_OnApplyCallBack;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(uint selected, Action<bool> action)
	{
	}

	private void OnBtnApplyClick()
	{
	}

	private void OnBtnPublishedClick()
	{
	}

	private void OnBtnLocalClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
